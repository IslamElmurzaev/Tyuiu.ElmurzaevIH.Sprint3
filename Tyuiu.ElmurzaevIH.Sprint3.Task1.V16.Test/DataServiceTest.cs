using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElmurzaevIH.Sprint3.Task1.V16.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint3.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double wait = 15.948;
            double res = ds.GetSumSeries(0.7, 1, 15);

            Assert.AreEqual(wait, res);
        }
    }
}
