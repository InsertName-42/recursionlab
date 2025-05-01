using System;

namespace FibonacciNumbers
{
    class Program
    {
        // Recursive method to calculate the nth Fibonacci number
        static int GetFibonacciNumber(int n)
        {
            // Base cases: F_0 = 0 and F_1 = 1
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            // Recursive step: F_n = F_{n-1} + F_{n-2}
            else
            {
                return GetFibonacciNumber(n - 1) + GetFibonacciNumber(n - 2);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("The first 10 Fibonacci numbers are:");
            for (int i = 0; i < 10; i++)
            {
                int fibonacciNumber = GetFibonacciNumber(i);
                Console.WriteLine($"F_{i} = {fibonacciNumber}");
            }
        }
    }
}