using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;

namespace _1._10_Homework
{
    
    internal class TemperatureСonverter
    {
        public static void Run()
        {

            Console.Write("Введите темп в Цельсиях: ");
            double temp = double.Parse(Console.ReadLine());
            double F = (temp * 9) / 5 + 32;
            Console.WriteLine(F);

        }

    }
}
