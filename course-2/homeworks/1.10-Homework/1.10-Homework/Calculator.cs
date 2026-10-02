using System;
using System.Collections.Generic;
using System.Text;

namespace _1._10_Homework
{
    internal class Calculator
    {
        public static void Run()
        {
            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число : ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Выберете операцию(+, -, *, /): ");
            string oper = Console.ReadLine();

            if (oper == "+")
            {
                double sum = num1 + num2;
                Console.WriteLine("Сумма: " + sum);
            }
            else if (oper == "-")
            {
                double sum = num1 - num2;
                Console.WriteLine("Разность: " + sum);
            }
            else if (oper == "*")
            {
                double sum = num1 * num2;
                Console.WriteLine("Произведение: " + sum);
            }
            else if (oper == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Деление на 0 невозможно");
                }
                else
                {
                    double sum = num1 / num2;
                    Console.WriteLine("Деление: " + sum);
                }
            }

        }
    }
}
