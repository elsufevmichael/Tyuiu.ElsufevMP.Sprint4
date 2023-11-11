using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint4.Task5.V29.Lib;

namespace Tyuiu.ElsufevMP.Sprint4.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5]
            {
                { 1, -1, -1, -1, -1 },
                { 1, -1, -1, -1, -1 },
                { 1, -1, -1, -1, -1 },
                { 1, -1, -1, -1, -1 },
                { 1, -1, -1, -1, -1 }
            };

            int res = ds.Calculate(mas2);
            int wait = 5;

            Assert.AreEqual(wait, res);
        }
    }
}
