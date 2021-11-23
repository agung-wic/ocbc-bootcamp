using System;
using System.Globalization;

class FinalAssignment1
{
    public static void Main(string[] args)
    {
        string backToMenu = "y";
        while (backToMenu == "y")
        {
            Console.WriteLine("===========================");
            Console.WriteLine("        Assignment 1");
            Console.WriteLine("      Agung Wicaksono");
            Console.WriteLine("       FSDO002ONL012");
            Console.WriteLine("        Kab. Madiun");
            Console.WriteLine("===========================");
            Console.WriteLine("1. Segitiga Alfabet");
            Console.WriteLine("2. Segitiga Angka");
            Console.WriteLine("3. Faktorial");
            Console.WriteLine("4. Balik Angka");
            Console.WriteLine("5. Converter Angka dengan String");
            Console.WriteLine("6. Palindrome");
            Console.WriteLine("7. Keluar");

            Console.Write("Enter menu: ");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    SegitigaAlfabet();
                    break;
                case 2:
                    SegitigaAngka();
                    break;
                case 3:
                    Faktorial();
                    break;
                case 4:
                    BalikAngka();
                    break;
                case 5:
                    AngkaKeString();
                    break;
                case 6:
                    Palindrome();
                    break;
                case 7:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong Menu Number");
                    break;
            }
            Console.Write("Do you want to go back to the main menu (y/n)?");
            backToMenu = Console.ReadLine();
        }
    }

    public static void SegitigaAlfabet()
    {
        bool pass = false;

        while (!pass)
        {
            Console.WriteLine("You are selecting the alphabet triangle program");
            Console.Write("Enter Range: ");
            int range = int.Parse(Console.ReadLine());

            if (range < 1)
            {
                Console.WriteLine("Your number out of the range");
            }
            else
            {
                for (int i = 0; i < range; i++)
                {
                    int letter = 64;
                    for (int j = 0; j < (2 * range) - 1; j++)
                    {
                        if (j < range - i - 1)
                        {
                            Console.Write(" ");
                        }
                        else if (j < range + i)
                        {
                            if (j >= range)
                            {
                                if (letter <= 65)
                                {
                                    letter = 90;
                                }
                                else
                                {
                                    letter--;
                                }
                            }
                            else
                            {
                                if (letter >= 90)
                                {
                                    letter = 65;
                                }
                                else
                                {
                                    letter++;
                                }
                            }
                            Console.Write(Convert.ToChar(letter));
                        }
                    }
                    Console.WriteLine();
                }
                Console.Write("Try Again (y/n)?");
                string tryAgain = Console.ReadLine();
                if (tryAgain == "y") pass = false;
                else pass = true;
            }
        }
    }

    public static void SegitigaAngka()
    {
        bool pass = false;

        while (!pass)
        {
            Console.WriteLine("You are selecting the number triangle program");
            Console.Write("Enter Range: ");
            int range = int.Parse(Console.ReadLine());

            if (range < 1)
            {
                Console.WriteLine("Your number out of the range");
            }
            else
            {
                for (int i = 0; i < range; i++)
                {
                    int number = 0;
                    for (int j = 0; j < (2 * range) - 1; j++)
                    {
                        if (j < range - i - 1)
                        {
                            Console.Write(" ");
                        }
                        else if (j < range + i)
                        {
                            if (j >= range)
                            {
                                if (number <= 1)
                                {
                                    number = 9;
                                }
                                else
                                {
                                    number--;
                                }
                            }
                            else
                            {
                                if (number >= 9)
                                {
                                    number = 1;
                                }
                                else
                                {
                                    number++;
                                }
                            }
                            Console.Write(number);
                        }
                    }
                    Console.WriteLine();
                }
                Console.Write("Try Again (y/n)?");
                string tryAgain = Console.ReadLine();
                if (tryAgain == "y") pass = false;
                else pass = true;
            }
        }
    }

    public static void Faktorial()
    {
        bool pass = false;

        while (!pass)
        {
            Console.WriteLine("You are selecting the faktorial");
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

    public static void BalikAngka()
    {
        bool pass = false;

        while (!pass)
        {
            Console.WriteLine("You are selecting reverse number program");
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

    public static void AngkaKeString()
    {
        bool pass = false;
        string output = "";

        while (!pass)
        {
            Console.WriteLine("You are selecting convert numbers to strings program");
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

    public static void Palindrome()
    {
        bool pass = false;

        while (!pass)
        {
            Console.Write("You are Selecting Palindrome Program");
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