using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boomkwekerij.Controllers.Interfaces;
using Boomkwekerij.Models;
using Boomkwekerij.Controllers.Contexts;
using System.Collections.ObjectModel;

namespace Boomkwekerij.Controllers.Repositories
{
	public class KlantRepository : IRepository<Klant>
	{
		private IContext<Klant> context;
		public KlantRepository(IContext<Klant> context)
		{
			this.context = context;
		}

		public Klant Insert(Klant entity)
		{
			return context.Insert(entity);
		}

		public Klant Get(int id)
		{
			return context.Get(id);
		}

		public ObservableCollection<Klant> GetAll()
		{
			return context.GetAll();
		}

		public bool Remove(Klant entity)
		{
			return context.Remove(entity);
		}

		public bool Update(Klant entity)
		{
			return context.Update(entity);
		}
	}
}
