using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElmurzaevIH.Sprint3.Task3.V22.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint3.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();
            int res = ds.GetMaxCharCount("tbtbbb dsfbg bbg", 'b');
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}
