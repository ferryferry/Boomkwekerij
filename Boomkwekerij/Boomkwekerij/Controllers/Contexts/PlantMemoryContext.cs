using System;
using System.Collections.Generic;
using Boomkwekerij.Models;
using Boomkwekerij.Controllers.Interfaces;
using System.Collections.ObjectModel;
using System.Linq;

namespace Boomkwekerij.Controllers.Contexts
{
	public sealed class PlantMemoryContext : IContext<Plant>
	{
		private ObservableCollection<Plant> planten;

		public PlantMemoryContext(bool useTestData = false)
		{
			if (useTestData)
			{
				planten = TestData.GetPlanten();
			}
			else
			{
				planten = new ObservableCollection<Plant>();
			}
		}

		public Plant Get(int id)
		{
			return planten.Single(p => p.Id == id);
		}

		public ObservableCollection<Plant> GetAll()
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
				Plant plant = planten.Single(p => p.Id == entity.Id);
				plant = entity;
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
