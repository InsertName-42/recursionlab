using System;

namespace TriangularNumbers
{
    class Program
    {
        //Method to calculate the nth triangular number
        static int GetTriangularNumber(int n)
        {
            //Base case
            if (n == 1)
            {
                return 1;
            }
            //Recur
            else
            {
                return n + GetTriangularNumber(n - 1);
            }
        }
        //Display Example
        static void Main(string[] args)
        {
            Console.WriteLine("The first 10 triangular numbers:");
            for (int i = 1; i <= 10; i++)
            {
                int triangularNumber = GetTriangularNumber(i);
                //Current number
                Console.WriteLine($"T_{i} = {triangularNumber}");
            }
        }
    }
}
