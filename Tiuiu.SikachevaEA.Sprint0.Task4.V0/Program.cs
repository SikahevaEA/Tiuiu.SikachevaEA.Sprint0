﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.SikachevaEA.Sprint0.Task4.V0.Lib;

namespace Tiuiu.SikachevaEA.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример линейной структуры программы
            //Вызов метода Addition
            Console.WriteLine(DataService.Addition(1, 5));
            //Вызов метода Subtraction
            Console.WriteLine(DataService.Subtraction(15, 5));
            //Вызов метода Multiplication
            Console.WriteLine(DataService.Multiplication(10, 10));
            //Вызов метода Division
            Console.WriteLine(DataService.Division(5, 5));

            Console.ReadKey();
        }
    }
}
