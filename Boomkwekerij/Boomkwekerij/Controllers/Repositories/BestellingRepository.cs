using System.Collections.Generic;
using Boomkwekerij.Controllers.Interfaces;
using Boomkwekerij.Models;

namespace Boomkwekerij.Controllers.Repositories
{
	public class BestellingRepository : IRepository<Bestelling>
	{
		private IContext<Bestelling> context;
		public BestellingRepository(IContext<Bestelling> context)
		{
			this.context = context;
		}

		public Bestelling Insert(Bestelling entity)
		{
			return context.Insert(entity);
		}

		public Bestelling Get(int id)
		{
			return context.Get(id);
		}

		public List<Bestelling> GetAll()
		{
			return context.GetAll();
		}

		public bool Remove(Bestelling entity)
		{
			return context.Remove(entity);
		}

		public bool Update(Bestelling entity)
		{
			return context.Update(entity);
		}
	}
}
