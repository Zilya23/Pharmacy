using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Pharmacy;
using System.Collections.Generic;

namespace UnitTestDrug
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDrugName()
        {
            List<string> expectedNameDrug = Drug.GetName();

            List<string> actualNameDrug = new List<string>()
            {
                "Фенибут",
                "Смекта",
                "Рокона",
                "Зодак",
                "Лейкопластырь"
            };

            CollectionAssert.AreEqual(expectedNameDrug, actualNameDrug);
        }
    }
}
