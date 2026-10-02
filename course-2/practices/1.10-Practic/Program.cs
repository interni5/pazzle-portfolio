using System;

class Program
{
    static void Main()
    {
  
        int a = 12, b = 5;
        Console.WriteLine($"Сумма: {a + b}, Разность: {a - b}, Произведение: {a * b}, Частное: {a / b}, Остаток: {a % b}");

        Console.Write("Введите имя: ");
        Console.WriteLine($"Привет, {Console.ReadLine()}!");

        Console.Write("Введите два числа: ");
        int x = int.Parse(Console.ReadLine()), y = int.Parse(Console.ReadLine());
        Console.WriteLine($"Сумма: {x + y}");

        Console.Write("Введите ширину и длину: ");
        double w = double.Parse(Console.ReadLine()), h = double.Parse(Console.ReadLine());
        Console.WriteLine($"Площадь: {w * h}");
    }
}
