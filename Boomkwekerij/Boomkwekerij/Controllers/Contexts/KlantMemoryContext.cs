using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Boomkwekerij.Controllers.Interfaces;
using Boomkwekerij.Models;

namespace Boomkwekerij.Controllers.Contexts
{
	public class KlantMemoryContext : IKlantContext
	{
		private IList<Klant> klanten;
		public KlantMemoryContext()
		{
			klanten = new List<Klant>();
			klanten.Add(new Klant(1, "Ferry", "Rucphensestraat 69", "4711 JJ", "Sint Willebrord", "0165384747", "ferryjongmans@live.nl"));
			klanten.Add(new Klant(1, "Kees", "Sterstraat 11", "5574 KK", "Zegge", "0092736352", "kees@live.nl"));
			klanten.Add(new Klant(1, "Rick", "Dreefweg 83 ", "4772 KJ", "Oss", "3736253748", "rick@live.nl"));
			klanten.Add(new Klant(1, "Bram", "Kerkstraat 4", "1234 AB", "Rucphen", "7736352537", "bram@live.nl"));
		}

		public void Add(Klant entity)
		{
			throw new NotImplementedException();
		}

		public void AddRange(IEnumerable<Klant> entities)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Klant> Find(Expression<Func<Klant, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public Klant Get(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Klant> GetAll()
		{
			return klanten;
		}

		public void Remove(Klant entity)
		{
			throw new NotImplementedException();
		}

		public void RemoveRange(IEnumerable<Klant> entities)
		{
			throw new NotImplementedException();
		}

		public Klant SingleOrDefault(Expression<Func<Klant, bool>> predicate)
		{
			throw new NotImplementedException();
		}
	}
}
