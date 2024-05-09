using System;
using System.Text;

namespace lab_rostik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Lab 1 !");
            int task = 0;
            while (task != 7)
            {
                Console.WriteLine(" 1) - 1 Завдання\n 2) - 2 Завдання\n 3) - 3 Завдання\n 4) - 4 Завдання\n 5) - 5 Завдання\n 6) - 6 Завдання\n 7) - Завершити роботу\n\nВиберіть від 1 до 7: ");
                task = int.Parse(Console.ReadLine());
                switch (task)
                {
                    case 1:
                        task1();
                        break;
                    case 2:
                        task2();
                        break;
                    case 3:
                        task3();
                        break;
                    case 4:
                        task4();
                        break;
                    case 5:
                        task5();
                        break;
                    case 6:
                        task6();
                        break;
                    default:
                        Console.WriteLine("Немає такого варіанту");
                        break;
                }
                Console.WriteLine("\n\n");
            }

            Console.ReadLine();
        }

        static void task1()
        {
            Console.WriteLine("Введіть периметр квадрата:");
            double perimeter = Convert.ToDouble(Console.ReadLine());

            double sideLength = perimeter / 4;

            double area = sideLength * sideLength;

            Console.WriteLine($"Сторона квадрата: {sideLength}");
            Console.WriteLine($"Площа квадрата: {area}");
        }

        static void task2()
        {
            Console.WriteLine("Введіть перше число:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double maxNumber = Math.Max(number1, number2);

            Console.WriteLine($"Максимальне число: {maxNumber}");
        }

        static void task3()
        {
            Console.WriteLine("Введіть координати точки (x, y):");
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y = ");
            double y = double.Parse(Console.ReadLine());

            if ((x >= -1 && x <= 1 && y >= -1 && y <= 1) || (x >= -2 && x <= 2 && y >= -2 && y <= 2))
            {
                Console.WriteLine("Так");
            }
            else if ((x == -1 || x == 1 || y == -1 || y == 1) && !(x == -2 || x == 2 || y == -2 || y == 2))
            {
                Console.WriteLine("На межі");
            }
            else
            {
                Console.WriteLine("Ні");
            }
        }

        static void task4()
        {
            Console.WriteLine("Введіть номер місяця:");
            int n = int.Parse(Console.ReadLine());
            int res = 0;
            if (n >= 1 && n <= 12)
            {
                res = 12 - n;
                Console.WriteLine($"До кінця року залишилося {res} місяців");
            }
            else
            {
                Console.WriteLine("Неправильно введений номер місяця");
            }
        }

        static void task5()
        {
            Console.WriteLine("Введіть перше число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть друге число: ");
            int b = int.Parse(Console.ReadLine());
            int numberSum = a + b;
            Console.WriteLine($"Сума чисел {a} та {b} дорівнює {numberSum}");
        }

        static void task6()
        {
            Console.WriteLine("Введіть a: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введіть b: ");
            float b = float.Parse(Console.ReadLine());
            float res = a + (a + b - 1) / (a * a + 1) - a * b;
            Console.WriteLine($"Результат даного виразу буде: {res}");
        }
    }
}
