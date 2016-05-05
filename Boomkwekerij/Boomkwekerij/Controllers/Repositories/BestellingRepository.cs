using System;
using System.Collections.Generic;
using Boomkwekerij.Controllers.Interfaces;
using Boomkwekerij.Models;
using System.Collections.ObjectModel;

namespace Boomkwekerij.Controllers.Repositories
{
	public class BestellingRepository : IRepository<Bestelling>
	{
		private IContext<Bestelling> bestellingContext;
		public BestellingRepository(IContext<Bestelling> bestellingContext)
		{
			this.bestellingContext = bestellingContext;
		}

		public Bestelling Insert(Bestelling entity)
		{
			return bestellingContext.Insert(entity);
		}

		public Bestelling Get(int id)
		{
			return bestellingContext.Get(id);
		}

		public ObservableCollection<Bestelling> GetAll()
		{
			return bestellingContext.GetAll();
		}

		public bool Remove(Bestelling entity)
		{
			return bestellingContext.Remove(entity);
		}

		public bool Update(Bestelling entity)
		{
			return bestellingContext.Update(entity);
		}
	}
}
