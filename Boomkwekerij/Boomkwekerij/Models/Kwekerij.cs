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
		#region Properties
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
		#endregion

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
			klantRepo = new KlantRepository(new KlantSQLiteContext());
			bestellingRepo = new BestellingRepository(new BestellingSQLiteContext());
			plantRepo = new PlantRepository(new PlantSQLiteContext());

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
			Klanten.CollectionChanged += ObservableListCollection_CollectionChanged;
			foreach (Klant klant in Klanten)
			{
				klant.PropertyChanged += ItemPropertyChanged;
			}

			Planten.CollectionChanged += ObservableListCollection_CollectionChanged;
			foreach (Plant plant in Planten)
			{
				plant.PropertyChanged += ItemPropertyChanged;
			}

			Bestellingen.CollectionChanged += ObservableListCollection_CollectionChanged;
			foreach (Bestelling bestelling in Bestellingen)
			{
				bestelling.PropertyChanged += ItemPropertyChanged;
				bestelling.Bestelregels.CollectionChanged += ObservableListCollection_CollectionChanged;
				foreach (Bestelregel bestelregel in bestelling.Bestelregels)
				{
					bestelregel.Leveringen.CollectionChanged += ObservableListCollection_CollectionChanged;
				}
			}
		}

		#endregion

		#region ObservableListCollection Collection Changed
		private void ObservableListCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (e.NewItems != null)
			{
				foreach (object item in e.NewItems)
				{
					if (item is Plant)
					{
						plantRepo.Insert((Plant)item);
					}
					else if(item is Klant)
					{
						klantRepo.Insert((Klant)item);
					}
					else if(item is Bestelling)
					{
						bestellingRepo.Insert((Bestelling)item);
					}
					((INotifyPropertyChanged)item).PropertyChanged += ItemPropertyChanged;
				}
			}
			if (e.OldItems != null)
			{
				foreach (object item in e.OldItems)
				{
					if (item is Plant)
					{
						if (!plantRepo.Remove((Plant)item))
						{
							Planten.CollectionChanged -= ObservableListCollection_CollectionChanged;
							Planten.Add((Plant)item);
							Planten.CollectionChanged += ObservableListCollection_CollectionChanged;
							System.Windows.Forms.MessageBox.Show("Deze plant kan niet worden verwijderd. Er zijn bestellingen voor deze plant in het systeem!", "Fout!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
						}
					}
					else if (item is Klant)
					{
						if (!klantRepo.Remove((Klant)item))
						{
							Klanten.CollectionChanged -= ObservableListCollection_CollectionChanged;
							Klanten.Add((Klant)item);
							Klanten.CollectionChanged += ObservableListCollection_CollectionChanged;
							System.Windows.Forms.MessageBox.Show("Deze klant kan niet worden verwijderd omdat er geregistreerde bestellingen in het systeem staan voor deze klant.","Klant kan niet worden verwijderd!",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
						}
					}
					else if (item is Bestelling)
					{
						bestellingRepo.Remove((Bestelling)item);
					}
					else if (item is Bestelregel)
					{
						bestellingRepo.Remove((Bestelregel)item);
					}
					else if (item is Levering)
					{
						bestellingRepo.Remove((Levering)item);
					}
					((INotifyPropertyChanged)item).PropertyChanged -= ItemPropertyChanged;
				}
			}
		}

		private void ItemPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (sender is Plant)
			{
				plantRepo.Update((Plant)sender);
			}
			else if (sender is Klant)
			{
				klantRepo.Update((Klant)sender);
			}
			else if (sender is Bestelling)
			{
				bestellingRepo.Update((Bestelling)sender);
			}
		}
		#endregion
	}
}
