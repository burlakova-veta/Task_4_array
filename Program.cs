using System;
namespace csharptest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число");
            int fib0 = 1;
            int fib1 = 1;
            Console.Write(fib0 + " " + fib1 + " ");
            for (int i = 3; i <= n; i++)
            {
                int c = fib1;
                fib1 = fib1 + fib0;
                fib0 = c;
                Console.Write(fib1 + " ");
            }
        }
    }
}