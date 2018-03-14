using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exam3UnitTest;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void CreateBabyWithFutureEndDateThrowsAgrumentOutOfRange()
		{
			DateTime futureDate = new DateTime(2018, 9, 19);
			DateTime startDate = new DateTime(2019, 9, 19);
			Baby b = new Baby(5, "joe", "bloggs", startDate, futureDate, "main street", "001243235", "ann bloggs");
			

		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void CreateBabyWithEndDateBeforeStartThrowsAgrumentOutOfRange()
		{
			DateTime endDate = new DateTime(2016, 9, 19);
			DateTime startDate = new DateTime(2016, 10, 19);
			Baby b = new Baby(5, "joe", "bloggs", startDate, endDate, "main street", "001243235", "ann bloggs");


		}

		[TestMethod]
		public void AddBabyUpdatesList()
		{
			DateTime endDate = new DateTime(2017, 9, 19);
			DateTime startDate = new DateTime(2016, 10, 19);
			Baby b = new Baby(5, "joe", "bloggs", startDate, endDate, "main street", "001243235", "ann bloggs");
			BabyList babyList = new BabyList();
			babyList.AddBaby(b);
			CollectionAssert.Contains(babyList.Babies, b);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void AddNullBabyToBabyListShouldThrowArgumentNullException()
		{
			Baby b = null;

			BabyList babies = new BabyList();

			babies.AddBaby(b);
		}




	}
}
