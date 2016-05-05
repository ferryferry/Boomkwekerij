using System;
using System.Collections.Generic;
using Boomkwekerij.Models;
using Boomkwekerij.Controllers.Interfaces;
using System.Collections.ObjectModel;
using System.Linq;

namespace Boomkwekerij.Controllers.Contexts
{
	public class KlantMemoryContext : IContext<Klant>
	{
		private ObservableCollection<Klant> klanten;
		public KlantMemoryContext(bool useTestData = false)
		{
			if (useTestData)
			{
				klanten = TestData.GetKlanten();
			}
			else
			{
				klanten = new ObservableCollection<Klant>();
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
			return klanten.Single(k=>k.Id == id);
		}

		public ObservableCollection<Klant> GetAll()
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
				Klant klant = klanten.Single(k => k.Id == entity.Id);
				klant = entity;
				return true;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
	}
}
