using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint4.Task1.V8.Lib;

namespace Tyuiu.ElsufevMP.Sprint4.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] n = { 8, 4, 7, 7, 3, 8, 8, 5, 8, 7, 2, 4 };
            int res = ds.Calculate(n);
            int wait = 29;

            Assert.AreEqual(wait, res);
        }
    }
}
