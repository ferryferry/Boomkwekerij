using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boomkwekerij.Models.Conversion;

namespace Boomkwekerij.Models
{
	public sealed class Plant
	{
		public enum Grootte
		{
			[Description("10 - 20")]
			G1020,
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
		public int Id { get; set; }
		public string Naam { get; set; }
		public Grootte PlantGrootte { get; set; }
		public int Zaailing { get; set; }
		public int Verplant { get; set; }
		public string Opmerking { get; set; }
		public Voorraad Voorraad { get; set; }

		public Plant(int id)
		{
			Id = id;
		}

		public Plant(int id, string naam, Grootte plantGrootte, int zaailing, int verplant, string opmerking, Voorraad voorraad)
		{
			Id = id;
			Naam = naam;
			PlantGrootte = plantGrootte;
			Zaailing = zaailing;
			Verplant = verplant;
			Opmerking = opmerking;
			Voorraad = voorraad;
		}

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
	}
}
