using System;

namespace Practice
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

        public Book() : this("Без названия", "Неизвестен", 0) { }
        public Book(string title) : this(title, "Неизвестен", 0) { }
        public Book(string title, string author) : this(title, author, 0) { }

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public void PrintInfo()
            => Console.WriteLine($"Книга: {Title}, автор: {Author}, страниц: {Pages}");
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        public Car() : this("Неизвестно", "Неизвестно") { }
        public Car(string brand) : this(brand, "Неизвестно") { }

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
            Speed = 0;
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public Player(string name, int level)
        {
            Name = name;
            Level = level;
        }

        public void PrintInfo() => Console.WriteLine($"{Name}, уровень {Level}");

        public override bool Equals(object? obj)
            => obj is Player other && Name == other.Name && Level == other.Level;

        public override int GetHashCode() => HashCode.Combine(Name, Level);
    }

    public class User
    {
        private string _password = "";

        public string Login { get; set; } = "";

        public string Password
        {
            get => _password;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Ошибка: пароль не может быть пустым");
                    return;
                }
                _password = value;
                Console.WriteLine("Пароль обновлен");
            }
        }

        public bool CheckPassword(string input) => _password == input;
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) { X = x; Y = y; }

        public void Move(int dx, int dy) { X += dx; Y += dy; }
        public void Print() => Console.WriteLine($"({X}, {Y})");
    }

    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        public Movie() : this("Без названия", "Неизвестен", 0) { }
        public Movie(string title) : this(title, "Неизвестен", 0) { }
        public Movie(string title, string genre, double rating)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
        }

        public void PrintInfo()
            => Console.WriteLine($"Название: {Title}, жанр: {Genre}, рейтинг: {Rating}");
    }

    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void PrintInfo() => Console.WriteLine($"{Name}, возраст {Age}");
    }

    public class Program
    {
        public static void Main()
        {
            var b1 = new Book();
            var b2 = new Book("1984");
            var b3 = new Book("Гарри Поттер", "Дж. Роулинг", 500);
            b1.PrintInfo();
            b2.PrintInfo();
            b3.PrintInfo();

            var p1 = new Player("Alex", 5);
            var p2 = new Player("Alex", 5);
            var p3 = p1;
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1 == p3);
            Console.WriteLine(p1.Equals(p2));

            var user = new User { Login = "admin" };
            user.Password = "12345";
            Console.WriteLine(user.CheckPassword("12345"));
            user.Password = "";

            var pt1 = new Point(2, 3);
            var pt2 = pt1;
            pt2.Move(5, 5);
            pt1.Print();

            var m1 = new Movie();
            var m2 = new Movie("Матрица");
            var m3 = new Movie("Начало", "Фантастика", 9);
            m1.PrintInfo();
            m2.PrintInfo();
            m3.PrintInfo();

            var cat1 = new Cat("Барсик", 2);
            var cat2 = cat1;
            cat2.Age = 5;
            cat1.PrintInfo();
            cat2.PrintInfo();
            var cat3 = new Cat(cat1.Name, cat1.Age);
            cat3.Age = 10;
            cat1.PrintInfo();
            cat2.PrintInfo();
            cat3.PrintInfo();
        }
    }
}