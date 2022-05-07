using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Pharmacy;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestDrug
{
    [TestClass]
    public class UnitTest1
    {
        static List<Drug> listDr;
        [ClassInitialize]
        public static void GetDr(TestContext testContext)
        {
            listDr = new List<Drug>()
            {
                new Drug { ID = 5, Name = "Лейкопластырь", IdManufacturer = 3, Price = 56},
                new Drug { ID = 4, Name = "Зодак", IdManufacturer = 2, Price = 155},
                new Drug { ID = 1, Name = "Фенибут", IdManufacturer = 1, Price = 490 },
                new Drug { ID = 2, Name = "Смекта", IdManufacturer = 2, Price = 765 },
                new Drug { ID = 3, Name = "Рокона", IdManufacturer = 3, Price = 1056 }
            };
        }


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

        [TestMethod]
        public void TestNameManufacture()
        {
            List<string> expectedNameManufacturer = Drug.GetNameManufacture();

            List<string> actualNameManufacturer = new List<string>()
            {
                "ОЗОН",
                "Хенкел",
                "Екхольм"
            };

            CollectionAssert.AreEqual(expectedNameManufacturer, actualNameManufacturer);
        }

        [TestMethod]
        public void TestSortByOrder()
        {
            List<Drug> expectedSortOrderByDrug = Drug.SortByOrder();
            List<Drug> actualSortOrderByDrug = Drug.GetDrug().OrderBy(x => x.Price).ToList();
            //{
            //    new Drug { ID = 5, Name = "Лейкопластырь", IdManufacturer = 3, Price = 56},
            //    new Drug { ID = 4, Name = "Зодак", IdManufacturer = 2, Price = 155},
            //    new Drug { ID = 1, Name = "Фенибут", IdManufacturer = 1, Price = 490},
            //    new Drug { ID = 2, Name = "Смекта", IdManufacturer = 2, Price = 765},
            //    new Drug { ID = 3, Name = "Рокона", IdManufacturer = 3, Price = 1056}
            //};

            CollectionAssert.AreEqual(expectedSortOrderByDrug, actualSortOrderByDrug);
        }

        [TestMethod]
        public void TestDescOrder()
        {
            //List<Drug> expectedSortOrderByDrug = Drug.SortDescOrder();
            List<Drug> actualSortOrderByDrug = new List<Drug>()
            {
                new Drug { ID = 3, Name = "Рокона", IdManufacturer = 3, Price = 1056},
                new Drug { ID = 2, Name = "Смекта", IdManufacturer = 2, Price = 765},
                new Drug { ID = 1, Name = "Фенибут", IdManufacturer = 1, Price = 490},
                new Drug { ID = 4, Name = "Зодак", IdManufacturer = 2, Price = 155},
                new Drug { ID = 5, Name = "Лейкопластырь", IdManufacturer = 3, Price = 56}
            };

            //List<int> exprctedID = new List<int>();
            //foreach (var i in expectedSortOrderByDrug)
            //{
            //    exprctedID[i.ID - 1] = i.ID;
            //}

            //List<int> actualID = new List<int>();
            //foreach (var i in actualSortOrderByDrug)
            //{
            //    actualID[i.ID - 1] = i.ID;
            //}

            CollectionAssert.AreEquivalent(listDr, actualSortOrderByDrug);
        }

        [TestMethod]
        public void TestExpensiveDrug()
        {
            string expectedNameDrug = Drug.ExpensiveDrug();
            string actualNameDrug = "Рокона";

            Assert.AreEqual(expectedNameDrug, actualNameDrug);
        }

        [TestMethod]
        public void TestGetDrugInPharm()
        {
            List<Drug> actualDrugInPharm = new List<Drug>()
            {
                new Drug { ID = 1, Name = "Фенибут", IdManufacturer = 1, Price = 490},
                new Drug { ID = 2, Name = "Смекта", IdManufacturer = 2, Price = 765}
            };
            Assert.AreEqual(DrugInPharm.GetDrugInPharms(1).Count(), actualDrugInPharm.Count());
        }
    }

}
