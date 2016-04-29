using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Boomkwekerij.Models;
using System.Collections.Generic;

namespace Boomkwekerij_UnitTests
{
	[TestClass]
	public class TestToeslagPercentage
	{

		[TestInitialize()]
		public void Setup()
		{
			List<ToeslagPercentage> toeslagPercentage = new List<ToeslagPercentage>();
			toeslagPercentage.Add(new ToeslagPercentage(0, 1275, DateTime.Now.AddDays(-30), DateTime.Now.AddDays(-1)));
			toeslagPercentage.Add(new ToeslagPercentage(1, 571, DateTime.Now.AddDays(-1)));
		}

		[TestMethod]
		public void TestGetValidPercentageForDate()
		{
			Assert.AreEqual(12.75M, ToeslagPercentage.GetValidPercentageForDate(DateTime.Now.AddDays(-14)));
			Assert.AreEqual(5.71M, ToeslagPercentage.GetValidPercentageForDate(DateTime.Now));
		}

		[TestCleanup]
		public void Cleanup()
		{
			ToeslagPercentage.Percentages = null;
		}
	}
}
