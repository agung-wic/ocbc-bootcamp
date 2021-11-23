using System;

class SoalNmor1
{
    public static void Main(string[] args)
    {
        bool pass = false;

        while (!pass)
        {
            Console.WriteLine("Program Segitiga Alfabet");
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
}