using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boomkwekerij.Models;
using Boomkwekerij.Controllers.Interfaces;
using System.Linq.Expressions;
using System.Collections.ObjectModel;

namespace Boomkwekerij.Controllers.Contexts
{
	public class BestellingMemoryContext : IContext<Bestelling>
	{
		private List<Bestelling> bestellingen;

		public BestellingMemoryContext()
		{
			bestellingen = new List<Bestelling>();
			bestellingen.Add(new Bestelling(1,DateTime.Now.AddDays(-4), DateTime.Now.AddDays(-1), DateTime.Now, new ToeslagPercentage(0, 571, DateTime.Now.AddDays(-12)), false, new Klant(1), new List<Bestelregel>()
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
			bestellingen.Add(new Bestelling(2, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-2), DateTime.Now, new ToeslagPercentage(0, 571, DateTime.Now.AddDays(-12)), false, new Klant(2), new List<Bestelregel>()
			{
				new Bestelregel(1, new Plant(3), 40, 45, null),
				new Bestelregel(2, new Plant(4), 40, 23, null),
				new Bestelregel(3, new Plant(5), 40, 25, null),
				new Bestelregel(4, new Plant(6), 40, 32, null),
			}));
			bestellingen.Add(new Bestelling(3, DateTime.Now.AddDays(-4), DateTime.Now.AddDays(-3), DateTime.Now, new ToeslagPercentage(0, 571, DateTime.Now.AddDays(-12)), false, new Klant(3), new List<Bestelregel>()
			{
				new Bestelregel(1, new Plant(1), 40, 45, null),
				new Bestelregel(2, new Plant(2), 40, 23, null),
				new Bestelregel(3, new Plant(3), 40, 25, null),
				new Bestelregel(4, new Plant(4), 40, 32, null),
			}));
			bestellingen.Add(new Bestelling(4, DateTime.Now.AddDays(-3), DateTime.Now.AddDays(-4), DateTime.Now, new ToeslagPercentage(0, 571, DateTime.Now.AddDays(-12)), false, new Klant(2), new List<Bestelregel>()
			{
				new Bestelregel(1, new Plant(3), 40, 45, null),
				new Bestelregel(2, new Plant(2), 40, 23, null),
				new Bestelregel(3, new Plant(4), 40, 25, null),
				new Bestelregel(4, new Plant(1), 40, 32, null),
			}));
			bestellingen.Add(new Bestelling(5, DateTime.Now.AddDays(-5), DateTime.Now.AddDays(-5), DateTime.Now, new ToeslagPercentage(0, 571, DateTime.Now.AddDays(-12)), false, new Klant(1), new List<Bestelregel>()
			{
				new Bestelregel(1, new Plant(1), 40, 45, null),
				new Bestelregel(2, new Plant(2), 40, 23, null),
				new Bestelregel(3, new Plant(2), 40, 25, null),
				new Bestelregel(4, new Plant(2), 40, 32, null),
			}));

		}

		public Bestelling Insert(Bestelling entity)
		{
			entity.Id = bestellingen.Count + 1;
			bestellingen.Add(entity);
			return entity;
		}

		public Bestelling Get(int id)
		{
			return bestellingen.Find(b => b.Id == id);
		}

		public List<Bestelling> GetAll()
		{
			return bestellingen;
		}

		public bool Remove(Bestelling entity)
		{
			bestellingen.Remove(entity);
			return true;
		}

		public bool Update(Bestelling entity)
		{
			try
			{
				bestellingen[bestellingen.FindIndex(k => k.Id == entity.Id)] = entity;
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
