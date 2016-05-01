using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Models
{
	public sealed class Levering
	{
		public int Id { get; set; }
		public int Aantal { get; set; }
		public DateTime? Leverdatum { get; set; }
		public bool Geleverd { get; set; }

		public Levering(int id)
		{
			Id = id;
		}

		public Levering(int id, int aantal, DateTime? leverdatum, bool geleverd)
		{
			Id = id;
			Aantal = aantal;
			Leverdatum = leverdatum;
			Geleverd = geleverd;
		}
	}
}
