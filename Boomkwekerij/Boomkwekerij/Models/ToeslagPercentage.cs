using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Models
{
	public class ToeslagPercentage
	{
		public int Id { get; set; }
		public decimal Percentage { get; set; }
		public DateTime Startdatum { get; set; }
		public DateTime? Einddatum { get; set; }
		public static List<ToeslagPercentage> Percentages { get; set; }

		public ToeslagPercentage(int id, int percentage, DateTime startdatum, DateTime? einddatum = null)
		{
			Id = id;
			Percentage = percentage;
			Startdatum = startdatum;
			Einddatum = einddatum;
			if(Percentages == null)
			{
				Percentages = new List<ToeslagPercentage>();
			}
			
			Percentages.Add(this);
		}

		public static ToeslagPercentage GetValidToeslagPercentageForDate(DateTime? searchDate)
		{ 
			if(searchDate == null)
			{
				return null;
			}
			return Percentages.Single(p => (p.Startdatum.Date.Ticks <= searchDate.Value.Ticks && p.Einddatum == null) || (p.Startdatum.Ticks <= searchDate.Value.Ticks && p.Einddatum.Value.Ticks >= searchDate.Value.Ticks));
		}

		public static decimal GetValidPercentageForDate(DateTime? searchDate)
		{
			if(searchDate == null)
			{
				return 0;
			}
			return GetValidToeslagPercentageForDate(searchDate).Percentage / 100M;
		}

		public override string ToString()
		{
			return (Percentage / 100M).ToString() + " %";
		}
	}
}
