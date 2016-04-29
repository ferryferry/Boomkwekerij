using System;
using System.Collections.Generic;
using Boomkwekerij.Models;
using Boomkwekerij.Controllers.Interfaces;

namespace Boomkwekerij.Controllers.Contexts
{
	public class KlantMemoryContext : IContext<Klant>
	{
		private List<Klant> klanten;
		public KlantMemoryContext(bool useTestData = false)
		{
			if (useTestData)
			{
				klanten = TestData.GetKlanten();
			}
			else
			{
				klanten = new List<Klant>();
			}
		}

		public Klant Insert(Klant entity)
		{
			entity.Id = klanten.Count + 1;
			klanten.Add(entity);
			return entity;
		}

		public Klant Get(int id)
		{
			return klanten.Find(k=>k.Id == id);
		}

		public List<Klant> GetAll()
		{
			return klanten;
		}

		public bool Remove(Klant entity)
		{
			klanten.Remove(entity);
			return true;
		}

		public bool Update(Klant entity)
		{
			try
			{
				klanten[klanten.FindIndex(k => k.Id == entity.Id)] = entity;
				return true;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
	}
}
