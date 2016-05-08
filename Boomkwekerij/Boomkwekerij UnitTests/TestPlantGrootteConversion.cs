using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boomkwekerij.Models;
using Boomkwekerij.Models.Conversion;
using System.Collections.Generic;

namespace Boomkwekerij_UnitTests
{
	[TestClass]
	public class TestPlantGrootteConversion
	{
		[TestMethod]
		public void TestEumToNumbers()
		{
			int[] plantGrootte = ConvertPlantGrootte.Convert(Plant.Grootte.G120140);
			Assert.AreEqual(120, plantGrootte[0]);
			Assert.AreEqual(140, plantGrootte[1]);
		}

		[TestMethod]
		public void TestNumbersToEnum()
		{
			Plant.Grootte plantGrootte = ConvertPlantGrootte.Convert(120, 140);
			Assert.AreEqual(Plant.Grootte.G120140, plantGrootte);
		}

		[TestMethod]
		public void TestGetPlantGrootteId()
		{
			Assert.AreEqual(1, ConvertPlantGrootte.GetPlantGrootteId(Plant.Grootte.G0020));
			Assert.AreEqual(2, ConvertPlantGrootte.GetPlantGrootteId(Plant.Grootte.G2040));
			Assert.AreEqual(3, ConvertPlantGrootte.GetPlantGrootteId(Plant.Grootte.G4060));
		}
	}
}
