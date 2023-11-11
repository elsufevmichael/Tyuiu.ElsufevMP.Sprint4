using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ElsufevMP.Sprint4.Task6.V16.Lib
{
    public class DataService : ISprint4Task6V16
    {
        public string[] Calculate(string[] array)
        {
            //int count = array.Count(s => s.Length == 8)
            string[] mas = Array.FindAll(array, s => s.Length == 8);
            return mas;
        }
    }
}
