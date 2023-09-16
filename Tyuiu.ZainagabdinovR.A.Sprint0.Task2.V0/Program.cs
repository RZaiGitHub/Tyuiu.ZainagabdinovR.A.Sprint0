using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZainagabdinovR.A.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //ВЫзов класса DataService и метода GetMessage
            //из библиотеки Tyuiu.ZainagabdinovR.A.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Руслан"));
            Console.ReadKey();
        }
    }
}
