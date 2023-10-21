using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElmurzaevIH.Sprint3.Task0.V16.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint3.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 6;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 10220.275;
            Assert.AreEqual(wait, res);
        }
    }
}
