using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZainagabdinovR.A.Sprint0.Task6.V0.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            //Пример циклической структуры находится в библиотекк классов в методе AdditionArray
            Console.WriteLine("Сумма элеменов массива = " + DataService.AdditionArray(numsArray));

            //Пример циклической структуры находится в библиотекк классов в методе SubtractionArray
            Console.WriteLine("Разность элеменов массива = " + DataService.SubtractionArray(numsArray));

            //Пример циклической структуры находится в библиотекк классов в методе MultiplicationArray
            Console.WriteLine("Произведение элеменов массива = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
