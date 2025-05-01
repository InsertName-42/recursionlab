using System;

namespace TriangularNumbers
{
    class Program
    {
        // Recursive method to calculate the nth triangular number
        static int GetTriangularNumber(int n)
        {
            // Base case: The 1st triangular number is 1
            if (n == 1)
            {
                return 1;
            }
            // Non-base case: The nth triangular number is n plus the (n-1)th triangular number
            else
            {
                return n + GetTriangularNumber(n - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("The first 10 triangular numbers are:");
            for (int i = 1; i <= 10; i++)
            {
                int triangularNumber = GetTriangularNumber(i);
                Console.WriteLine($"T_{i} = {triangularNumber}");
            }
        }
    }
}
