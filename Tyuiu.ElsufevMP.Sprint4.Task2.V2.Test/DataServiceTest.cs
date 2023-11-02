using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint4.Task2.V2.Lib;

namespace Tyuiu.ElsufevMP.Sprint4.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] n = { 1, 2, 3, 4, 5 };
            int res = ds.Calculate(n);
            int wait = 15;

            Assert.AreEqual(wait, res);
        }
    }
}
