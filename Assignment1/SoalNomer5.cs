using System;

class SoalNomer5
{
    public static void Main(string[] args)
    {
        bool pass = false;
        string output = "";

        while (!pass)
        {
            Console.Write("Enter Number: ");
            long number = int.Parse(Console.ReadLine());

            string input = number.ToString();

            char[] inputArray = input.ToCharArray();

            foreach (int item in inputArray)
            {
                switch (item)
                {
                    case '-':
                        output += "Negative ";
                        break;
                    case '0':
                        output += "Zero ";
                        break;
                    case '1':
                        output += "One ";
                        break;
                    case '2':
                        output += "Two ";
                        break;
                    case '3':
                        output += "Three ";
                        break;
                    case '4':
                        output += "Four ";
                        break;
                    case '5':
                        output += "Five ";
                        break;
                    case '6':
                        output += "Six ";
                        break;
                    case '7':
                        output += "Seven ";
                        break;
                    case '8':
                        output += "Eight ";
                        break;
                    case '9':
                        output += "Nine ";
                        break;
                    default:
                        output += "";
                        break;
                }
            }

            Console.WriteLine($"The Convertion of {input} is {output}");
            Console.Write("Try Again (y/n)?");
            string tryAgain = Console.ReadLine();
            if (tryAgain == "y") pass = false;
            else pass = true;
        }
    }
}