using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomkwekerij.Models.Conversion
{
	public static class ConvertPlantGrootte
	{
		public static int[] Convert(Plant.Grootte plantGrootte)
		{
			string description = EnumDescriptionConverter.GetDescriptionFromEnum(plantGrootte);
			description = description.Replace("- ", "");
			string[] split = description.Split(' ');
			return new int[] { System.Convert.ToInt32(split[0]), System.Convert.ToInt32(split[1]) };
		}

		public static Plant.Grootte Convert(int minGrootte, int maxGrootte)
		{
			return EnumDescriptionConverter.GetEnumFromDescription<Plant.Grootte>(minGrootte.ToString() + " - " + maxGrootte.ToString());
		}
	}
}
