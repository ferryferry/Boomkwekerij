using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Boomkwekerij.Models
{
	public class Bestelregel: INotifyPropertyChanged
	{
		#region Properties
		private int id;
		public int Id
		{
			get { return id; }
			set { SetField(ref id, value); }
		}

		private Plant plant;
		public Plant Plant
		{
			get { return plant; }
			set { SetField(ref plant, value); }
		}

		private int aantal;
		public int Aantal
		{
			get { return aantal; }
			set { SetField(ref aantal, value); }
		}

		private int prijs;
		public int Prijs
		{
			get { return prijs; }
			set { SetField(ref prijs, value); }
		}
		
		public ObservableCollection<Levering> Leveringen { get; set; }
		#endregion

		#region Constructors
		public Bestelregel(int id, Plant plant, int aantal, int prijs)
		{
			Id = id;
			Plant = plant;
			Aantal = aantal;
			Prijs = prijs;
			Leveringen = new ObservableCollection<Levering>();
		}

		public Bestelregel(int id, Plant plant, int aantal, int prijs, ObservableCollection<Levering> leveringen)
		{
			Id = id;
			Plant = plant;
			Aantal = aantal;
			Prijs = prijs;
			if(leveringen == null)
			{
				leveringen = new ObservableCollection<Levering>();
			}
			Leveringen = leveringen;
		}
		#endregion

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

		#region Methods
		public string GetPrijsPerStuk()
		{
			decimal prijs = Math.Round((Prijs / 100M), 3);
			return string.Format("€ {0:0.00}", prijs);
		}

		public string GetBestelregelPrijs()
		{
			decimal prijs = Math.Round((Prijs / 100M), 3);
			return string.Format("€ {0:0.00}", (prijs * Aantal));
		}
		#endregion
	}
}
