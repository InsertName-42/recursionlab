using System;

namespace TowerOfHanoi
{
    class Program
    {
        //Method to solve the Tower of Hanoi puzzle
        static void SolveTowerOfHanoi(int n, string source, string destination, string secondary)
        {
            //Base Case
            if (n == 1)
            {
                Console.WriteLine($"Move disc 1 from {source} to {destination}");
                return;
            }
            //Recur
            //Clears
            SolveTowerOfHanoi(n - 1, source, secondary, destination);
            Console.WriteLine($"Move disc {n} from {source} to {destination}");
            //Solves
            SolveTowerOfHanoi(n - 1, secondary, destination, source);
        }
        //Display example
        static void Main(string[] args)
        {
            //Instructions
            Console.WriteLine("Tower of Hanoi Puzzle Solver");
            Console.Write("Select number of discs: ");

            if (int.TryParse(Console.ReadLine(), out int numberOfDiscs) && numberOfDiscs > 0)
            {
                SolveTowerOfHanoi(numberOfDiscs, "Source", "Destination", "Secondary");
                //Formula
                Console.WriteLine("Puzzle solved in " + (Math.Pow(2, numberOfDiscs) - 1) + " moves.");
            }
            //Input validation
            else
            {
                Console.WriteLine("Invalid input. Enter a positive integer.");
            }
        }
    }
}