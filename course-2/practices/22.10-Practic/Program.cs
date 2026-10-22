using System;

namespace ConsoleApp
{
    class Program
    {
        static string[] playerNames = new string[10];
        static int[] playerScores = new int[10];
        static int playerCount = 0;
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Конвертер валют");
                Console.WriteLine("2. Определение времени суток");
                Console.WriteLine("3. Подсчёт цифр в числе");
                Console.WriteLine("4. Поиск минимального и максимального");
                Console.WriteLine("5. Подсчёт гласных и согласных");
                Console.WriteLine("6. Мини-опрос");
                Console.WriteLine("7. Проверка пароля на сложность");
                Console.WriteLine("8. Числовая пирамида");
                Console.WriteLine("9. Сумма цифр числа (рекурсия)");
                Console.WriteLine("10. Статистика температуры");
                Console.WriteLine("11. Игра: Угадай число");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите пункт: ");

                string choice = Console.ReadLine();

                Console.Clear();
                switch (choice)
                {
                    case "1": Task1(); break;
                    case "2": Task2(); break;
                    case "3": Task3(); break;
                    case "4": Task4(); break;
                    case "5": Task5(); break;
                    case "6": Task6(); break;
                    case "7": Task7(); break;
                    case "8": Task8(); break;
                    case "9": Task9(); break;
                    case "10": Task10(); break;
                    case "11": GameMenu(); break;
                    case "0": return;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }

                if (choice != "0")
                {
                    Console.WriteLine("\nНажмите Enter, чтобы вернуться в главное меню...");
                    Console.ReadLine();
                }
            }
        }

        static void Task1()
        {
            const double USD = 90.0, EUR = 100.0, CNY = 12.5;

            Console.Write("Введите сумму в рублях: ");
            double rub = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1 — Доллары\n2 — Евро\n3 — Юани");
            Console.Write("Ваш выбор: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.WriteLine($"{rub} руб. = {rub / USD:F2} $"); break;
                case 2: Console.WriteLine($"{rub} руб. = {rub / EUR:F2} €"); break;
                case 3: Console.WriteLine($"{rub} руб. = {rub / CNY:F2} ¥"); break;
                default: Console.WriteLine("Неверный выбор"); break;
            }
        }

        static void Task2()
        {
            Console.Write("Введите текущее время (час, от 0 до 23): ");
            int hour = Convert.ToInt32(Console.ReadLine());

            if (hour >= 0 && hour <= 5) Console.WriteLine("Ночь");
            else if (hour >= 6 && hour <= 11) Console.WriteLine("Утро");
            else if (hour >= 12 && hour <= 17) Console.WriteLine("День");
            else if (hour >= 18 && hour <= 23) Console.WriteLine("Вечер");
            else Console.WriteLine("Некорректный ввод");
        }

        static void Task3()
        {
            Console.Write("Введите число: ");
            int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int count = n == 0 ? 1 : 0;

            while (n > 0)
            {
                count++;
                n /= 10;
            }
            Console.WriteLine($"Количество цифр: {count}");
        }

        static void Task4()
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Введите {i + 1}-е число: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = arr[0], max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }

            Console.WriteLine($"Минимум: {min}");
            Console.WriteLine($"Максимум: {max}");
        }

        static void Task5()
        {
            Console.Write("Введите слово: ");
            string word = Console.ReadLine().ToLower();
            string vowels = "аеёиоуыэюя";
            int vCount = 0, cCount = 0;

            foreach (char c in word)
            {
                if (char.IsLetter(c))
                {
                    if (vowels.Contains(c)) vCount++;
                    else cCount++;
                }
            }
            Console.WriteLine($"Гласных: {vCount}");
            Console.WriteLine($"Согласных: {cCount}");
        }

        static void Task6()
        {
            string[] q = {
                "Любите ли вы программировать? (1 — Да, 0 — Нет)",
                "Работаете ли вы в команде? (1 — Да, 0 — Нет)",
                "Хотите ли стать разработчиком? (1 — Да, 0 — Нет)"
            };
            int yesCount = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(q[i]);
                if (Convert.ToInt32(Console.ReadLine()) == 1) yesCount++;
            }
            Console.WriteLine($"Вы ответили 'Да' на {yesCount} из 3 вопросов.");
        }

        static void Task7()
        {
            Console.Write("Введите пароль: ");
            CheckPassword(Console.ReadLine());
        }

        static void CheckPassword(string pass)
        {
            bool len = pass.Length >= 8;
            bool digit = false, upper = false;

            foreach (char c in pass)
            {
                if (char.IsDigit(c)) digit = true;
                if (char.IsUpper(c)) upper = true;
            }

            if (len && digit && upper)
            {
                Console.WriteLine("Пароль надёжный");
            }
            else
            {
                Console.Write("Пароль ненадёжный: ");
                if (!len) Console.Write("слишком короткий; ");
                if (!digit) Console.Write("не содержит цифр; ");
                if (!upper) Console.Write("нет заглавных букв; ");
                Console.WriteLine();
            }
        }

        static void Task8()
        {
            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void Task9()
        {
            Console.Write("Введите число: ");
            int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Сумма цифр: {SumDigits(n)}");
        }

        static int SumDigits(int n)
        {
            if (n == 0) return 0;
            return (n % 10) + SumDigits(n / 10);
        }

        static void Task10()
        {
            Console.Write("Введите количество дней: ");
            int days = Convert.ToInt32(Console.ReadLine());

            double[] temps = new double[days];
            for (int i = 0; i < days; i++)
            {
                Console.Write($"Температура в {i + 1}-й день: ");
                temps[i] = Convert.ToDouble(Console.ReadLine());
            }

            double avg = AverageTemp(temps);
            Console.WriteLine($"\nСредняя температура: {avg:F1}");
            Console.WriteLine($"Максимальная: {MaxTemp(temps):F1}");
            Console.WriteLine($"Дней выше среднего: {CountAboveAverage(temps)}");
        }

        static double AverageTemp(double[] temps)
        {
            double sum = 0;
            foreach (double t in temps) sum += t;
            return sum / temps.Length;
        }

        static double MaxTemp(double[] temps)
        {
            double max = temps[0];
            for (int i = 1; i < temps.Length; i++)
            {
                if (temps[i] > max) max = temps[i];
            }
            return max;
        }

        static int CountAboveAverage(double[] temps)
        {
            double avg = AverageTemp(temps);
            int count = 0;
            foreach (double t in temps)
            {
                if (t > avg) count++;
            }
            return count;
        }

        static void GameMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== ИГРА: УГАДАЙ ЧИСЛО ===");
                Console.WriteLine("1) Начать игру");
                Console.WriteLine("2) Показать таблицу лидеров");
                Console.WriteLine("0) Назад");
                Console.Write("Выберите пункт: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PlayGame();
                        break;
                    case "2":
                        ShowLeaderboard();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный пункт.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void PlayGame()
        {
            Console.Clear();
            Console.Write("Введите имя игрока: ");
            string name = Console.ReadLine();

            int secret = rnd.Next(1, 51);
            int attempts = 0;

            Console.WriteLine("Я загадал число от 1 до 50. Попробуйте угадать!");

            while (true)
            {
                Console.Write("Введите число: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int guess) || guess < 1 || guess > 50)
                {
                    Console.WriteLine("Введите корректное число от 1 до 50.");
                    continue;
                }

                attempts++;

                if (guess < secret)
                {
                    Console.WriteLine("Больше!");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("Меньше!");
                }
                else
                {
                    Console.WriteLine($"Поздравляем, вы угадали число за {attempts} попыток!");
                    break;
                }
            }

            SaveResult(name, attempts);

            Console.WriteLine("\nНажмите Enter, чтобы вернуться в меню игры...");
            Console.ReadLine();
        }

        static void SaveResult(string name, int attempts)
        {
            if (playerCount < 10)
            {
                playerNames[playerCount] = name;
                playerScores[playerCount] = attempts;
                playerCount++;
            }
            else
            {
                int worstIndex = 0;
                int maxAttempts = playerScores[0];

                for (int i = 1; i < 10; i++)
                {
                    if (playerScores[i] > maxAttempts)
                    {
                        maxAttempts = playerScores[i];
                        worstIndex = i;
                    }
                }

                if (attempts < maxAttempts)
                {
                    playerNames[worstIndex] = name;
                    playerScores[worstIndex] = attempts;
                    Console.WriteLine("Ваш результат попал в таблицу лидеров!");
                }
            }
        }

        static void ShowLeaderboard()
        {
            Console.Clear();

            if (playerCount == 0)
            {
                Console.WriteLine("Пока нет рекордов.");
            }
            else
            {
                for (int i = 0; i < playerCount - 1; i++)
                {
                    for (int j = 0; j < playerCount - 1 - i; j++)
                    {
                        if (playerScores[j] > playerScores[j + 1])
                        {
                            int tempScore = playerScores[j];
                            playerScores[j] = playerScores[j + 1];
                            playerScores[j + 1] = tempScore;

                            string tempName = playerNames[j];
                            playerNames[j] = playerNames[j + 1];
                            playerNames[j + 1] = tempName;
                        }
                    }
                }

                int topCount = playerCount > 5 ? 5 : playerCount;

                for (int i = 0; i < topCount; i++)
                {
                    Console.WriteLine($"{i + 1}. {playerNames[i]} — {playerScores[i]} попыток");
                }
            }

            Console.WriteLine("\nНажмите Enter, чтобы вернуться в меню игры...");
            Console.ReadLine();
        }
    }
}