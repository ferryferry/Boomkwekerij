﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Models
{
	public sealed class Bestelling : INotifyPropertyChanged
	{
		#region Properties
		private int id;
		public int Id
		{
			get { return id; }
			set { SetField(ref id, value); }
		}

		private DateTime? besteldatum;
		public DateTime? Besteldatum
		{
			get { return besteldatum; }
			set { SetField(ref besteldatum, value); }
		}

		private DateTime? factuurdatum;
		public DateTime? Factuurdatum
		{
			get { return factuurdatum; }
			set { SetField(ref factuurdatum, value); }
		}

		private DateTime? laatstAfgedrukt;
		public DateTime? LaatstAfgedrukt
		{
			get { return laatstAfgedrukt; }
			set { SetField(ref laatstAfgedrukt, value); }
		}

		private ToeslagPercentage toeslagPercentage;
		public ToeslagPercentage ToeslagPercentage
		{
			get { return toeslagPercentage; }
			set { SetField(ref toeslagPercentage, value); }
		}

		private bool betaald;
		public bool Betaald
		{
			get { return betaald; }
			set { SetField(ref betaald, value); }
		}

		private Klant klant;
		public Klant Klant
		{
			get { return klant; }
			set { SetField(ref klant, value); }
		}

		private ObservableCollection<Bestelregel> bestelregels;
		public ObservableCollection<Bestelregel> Bestelregels
		{
			get { return bestelregels; }
			set { SetField(ref bestelregels, value); }
		}

		#endregion

		#region Constructors
		public Bestelling(int id)
		{
			Id = id;
			Bestelregels = new ObservableCollection<Bestelregel>();
		}
		public Bestelling(int id, DateTime? besteldatum, DateTime? factuurdatum, DateTime? laatstAfgedrukt, ToeslagPercentage toeslagPercentage, bool betaald, Klant klant, ObservableCollection<Bestelregel> bestelregels)
		{
			Id = id;
			Besteldatum = besteldatum;
			Factuurdatum = factuurdatum;
			LaatstAfgedrukt = laatstAfgedrukt;
			ToeslagPercentage = toeslagPercentage;
			Betaald = betaald;
			Klant = klant;
			Bestelregels = bestelregels;
			if(bestelregels == null)
			{
				Bestelregels = new ObservableCollection<Bestelregel>();
			}
			else
			{
				bestelregels.CollectionChanged += Bestelregels_CollectionChanged;
				foreach(Bestelregel br in Bestelregels)
				{
					br.PropertyChanged += ItemPropertyChanged;
					br.Leveringen.CollectionChanged += Leveringen_CollectionChanged;
					foreach(Levering l in br.Leveringen)
					{
						l.PropertyChanged += ItemPropertyChanged;
					}
				}
			}
		}

		private void Leveringen_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			OnPropertyChanged("Bestelregels");
		}

		private void Bestelregels_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			OnPropertyChanged("Bestelregels");
		}

		private void ItemPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			OnPropertyChanged(e.PropertyName);
		}
		#endregion

		#region EventHandlers
		#region PropertyChangedEvent
		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		private bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
		{
			if (EqualityComparer<T>.Default.Equals(field, value)) return false;
			field = value;
			OnPropertyChanged(propertyName);
			return true;
		}
		#endregion
		#endregion

		#region Methods
		public decimal BerekenTotaalprijs()
		{
			decimal prijsInclusief = BerekenTotaalprijsEx() * (1 + ToeslagPercentage.GetValidPercentageForDate(Besteldatum) / 100);
			return Math.Round((prijsInclusief), 2);
		}

		public decimal BerekenTotaalprijsEx()
		{
			int prijs = 0;
			foreach (Bestelregel bestelregel in Bestelregels)
			{
				prijs += bestelregel.Prijs * bestelregel.Aantal;
			}
			return Math.Round((prijs / 100M), 3);
		}

		public string FormattedToeslagBedrag()
		{
			return string.Format("€ {0:0.00}", BerekenTotaalprijs()-BerekenTotaalprijsEx());
		}

		public string FormattedPrijsEx()
		{
			return string.Format("€ {0:0.00}", BerekenTotaalprijsEx());
		}

		public string FormattedPrijs()
		{
			return string.Format("€ {0:0.00}", BerekenTotaalprijs());
		}

		#endregion
	}
}
