using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ElsufevMP.Sprint4.Task0.V4.Lib;

namespace Tyuiu.ElsufevMP.Sprint4.Task0.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Елсуфьев М. П. | ИИПб-23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Елсуфьев Михаил Павлович | ИИПб-23-2                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* подсчитать произведение четных элементов массива.                       *");
            Console.WriteLine("* {5 ,3 ,7 ,1 ,3 ,9 ,8 ,7 ,9 ,4}                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            int[] nums = { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                Console.WriteLine(nums[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.GetMultEvenArrEl(nums);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
