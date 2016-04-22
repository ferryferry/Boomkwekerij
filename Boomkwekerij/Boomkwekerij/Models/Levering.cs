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
		public int AantalGeleverd { get; set; }
		public DateTime? Leverdatum { get; set; }
		public bool Geleverd { get; set; }
	}
}
