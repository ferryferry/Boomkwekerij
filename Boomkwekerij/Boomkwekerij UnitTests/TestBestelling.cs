using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boomkwekerij.Controllers.Repositories;
using System.Collections.ObjectModel;
using Boomkwekerij.Models;
using Boomkwekerij.Controllers.Contexts;
using System.Collections.Generic;

namespace Boomkwekerij_UnitTests
{
	[TestClass]
	public class TestBestelling
	{
		private BestellingRepository bestellingRepo;
		private ObservableCollection<Bestelling> bestellingen;

		[TestInitialize]
		public void Initialize()
		{
			bestellingRepo = new BestellingRepository(new BestellingMemoryContext());
			bestellingen = new ObservableCollection<Bestelling>(bestellingRepo.GetAll());

			List<ToeslagPercentage> toeslagPercentage = new List<ToeslagPercentage>();
			toeslagPercentage.Add(new ToeslagPercentage(0, 1275, DateTime.Now.AddDays(-30), DateTime.Now.AddDays(-1)));
			toeslagPercentage.Add(new ToeslagPercentage(1, 571, DateTime.Now.AddDays(-1)));

			bestellingen.Add(new Bestelling(1, DateTime.Now.AddDays(-4), DateTime.Now, DateTime.Now, toeslagPercentage[0], false, new Klant(1), new List<Bestelregel>()
			{
				new Bestelregel(1, new Plant(1), 40, 45,
				new ObservableCollection<Levering>()
				{
					new Levering(1,20,DateTime.Now.AddDays(-2), true),
					new Levering(2,20,DateTime.Now, true)
				}),
				new Bestelregel(2, new Plant(2), 40, 23),
				new Bestelregel(3, new Plant(2), 40, 25),
				new Bestelregel(4, new Plant(2), 40, 32),
			}));

			bestellingen.Add(new Bestelling(2, DateTime.Now.AddDays(-4), DateTime.Now, DateTime.Now, toeslagPercentage[0], false, new Klant(1), new List<Bestelregel>()
			{
				new Bestelregel(1, new Plant(1), 1, 100),
			}));

			bestellingen.Add(new Bestelling(3, DateTime.Now, DateTime.Now, DateTime.Now, toeslagPercentage[0], false, new Klant(1), new List<Bestelregel>()));
		}


		[TestMethod]
		public void TestDecimalTotaalprijsEx()
		{
			// Bestelling met meedere producten
			Assert.AreEqual(50.00M, bestellingen[0].BerekenTotaalprijsEx());
			// Bestelling met een product
			Assert.AreEqual(1.00M, bestellingen[1].BerekenTotaalprijsEx());
			// Bestelling zonder producten
			Assert.AreEqual(0, bestellingen[2].BerekenTotaalprijsEx());
		}

		[TestMethod]
		public void TestDecimalTotaalprijs()
		{
			// Bestelling met meedere producten
			Assert.AreEqual(56.38M, bestellingen[0].BerekenTotaalprijs());
			// Bestelling met een product
			Assert.AreEqual(1.13M, bestellingen[1].BerekenTotaalprijs());
			// Bestelling zonder producten
			Assert.AreEqual(0, bestellingen[2].BerekenTotaalprijs());
		}

		[TestCleanup]
		public void Cleanup()
		{
			bestellingRepo = null;
			bestellingen = null;
			ToeslagPercentage.Percentages = null;
		}
	}
}
