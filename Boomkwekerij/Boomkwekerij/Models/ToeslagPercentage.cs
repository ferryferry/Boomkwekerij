using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Models
{
	public sealed class ToeslagPercentage
	{
		public int Id { get; set; }
		public decimal Percentage { get; set; }
		public DateTime Startdatum { get; set; }
		public DateTime? Einddatum { get; set; }

		public ToeslagPercentage(int id, int percentage, DateTime startdatum, DateTime? einddatum = null)
		{
			Id = id;
			Percentage = percentage;
			Startdatum = startdatum;
			Einddatum = einddatum;
		}

		public override string ToString()
		{
			return (Percentage / 100).ToString() + " %";
		}
	}
}
