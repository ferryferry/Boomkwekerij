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

		public BestellingMemoryContext(bool useTestData = false)
		{
			if (useTestData)
			{
				bestellingen = TestData.GetBestellingen();
			}
			else
			{
				bestellingen = new List<Bestelling>();
			}
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
