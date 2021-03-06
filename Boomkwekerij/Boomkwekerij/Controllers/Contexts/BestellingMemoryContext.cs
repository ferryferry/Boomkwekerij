﻿using System;
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
	public class BestellingMemoryContext : IBestellingContext
	{
		private ObservableCollection<Bestelling> bestellingen;

		public BestellingMemoryContext(bool useTestData = false)
		{
			if (useTestData)
			{
				bestellingen = TestData.GetBestellingen();
			}
			else
			{
				bestellingen = new ObservableCollection<Bestelling>();
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
			return bestellingen.Single(b => b.Id == id);
		}

		public ObservableCollection<Bestelling> GetAll()
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
				Bestelling bestelling = bestellingen.Single(b => b.Id == entity.Id);
				bestelling = entity;
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public bool Remove(Bestelregel entity)
		{
			foreach(Bestelling b in bestellingen)
			{
				foreach(Bestelregel br in b.Bestelregels)
				{
					if(br == entity)
					{
						b.Bestelregels.Remove(br);
						return true;
					}
				}
			}
			return false;
		}

		public bool Remove(Levering entity)
		{
			foreach (Bestelling b in bestellingen)
			{
				foreach (Bestelregel br in b.Bestelregels)
				{
					foreach(Levering l in br.Leveringen)
					{
						if(l == entity)
						{
							br.Leveringen.Remove(l);
							return true;
						}
					}
				}
			}
			return false;
		}
	}
}
