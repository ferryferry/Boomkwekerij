using Boomkwekerij.Controllers.Interfaces;
using Boomkwekerij.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Controllers.Repositories
{
	public sealed class PlantRepository  : IRepository<Plant>
	{
		private IContext<Plant> context;
		public PlantRepository(IContext<Plant> context)
		{
			this.context = context;
		}

		public Plant Get(int id)
		{
			return context.Get(id);
		}

		public List<Plant> GetAll()
		{
			return context.GetAll();
		}

		public Plant Insert(Plant entity)
		{
			return context.Insert(entity);
		}

		public bool Remove(Plant entity)
		{
			return context.Remove(entity);
		}

		public bool Update(Plant entity)
		{
			return context.Update(entity);
		}
	}
}
