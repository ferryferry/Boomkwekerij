using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Models
{
	public sealed class Bestelling
	{
		public int Id { get; set; }
		public DateTime? Besteldatum { get; set; }
		public DateTime? Factuurdatum { get; set; }
		public DateTime? LaatstAfgedrukt { get; set; }
		public int ToeslagPercentage { get; set; }
		public bool Betaald { get; set; }
		public Klant Klant { get; set; }

		public List<Plant> Planten { get; set; }
		public List<Levering> Leveringen { get; set; }


		public Bestelling(int id, DateTime besteldatum, DateTime factuurdatum, DateTime laatstAfgedrukt, int toeslagPercentage, bool betaald, Klant klant)
		{
			Id = id;
			Besteldatum = besteldatum;
			Factuurdatum = factuurdatum;
			LaatstAfgedrukt = laatstAfgedrukt;
			ToeslagPercentage = toeslagPercentage;
			Betaald = betaald;
			Klant = klant;

			Planten = new List<Plant>();
			Leveringen = new List<Levering>();
		}
	}
}
