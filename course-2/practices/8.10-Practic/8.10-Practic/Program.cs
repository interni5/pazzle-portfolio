using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
        Task7();
        Task8();
    }
    static void Task1()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("|Элемент: " + i + ":" + arr[i] + "| ");
        }
    }
    static void Task2()
    {
        int[] grades = { 2, 4, 5, 1, 4, 5 };
        int sum = 0;
        foreach (int grade in grades)
        {
            sum += grade;
        }
        Console.WriteLine("Среднее значение: " + (double)sum / grades.Length);
    }
    static void Task3()
    {
        Random rnd = new Random();
        int[] arg = new int[8];

        for (int i = 0; i < arg.Length; i++)
        {
            arg[i] = rnd.Next(1, 101);
        }

        int max = arg[0];

        for (int i = 0; i < arg.Length; i++)
        {
            if (arg[i] > max)
            {
                max = arg[i];
            }
        }
        Console.WriteLine("Максимальное число: " + max);
    }
    static void Task4()
    {
        int[] arg = {1, 10, 2, 3, 43, 20, 32, 24, 43, 90};
        int creet = 0;
        int nocreet = 0;

        foreach(int args in arg)
        {
            if (args % 2 == 0)
            {
                creet++;
            }
            else 
            {
                nocreet++;
            }
        }
        Console.WriteLine("Четные: " +  creet + " |" + "Нечетные: " + nocreet);
    }
    static void Task5()
    {
        string[] fruits = { "Яблоко", "Банан", "Апельсин", "Груша", "Виноград" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
    static void Task6()
    {
        int[,] matrix = new int[3, 3];
        int value = 1;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = value;
                value++;
            }
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    } 
    static void Task7()
    {
        int[] grades = { 5, 4, 3, 5, 2, 4, 5 };
        int sum = 0;
        int countFives = 0;
        int countTwos = 0;

        foreach (int grade in grades)
        {
            sum += grade;

            if (grade == 5) countFives++;
            if (grade == 2) countTwos++;
        }

        double average = (double)sum / grades.Length;

        Console.WriteLine("Оценки: " + string.Join(", ", grades));
        Console.WriteLine($"Средний балл: {average:F2}");
        Console.WriteLine($"Количество «пятёрок»: {countFives}");
        Console.WriteLine($"Количество «двоек»: {countTwos}");
    }
    static void Task8()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Прямой порядок:");

        foreach (int n in numbers)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Обратный порядок:");

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}
