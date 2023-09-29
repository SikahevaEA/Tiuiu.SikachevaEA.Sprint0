using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint0.Task2.V0.Lib;

namespace Tiuiu.SikachevaEA.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и метода Get Massege
            //из библиотеки Tiuiu.SikachevaEA.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Лиза"));
            Console.ReadKey();
        }
    }
}
