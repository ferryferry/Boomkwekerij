using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Models
{
	public sealed class Voorraad
	{
		public int Id { get; set; }
		public int Aantal { get; set; }
		public Plant Plant { get; set; }

		public Voorraad(int id, int aantal, Plant plant)
		{
			Id = id;
			Aantal = aantal;
			Plant = plant;
		}
	}
}
