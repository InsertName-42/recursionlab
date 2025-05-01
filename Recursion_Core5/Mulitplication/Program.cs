using System;

namespace Mulitplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiply");
            for (int n = 1; n <= 10; n++)
                Console.WriteLine(String.Format("5 * {0,2} is {1,2}", n, multiply(5, n)));
            Console.WriteLine();

            Console.WriteLine("Now for some real fun!");
            Console.WriteLine(String.Format("5 * {0,2} is {1,2}", 0, multiply(5, 0)));

        }
        static int multiply(int x, int y)
        {
            if (y == 1)
                return x;
            else
                return x + multiply(x, y - 1);
        }
    }
}
