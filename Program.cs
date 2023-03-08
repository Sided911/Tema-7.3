using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 задание 
            //Random random = new Random();
            //for (int i = 1; i<= 10; i++)
            //{
            //    int x = random.Next(-40, 40);
            //    Console.WriteLine(x);
            //}
            //Console.ReadKey();

            //2 задание
            //int count = 0;
            //Random random = new Random();
            //for (int i = 1; i <= 15; i++)
            //{
            //    double x = -20 + 50 * random.NextDouble();
            //    Console.WriteLine(x);
            //    if (x > 0) 
            //    { count++; }
            //}
            //Console.WriteLine($"Кол-во полных чисел={count}");

            //3 задание
            //Random random = new Random();
            //for (int i = 0; i < 12; i++)
            //{
            //    double number = random.NextDouble() * (5 - (-5)) +
            //        (-5);
            //    Console.Write(number + " ");
            //    if (number < 0)
            //    {
            //        Console.WriteLine("- отрицательное число");
            //    }
            //    else if (number > 0)
            //    {
            //        Console.WriteLine("-положительное число");
            //    }
            //    else
            //    {
            //        Console.WriteLine("-ноль");
            //    }
            //}
            //Console.ReadKey();

            //4 задание 
            Random rnd = new Random();
            int num;

            for (int i = 0; i < 8; i++)
            {
                num = rnd.Next(-30, 30); // генерация случайного числа в интервале (-30, 30)
                Console.Write(num + " ");

                if (num < 0)
                {
                    Console.Write("отрицательное ");
                }
                else
                {
                    Console.Write("положительное ");
                }

                if (num % 2 == 0)
                {
                    Console.WriteLine("четное");
                }
                else
                {
                    Console.WriteLine("нечетное");
                }
            }
        }
    }
}
