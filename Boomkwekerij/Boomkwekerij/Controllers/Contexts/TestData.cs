using Boomkwekerij.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Controllers.Contexts
{
	public static class TestData
	{
		public static List<Bestelling> GetBestellingen()
		{
			List<ToeslagPercentage> toeslagPercentage = new List<ToeslagPercentage>();
			toeslagPercentage.Add(new ToeslagPercentage(0, 1275, DateTime.Now.AddDays(-30), DateTime.Now.AddDays(-1)));
			toeslagPercentage.Add(new ToeslagPercentage(1, 571, DateTime.Now.AddDays(-1)));

			List<Bestelling> bestellingen = new List<Bestelling>();
			bestellingen.Add(new Bestelling(1, DateTime.Now.AddDays(-4), DateTime.Now, DateTime.Now, toeslagPercentage[0], false, new Klant(1), new List<Bestelregel>()
			{
				new Bestelregel(1, new Plant(1), 40, 45,
				new ObservableCollection<Levering>()
				{
					new Levering(1,20,DateTime.Now.AddDays(-2), true),
					new Levering(2,20,DateTime.Now, true)
				}),
				new Bestelregel(2, new Plant(2), 40, 23, null),
				new Bestelregel(3, new Plant(2), 40, 25, null),
				new Bestelregel(4, new Plant(2), 40, 32, null),
			}));
			bestellingen.Add(new Bestelling(2, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-2), DateTime.Now, toeslagPercentage[0], false, new Klant(2), new List<Bestelregel>()
			{
				new Bestelregel(1, new Plant(3), 40, 45, null),
				new Bestelregel(2, new Plant(4), 40, 23, null),
				new Bestelregel(3, new Plant(5), 40, 25, null),
				new Bestelregel(4, new Plant(6), 40, 32, null),
			}));
			bestellingen.Add(new Bestelling(3, DateTime.Now.AddDays(-4), DateTime.Now.AddDays(-3), DateTime.Now, toeslagPercentage[0], false, new Klant(3), new List<Bestelregel>()
			{
				new Bestelregel(1, new Plant(1), 40, 45, null),
				new Bestelregel(2, new Plant(2), 40, 23, null),
				new Bestelregel(3, new Plant(3), 40, 25, null),
				new Bestelregel(4, new Plant(4), 40, 32, null),
			}));
			bestellingen.Add(new Bestelling(4, DateTime.Now.AddDays(-3), DateTime.Now.AddDays(-4), DateTime.Now, toeslagPercentage[0], false, new Klant(2), new List<Bestelregel>()
			{
				new Bestelregel(1, new Plant(3), 40, 45, null),
				new Bestelregel(2, new Plant(2), 40, 23, null),
				new Bestelregel(3, new Plant(4), 40, 25, null),
				new Bestelregel(4, new Plant(1), 40, 32, null),
			}));
			bestellingen.Add(new Bestelling(5, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(-5), DateTime.Now, toeslagPercentage[1], false, new Klant(1), new List<Bestelregel>()
			{
				new Bestelregel(1, new Plant(1), 40, 45, null),
				new Bestelregel(2, new Plant(2), 40, 23, null),
				new Bestelregel(3, new Plant(2), 40, 25, null),
				new Bestelregel(4, new Plant(2), 40, 32, null),
			}));
			return bestellingen;
		}

		public static List<Klant> GetKlanten()
		{
			List<Klant> klanten = new List<Klant>();
			klanten.Add(new Klant(1, "Ferry", "Rucphensestraat 69", "4711 JJ", "Sint Willebrord", "0165384747", "ferryjongmans@live.nl"));
			klanten.Add(new Klant(2, "Kees", "Sterstraat 11", "5574 KK", "Zegge", "0092736352", "kees@live.nl"));
			klanten.Add(new Klant(3, "Rick", "Dreefweg 83 ", "4772 KJ", "Oss", "3736253748", "rick@live.nl"));
			klanten.Add(new Klant(4, "Bram", "Kerkstraat 4", "1234 AB", "Rucphen", "7736352537", "bram@live.nl"));
			return klanten;
		}

		public static List<Plant> GetPlanten()
		{
			List<Plant> planten = new List<Plant>();
			planten.Add(new Plant(1, "Hortensia", Plant.Grootte.G2040, 2, 1, "Twee takken", 3000));
			planten.Add(new Plant(2, "Viooltje", Plant.Grootte.G4060, 3, 1, "", 3000));
			planten.Add(new Plant(3, "Orchidee", Plant.Grootte.G6080, 1, 1, "Met een grote bloem", 3000));
			planten.Add(new Plant(4, "Berk", Plant.Grootte.G4060, 2, 1, "5+ takken", 3000));
			planten.Add(new Plant(5, "Den", Plant.Grootte.G80100, 1, 1, "4 takken", 3000));
			planten.Add(new Plant(6, "Beuk", Plant.Grootte.G140160, 3, 1, "Wit", 3000));
			return planten;
		}
	}
}
