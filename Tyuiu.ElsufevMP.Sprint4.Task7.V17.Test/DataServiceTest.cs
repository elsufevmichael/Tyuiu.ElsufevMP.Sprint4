using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint4.Task7.V17.Lib;

namespace Tyuiu.ElsufevMP.Sprint4.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 3;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "753159864";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
