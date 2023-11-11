using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElsufevMP.Sprint4.Task6.V16.Lib;

namespace Tyuiu.ElsufevMP.Sprint4.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var f = new string[] { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };
            string[] res = ds.Calculate(f);
            string[] wait = {};
            Assert.AreEqual(wait, res);
        }
    }
}
