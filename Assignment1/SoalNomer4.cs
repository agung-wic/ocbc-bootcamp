using System;

class SoalNomer4
{
    public static void Main(string[] args)
    {
        bool pass = false;

        while (!pass)
        {
            Console.Write("Enter Number: ");
            long number = int.Parse(Console.ReadLine());

            if (number < 1)
            {
                Console.WriteLine("Your number not valid!");
            }
            else
            {
                string input = number.ToString();

                char[] inputArray = input.ToCharArray();

                Array.Reverse(inputArray);

                string result = new string(inputArray);

                Console.WriteLine($"The reverse of {input} is {result}");
            }
            Console.Write("Try Again (y/n)?");
            string tryAgain = Console.ReadLine();
            if (tryAgain == "y") pass = false;
            else pass = true;
        }
    }
}