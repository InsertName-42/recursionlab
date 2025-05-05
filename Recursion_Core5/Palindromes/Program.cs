using System;
using System.Text.RegularExpressions;

namespace Palindromes
{
    class Program
    {
        //Check if a string is a palindrome
        static bool IsPalindromeRecursive(string s)
        {
            //An empty string or a string with one character is a palindrome
            if (s.Length <= 1)
            {
                return true;
            }
            //If the first and last characters are not the same, it's not a palindrome
            if (s[0] != s[^1])
            {
                return false;
            }
            //Check if excluding the first and last characters creates a palindrome
            return IsPalindromeRecursive(s.Substring(1, s.Length - 2));
        }

        static string ProcessInput(string input)
        {
            //Remove noncharacters
            string cleanedInput = Regex.Replace(input, "[^a-zA-Z0-9]", "");
            //Convert to lowercase
            return cleanedInput.ToLower();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter text to be tested:");
            string userInput = Console.ReadLine();

            //Process input
            string processedInput = ProcessInput(userInput);

            //Check
            bool isPalindrome = IsPalindromeRecursive(processedInput);

            //Display result
            if (isPalindrome)
            {
                Console.WriteLine($"\"{userInput}\" is a palindrome.");
            }
            else
            {
                Console.WriteLine($"\"{userInput}\" is not a palindrome.");
            }
        }
    }
}