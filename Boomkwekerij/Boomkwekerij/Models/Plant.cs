using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boomkwekerij.Models.Conversion;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace Boomkwekerij.Models
{
	public sealed class Plant : INotifyPropertyChanged
	{
		#region Enums
		public enum Grootte
		{
			[Description("0 - 20")]
			G0020,
			[Description("20 - 40")]
			G2040,
			[Description("40 - 60")]
			G4060,
			[Description("60 - 80")]
			G6080,
			[Description("80 - 100")]
			G80100,
			[Description("100 - 120")]
			G100120,
			[Description("120 - 140")]
			G120140,
			[Description("140 - 160")]
			G140160,
			[Description("160 - 180")]
			G160180,
			[Description("180 - 200")]
			G180200,
			[Description("200 - 220")]
			G200220
		}
		#endregion

		#region Properties
		private int id;
		public int Id
		{
			get { return id; }
			set { SetField(ref id, value); }
		}

		private string naam;
		public string Naam
		{
			get { return naam; }
			set { SetField(ref naam, value); }
		}

		private Grootte plantGrootte;
		public Plant.Grootte PlantGrootte
		{
			get { return plantGrootte; }
			set { SetField(ref plantGrootte, value); }
		}

		private int zaailing;
		public int Zaailing
		{
			get { return zaailing; }
			set { SetField(ref zaailing, value); }
		}

		private int verplant;
		public int Verplant
		{
			get { return verplant; }
			set { SetField(ref verplant, value); }
		}

		private int voorraad;
		public int Voorraad
		{
			get { return voorraad; }
			set { SetField(ref voorraad, value); }
		}

		private string opmerking;
		public string Opmerking
		{
			get { return opmerking; }
			set { SetField(ref opmerking, value); }
		}
		#endregion

		#region Constructors
		public Plant(int id)
		{
			Id = id;
		}

		public Plant(int id, string naam, Grootte plantGrootte, int zaailing, int verplant, string opmerking, int voorraad)
		{
			Id = id;
			Naam = naam;
			PlantGrootte = plantGrootte;
			Zaailing = zaailing;
			Verplant = verplant;
			Opmerking = opmerking;
			Voorraad = voorraad;
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
		public int MinHoogte()
		{
			return ConvertPlantGrootte.Convert(PlantGrootte)[0];
		}

		public int MaxHoogte()
		{
			return ConvertPlantGrootte.Convert(PlantGrootte)[1];
		}

		public string Jaren()
		{
			return Zaailing.ToString() + " - " + Verplant.ToString();
		}

		public bool CheckVoorraad(int aantal)
		{
			if(Voorraad >= aantal)
			{
				return true;
			}
			return false;
		}

		public Bestelregel BestelPlant(int aantal, int prijs, ObservableCollection<Bestelregel> bestelregels)
		{
			if (CheckVoorraad(aantal))
			{
				Voorraad -= aantal;
				if (bestelregels.Where(br => br.Plant.Id == Id).Count()>1)
				{
					Bestelregel bestelregel = bestelregels.Single(br => br.Plant.Id == Id);
					bestelregel.Aantal += aantal;
					return null;
				}
				else
				{
					return new Bestelregel(0, this, aantal, prijs);
				}
			}
			return null;
		}

		public override string ToString()
		{
			return Naam;
		}
		#endregion
	}
}
