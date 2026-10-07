using System;
using System.Globalization;

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
        int number = 10;

        if (number > 0)
            Console.WriteLine("Число положительное");
        else if (number < 0)
            Console.WriteLine("Число отрицательное");
        else
            Console.WriteLine("Число равно нулю");
    }

    static void Task2()
    {
        Console.Write("Введите возраст: ");

        if (!int.TryParse(Console.ReadLine(), out int age))
        {
            Console.WriteLine("Некорректный возраст.");
            return;
        }

        if (age >= 18)
            Console.WriteLine("Вы совершеннолетний");
        else
            Console.WriteLine("Вы несовершеннолетний");
    }

    static void Task3()
    {
        int num = 7;

        if (num % 2 == 0)
            Console.WriteLine("Число чётное");
        else
            Console.WriteLine("Число нечётное");
    }

    static void Task4()
    {
        int a = 5, b = -2;

        if (a > 0 && b > 0)
            Console.WriteLine("Оба числа положительные");

        if (a > 0 || b > 0)
            Console.WriteLine("Хотя бы одно число положительное");

        if (!(a > 0))
            Console.WriteLine("a не положительное");
    }

    static void Task5()
    {
        Console.Write("Введите оценку (1-5): ");

        if (!int.TryParse(Console.ReadLine(), out int grade))
        {
            Console.WriteLine("Некорректный ввод.");
            return;
        }

        if (grade < 3)
            Console.WriteLine("Неудовлетворительно");
        else if (grade == 3)
            Console.WriteLine("Удовлетворительно");
        else if (grade == 4)
            Console.WriteLine("Хорошо");
        else if (grade == 5)
            Console.WriteLine("Отлично");
        else
            Console.WriteLine("Некорректная оценка");
    }

    static void Task6()
    {
        int min = 10;
        int max = 100;

        Console.Write("Введите число: ");

        if (!int.TryParse(Console.ReadLine(), out int x))
        {
            Console.WriteLine("Некорректный ввод.");
            return;
        }

        if (x >= min && x <= max)
            Console.WriteLine("Число в диапазоне");
        else
            Console.WriteLine("Число вне диапазона");
    }

    static void Task7()
    {
        double a = ReadDouble("Введите первую сторону: ");
        double b = ReadDouble("Введите вторую сторону: ");
        double c = ReadDouble("Введите третью сторону: ");

        const double eps = 1e-9;

        bool ab = Math.Abs(a - b) < eps;
        bool bc = Math.Abs(b - c) < eps;
        bool ac = Math.Abs(a - c) < eps;

        if (ab && bc)
            Console.WriteLine("Равносторонний треугольник");
        else if (ab || bc || ac)
            Console.WriteLine("Равнобедренный треугольник");
        else
            Console.WriteLine("Разносторонний треугольник");
    }

    static void Task8()
    {
        decimal sum = ReadDecimal("Введите сумму покупки: ");
        decimal discount;

        if (sum >= 5000m)
            discount = 0.10m;
        else if (sum >= 2000m)
            discount = 0.05m;
        else
            discount = 0m;

        decimal total = sum * (1 - discount);
        Console.WriteLine($"Итоговая сумма к оплате: {total:F2} руб.");
    }

    static double ReadDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (input != null)
            {
                input = input.Replace(',', '.');

                if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
                    return value;
            }

            Console.WriteLine("Некорректное число, попробуйте снова.");
        }
    }

    static decimal ReadDecimal(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (input != null)
            {
                input = input.Replace(',', '.');

                if (decimal.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal value))
                    return value;
            }

            Console.WriteLine("Некорректное число, попробуйте снова.");
        }
    }
}
