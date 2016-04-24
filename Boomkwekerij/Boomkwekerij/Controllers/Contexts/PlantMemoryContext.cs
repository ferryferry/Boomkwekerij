using System;
using System.Collections.Generic;
using Boomkwekerij.Models;
using Boomkwekerij.Controllers.Interfaces;

namespace Boomkwekerij.Controllers.Contexts
{
	public sealed class PlantMemoryContext : IContext<Plant>
	{
		private List<Plant> planten;

		public PlantMemoryContext()
		{
			planten = new List<Plant>();
			planten.Add(new Plant(1, "Hortensia", Plant.Grootte.G2040, 2, 1, "Twee takken", new Voorraad(1, 3000)));
			planten.Add(new Plant(2, "Viooltje", Plant.Grootte.G4060, 3, 1, "", new Voorraad(2, 3000)));
			planten.Add(new Plant(3, "Orchidee", Plant.Grootte.G6080, 1, 1, "Met een grote bloem", new Voorraad(3, 3000)));
			planten.Add(new Plant(4, "Berk", Plant.Grootte.G4060, 2, 1, "5+ takken", new Voorraad(4, 3000)));
			planten.Add(new Plant(5, "Den", Plant.Grootte.G80100, 1, 1, "4 takken", new Voorraad(5, 3000)));
			planten.Add(new Plant(6, "Beuk", Plant.Grootte.G140160, 3, 1, "Wit", new Voorraad(6, 3000)));
		}

		public Plant Get(int id)
		{
			return planten.Find(p => p.Id == id);
		}

		public List<Plant> GetAll()
		{
			return planten;
		}

		public Plant Insert(Plant entity)
		{
			entity.Id = planten.Count + 1;
			planten.Add(entity);
			return entity;
		}

		public bool Remove(Plant entity)
		{
			planten.Remove(entity);
			return true;
		}

		public bool Update(Plant entity)
		{
			try
			{
				planten[planten.FindIndex(p => p.Id == entity.Id)] = entity;
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
