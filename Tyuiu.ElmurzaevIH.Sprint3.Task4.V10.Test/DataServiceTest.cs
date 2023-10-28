using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElmurzaevIH.Sprint3.Task4.V10.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint3.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            double wait = 0.014;
            Assert.AreEqual(wait, res);
        }
    }
}
