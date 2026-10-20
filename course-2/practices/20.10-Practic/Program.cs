using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("задание 1: ");
        Console.WriteLine($"Factorial(3) = {Factorial(3)}");
        Console.WriteLine($"Factorial(5) = {Factorial(5)}");
        Console.WriteLine($"Factorial(7) = {Factorial(7)}");

        Console.WriteLine("\nзадание 2: ");
        StringBuilder fibResult = new StringBuilder();
        for (int i = 0; i < 10; i++)
        {
            fibResult.Append(Fibonacci(i));
            if (i < 9) fibResult.Append(" ");
        }
        Console.WriteLine(fibResult.ToString());

        Console.WriteLine("\nзадание 3: ");
        Console.WriteLine($"Sum(5) = {Sum(5)}");

        Console.WriteLine("\nзадание 4: ");
        Console.WriteLine(GetDayName(3));

        Console.WriteLine("\nзадание 5: ");
        Console.WriteLine(Calculator(10, 5, '+'));

        Console.WriteLine("\nзадание 6:  ");
        CountDown(5);

        Console.WriteLine("\nзадание 7: ");
        Console.WriteLine(CountVowels("Hello World"));
    }

    static int Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }

    static int Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static int Sum(int n)
    {
        if (n == 0) return 0;
        return n + Sum(n - 1);
    }

    static string GetDayName(int day)
    {
        switch (day)
        {
            case 1: return "понедельник";
            case 2: return "вторник";
            case 3: return "среда";
            case 4: return "четверг";
            case 5: return "пятница";
            case 6: return "суббота";
            case 7: return "воскресенье";
            default: return "неверный день";
        }
    }

    static string Calculator(int a, int b, char op)
    {
        switch (op)
        {
            case '+': return $"результат: {a + b}";
            case '-': return $"результат: {a - b}";
            case '*': return $"результат: {a * b}";
            case '/':
                if (b == 0) return "ошибка: деление на ноль";
                return $"результат: {(double)a / b}";
            default: return "ошибка: неизвестная операция";
        }
    }

    static void CountDown(int n)
    {
        if (n < 0) return;
        Console.WriteLine(n);
        CountDown(n - 1);
    }

    static int CountVowels(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return 0;
        }

        char firstсhar = char.ToLower(text[0]);
        int isvowel = "aeiouy".Contains(firstсhar) ? 1 : 0;

        return isvowel + CountVowels(text.Substring(1));
    }
}