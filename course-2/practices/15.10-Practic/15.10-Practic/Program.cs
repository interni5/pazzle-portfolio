using System; 

class Program
{
    static int Multiply(int a, int b, int c) => a * b * c;
    static int Multiply(int a, int b, int c, int d) => a * b * c * d;
    static double Multiply(double a, double b, double c) => a * b * c;
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
        static void SayHello()
        {
            Console.WriteLine("Hello, Word!");
        }
        SayHello();
        SayHello();
        SayHello();
    }
    static void Task2()
    {
        static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
        Greet("Sviat");
    }
    static void Task3()
    {
        static void PrintPerson(string name, int age, string city)
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}  Город: {city}");
        }
        PrintPerson("Sviat", 18, "Moscow");
    }
    static void Task4()
    {
        static void PrintPerson(string name, int age = 18, string hobby = "Не указано")
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}  Хобби: {hobby}");
        }
        PrintPerson("Егор", 15, "Футбол"); 
        PrintPerson("Анна");                
        PrintPerson("Ярослав", 20);         
    }
    static void Task5()
    {
        static int cube(int x)
        {
            return x * x * x;
        }
        cube(3);
    }
    static void Task6()
    {
        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                return 0;
            }
            return a / b;
        }

        Console.Write("Введите первое число: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите операцию (+, -, *, /): ");
        string op = Console.ReadLine();

        double result = 0;
        switch (op)
        {
            case "+": result = Add(a, b); break;
            case "-": result = Subtract(a, b); break;
            case "*": result = Multiply(a, b); break;
            case "/": result = Divide(a, b); break;
            default: Console.WriteLine("Неизвестная операция"); return;
        }

        Console.WriteLine($"Результат: {result}");

    }
    static void Task7()
    {
        int counter = 0;

        void Increment()
        {
            counter++;
        }

        Increment();
        Console.WriteLine($"counter = {counter}");
        Increment();
        Console.WriteLine($"counter = {counter}");
        Increment();
        Console.WriteLine($"counter = {counter}");
    }
    static void Task8()
    {
        Console.WriteLine(Multiply(2, 3, 5));
        Console.WriteLine(Multiply(2, 3, 4, 12));
        Console.WriteLine(Multiply(2.5, 4.0, 7.7).ToString("F1"));
    }
    static void Task9()
    {
        double Average(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return (double)sum / numbers.Length;
        }

        int[] arr = { 2, 4, 6, 8 };
        Console.WriteLine($"Среднее: {Average(arr)}");
    }
    static void Task10()
    {
        double Add(double a, double b) => a + b;
        double Subtract(double a, double b) => a - b;
        double Multiply(double a, double b) => a * b;

        double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на 0!");
                return double.NaN;
            }
            return a / b;
        }

        while (true)
        {
            Console.Write("Введите выражение (или exit): ");
            string input = Console.ReadLine();

            if (input == null) continue;

            if (input.Trim().ToLower() == "exit")
            {
                Console.WriteLine("Программа завершена");
                break;
            }

            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 3)
            {
                Console.WriteLine("Неверный формат. Пример: 5 + 3");
                continue;
            }

            double a = double.Parse(parts[0]);
            string op = parts[1];
            double b = double.Parse(parts[2]);

            double result;
            switch (op)
            {
                case "+": result = Add(a, b); break;
                case "-": result = Subtract(a, b); break;
                case "*": result = Multiply(a, b); break;
                case "/": result = Divide(a, b); break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    continue;
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}