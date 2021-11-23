using System;

class SoalNomer3
{
    public static void Main(string[] args)
    {
        bool pass = false;

        while (!pass)
        {
            Console.Write("Enter Number: ");
            int number = int.Parse(Console.ReadLine());
            long result = 1;

            if (number < 1)
            {
                Console.WriteLine("Your number not valid!");
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }
                Console.WriteLine($"The factorial of {number} is {result}");
            }
            Console.Write("Try Again (y/n)?");
            string tryAgain = Console.ReadLine();
            if (tryAgain == "y") pass = false;
            else pass = true;
        }
    }
}