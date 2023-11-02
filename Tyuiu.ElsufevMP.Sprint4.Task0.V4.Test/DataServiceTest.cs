using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint4.Task0.V4.Lib;

namespace Tyuiu.ElsufevMP.Sprint4.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();
            int[] num = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int res = ds.GetMultEvenArrEl(num);
            int wait = 32;

            Assert.AreEqual(wait, res);
        }
    }
}
