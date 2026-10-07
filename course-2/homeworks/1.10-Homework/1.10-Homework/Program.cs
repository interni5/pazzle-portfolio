using _1._10_Homework;
using System;

namespace _1._10_Homework
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Выберите одну из трех программ, 4-выход: ");
            var choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                TemperatureConverter.Run();
                Program.Main();
            }
            else if (choice == 2)
            {
                ArithmeticMeancs.Run();
                Program.Main();
            }
            else if (choice == 3)
            {
                Calculator.Run();
                Program.Main();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Программа завершена");
                Environment.Exit(0);
            }
        }
    }
}