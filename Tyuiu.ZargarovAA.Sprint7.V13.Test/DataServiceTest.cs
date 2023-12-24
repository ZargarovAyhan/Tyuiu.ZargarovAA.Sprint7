using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ZargarovAA.Sprint7.V13.Lib;


namespace Tyuiu.ZargarovAA.Sprint7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void AveragePopulation()
        {






            DataService ds = new DataService();
            int[,] mas = new int[3, 3] { { 1, 2, 3 },
                                         { 9, 10, 5 },
                                         { 8, 0, 6 }};






            double res = ds.avgPopulation(mas);

            double wait = 4.67;
            Assert.AreEqual(wait, res);
        }
    }
}