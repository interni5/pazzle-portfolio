using System;
using System.Collections.Generic;
using System.Text;

namespace _1._10_Homework
{
    internal class ArithmeticMeancs
    {
        public static void Run()
        {
            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            double num3 = double.Parse(Console.ReadLine());

            double avg = (num1 + num2 + num3) / 3.0;
            Console.WriteLine($"Среднее арифметическое чисел {num1}, {num2} и {num3} = {avg}");

        }
    }
}
