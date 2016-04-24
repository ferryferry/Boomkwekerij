using System;
using System.Collections.Generic;
using Boomkwekerij.Controllers.Repositories;
using Boomkwekerij.Controllers.Contexts;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace Boomkwekerij.Models
{
	public sealed class Kwekerij
	{
		// Properties
		public string Bedrijfsnaam { get; private set; }
		public string Straat { get; private set; }
		public string Postcode { get; private set; }
		public string Plaats { get; private set; }
		public string Telefoonnummer { get; private set; }
		public string Faxnummer { get; private set; }
		public string Mobiel { get; private set; }
		public string Email { get; private set; }
		public string Iban { get; private set; }
		public string BtwNummer { get; private set; }
		public string KvkNummer { get; private set; }

		public ObservableCollection<Klant> Klanten { get; private set; }
		public ObservableCollection<Plant> Planten { get; private set; }
		public ObservableCollection<Bestelling> Bestellingen { get; private set; }

		public KlantRepository klantRepo { get; private set; }
		public BestellingRepository bestellingRepo { get; private set; }
		public PlantRepository plantRepo { get; private set; }

		#region Constructor
		public Kwekerij(string bedrijfsnaam, string straat, string postcode, string plaats, string telefoonnummer, string faxnummer, string mobiel, string email, string iban, string btwNummer, string kvkNummer)
		{
			// Initialize Properties
			Bedrijfsnaam = bedrijfsnaam;
			Straat = straat;
			Postcode = postcode;
			Plaats = plaats;
			Telefoonnummer = telefoonnummer;
			Faxnummer = faxnummer;
			Mobiel = mobiel;
			Email = email;
			Iban = iban;
			BtwNummer = btwNummer;
			KvkNummer = kvkNummer;

			// Initialize Repositories with Contexts
			klantRepo = new KlantRepository(new KlantMemoryContext());
			bestellingRepo = new BestellingRepository(new BestellingMemoryContext());
			plantRepo = new PlantRepository(new PlantMemoryContext());

			// Initialize Lists
			Klanten = new ObservableCollection<Klant>(klantRepo.GetAll());
			Planten = new ObservableCollection<Plant>(plantRepo.GetAll());
			Bestellingen = new ObservableCollection<Bestelling>(bestellingRepo.GetAll());

			// Bind
			foreach(Bestelling bestelling in Bestellingen)
			{
				bestelling.Klant = Klanten.Single(k=>k.Id == bestelling.Klant.Id);
				foreach(Bestelregel bestelregel in bestelling.Bestelregels)
				{
					bestelregel.Plant = Planten.Single(p => p.Id == bestelregel.Plant.Id);
				}
			}

			// Initialialize Change Events in Observable Lists
			Klanten.CollectionChanged += Klanten_CollectionChanged;
			foreach (INotifyPropertyChanged klant in Klanten)
			{
				klant.PropertyChanged += ItemPropertyChanged;
			}
		}
		#endregion

		#region Klanten gewijzigd
		private void Klanten_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (e.NewItems != null)
			{
				foreach (Klant klant in e.NewItems)
				{
					klantRepo.Insert(klant);
					((INotifyPropertyChanged)klant).PropertyChanged += ItemPropertyChanged;
				}
			}
			if (e.OldItems != null)
			{
				foreach (Klant klant in e.OldItems)
				{
					klantRepo.Remove(klant);
					((INotifyPropertyChanged)klant).PropertyChanged -= ItemPropertyChanged;
				}
			}
		}

		private void ItemPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			klantRepo.Update((Klant)sender);
		}
		#endregion
	}
}
