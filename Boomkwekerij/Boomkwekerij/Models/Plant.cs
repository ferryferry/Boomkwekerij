using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Models
{
	public sealed class Plant
	{
		public int Id { get; set; }
		public string Naam { get; set; }
		public int MinimaleGrootte { get; set; }
		public int MaximaleGrootte { get; set; }
		public int Zaailing { get; set; }
		public int Verplant { get; set; }
		public string Opmerking { get; set; }

		public Plant(int id, string naam, int minimaleGrootte, int maximaleGrootte, int zaailing, int verplant, string opmerking)
		{
			Id = id;
			Naam = naam;
			MinimaleGrootte = minimaleGrootte;
			MaximaleGrootte = maximaleGrootte;
			Zaailing = zaailing;
			Verplant = verplant;
			Opmerking = opmerking;
		}
	}
}
