using System;
using System.Collections.Generic;
using Boomkwekerij.Models;
using Boomkwekerij.Controllers.Interfaces;

namespace Boomkwekerij.Controllers.Contexts
{
	public sealed class PlantMemoryContext : IPlantContext
	{
		private List<Plant> planten;

		public PlantMemoryContext(bool useTestData = false)
		{
			if (useTestData)
			{
				planten = TestData.GetPlanten();
			}
			else
			{
				planten = new List<Plant>();
			}
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

		public bool Update(Voorraad entity)
		{
			try
			{
				planten.Find(p => p.Voorraad.Id == entity.Id).Voorraad = entity;
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
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
