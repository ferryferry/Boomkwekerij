using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boomkwekerij.Controllers.Interfaces;
using Boomkwekerij.Models;
using Boomkwekerij.Controllers.Contexts;

namespace Boomkwekerij.Controllers.Repositories
{
	public class KlantRepository
	{
		private IRepository<Klant> context;
		public KlantRepository(IRepository<Klant> context)
		{
			this.context = context;
		}
		public IEnumerable<Klant> GetAll()
		{
			return context.GetAll();
		}
	}
}
