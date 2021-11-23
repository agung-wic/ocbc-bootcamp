using System;

class SoalNomer6
{
    public static void Main(string[] args)
    {
        bool pass = false;

        while (!pass)
        {
            Console.Write("Enter Word: ");
            string input = Console.ReadLine().ToLower();

            char[] inputArray = input.ToCharArray();

            Array.Reverse(inputArray);

            string output = new string(inputArray);

            if (input == output)
                Console.WriteLine($"{input} is Palindrome");
            else Console.WriteLine($"{input} is not Palindrome");

            Console.Write("Try Again (y/n)?");
            string tryAgain = Console.ReadLine();
            if (tryAgain == "y") pass = false;
            else pass = true;

        }
    }
}