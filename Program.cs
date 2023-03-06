using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 задание 
            Random random = new Random();
            for (int i = 1; i<= 10; i++)
            {
                int x = random.Next(-40, 40);
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
