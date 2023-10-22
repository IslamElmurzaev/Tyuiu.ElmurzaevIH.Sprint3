using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElmurzaevIH.Sprint3.Task2.V12.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint3.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double res = ds.GetMultiplySeries(5, 1, 5);

            double wait = 0.033;
            Assert.AreEqual(wait, res);
        }
    }
}
