using System.Collections.Generic;

namespace Boomkwekerij.Models
{
	public class Bestelregel
	{
		public int Id { get; set; }
		public Plant Plant { get; set; }
		public int Aantal { get; set; }
		public int Prijs { get; set; }
		public List<Levering> Leveringen { get; set; }

		public Bestelregel(int id)
		{
			Id = id;
		}
		public Bestelregel(int id, Plant plant, int aantal, int prijs, List<Levering> leveringen)
		{
			Id = id;
			Plant = plant;
			Aantal = aantal;
			Prijs = prijs;
			Leveringen = leveringen;
		}
	}
}
