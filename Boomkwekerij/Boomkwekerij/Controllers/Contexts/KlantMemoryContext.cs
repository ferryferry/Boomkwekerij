using System;
using System.Collections.Generic;
using Boomkwekerij.Models;
using Boomkwekerij.Controllers.Interfaces;

namespace Boomkwekerij.Controllers.Contexts
{
	public class KlantMemoryContext : IContext<Klant>
	{
		private List<Klant> klanten;
		public KlantMemoryContext()
		{
			klanten = new List<Klant>();
			klanten.Add(new Klant(1, "Ferry", "Rucphensestraat 69", "4711 JJ", "Sint Willebrord", "0165384747", "ferryjongmans@live.nl"));
			klanten.Add(new Klant(2, "Kees", "Sterstraat 11", "5574 KK", "Zegge", "0092736352", "kees@live.nl"));
			klanten.Add(new Klant(3, "Rick", "Dreefweg 83 ", "4772 KJ", "Oss", "3736253748", "rick@live.nl"));
			klanten.Add(new Klant(4, "Bram", "Kerkstraat 4", "1234 AB", "Rucphen", "7736352537", "bram@live.nl"));
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
