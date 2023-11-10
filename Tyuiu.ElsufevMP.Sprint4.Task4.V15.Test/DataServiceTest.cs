using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint4.Task4.V15.Lib;

namespace Tyuiu.ElsufevMP.Sprint4.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] {
            { 4, 2, 5, 5, 3 },
            { 4, 2, 5, 2, 2 },
            { 3, 2, 4, 2, 4 },
            { 3, 6, 4, 5, 4 },
            { 2, 4, 6, 4, 2 } };

            int res = ds.Calculate(mas2);
            int wait = 29;

            Assert.AreEqual(wait, res);
        }
    }
}
