using System;
using System.Linq;

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
        Task9();
        Task10();
    }

    static void Task1()
    {
        for (int i = 1; i <= 30; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void Task2()
    {
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }

    static void Task3()
    {
        Random rnd = new Random();
        int secret = rnd.Next(1, 11);
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int guess) && guess == secret)
            {
                Console.WriteLine("Угадал");
                break;
            }
        }
    }

    static void Task4()
    {
        while (true)
        {
            string password = Console.ReadLine();
            if (password == "1234")
            {
                break;
            }
        }
    }

    static void Task5()
    {
        string[] fruits = { "яблоко", "банан", "апельсин", "груша", "киви" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }

    static void Task6()
    {
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    static void Task7()
    {
        bool accessGranted = false;
        for (int attempt = 0; attempt < 3; attempt++)
        {
            string pwd = Console.ReadLine();
            if (pwd == "1234")
            {
                Console.WriteLine("Доступ разрешен");
                accessGranted = true;
                break;
            }
        }
        if (!accessGranted)
        {
            Console.WriteLine("Доступ запрещен");
        }
    }

    static void Task8()
    {
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                Console.Write((i * j) + " ");
            }
            Console.WriteLine();
        }
    }

    static void Task9()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        bool hasDuplicates = false;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    hasDuplicates = true;
                    break;
                }
            }
            if (hasDuplicates) break;
        }
        if (hasDuplicates)
        {
            Console.WriteLine("Есть дубликаты");
        }
        else
        {
            Console.WriteLine("Все элементы уникальны");
        }
    }

    static void Task10()
    {
        string[] players = { "Игрок1", "Игрок2", "Игрок3" };
        int[] scores = { 150, 200, 175 };
        int maxScore = scores.Max();
        int maxIndex = Array.IndexOf(scores, maxScore);
        Console.WriteLine($"Лидер: {players[maxIndex]}, Счет: {maxScore}");
    }
}
