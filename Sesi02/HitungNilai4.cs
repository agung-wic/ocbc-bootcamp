using System;

class HitungNilai4
{

    public static void Main(string[] args)
    {
        Console.Write("Enter Your Age : ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter Password : ");
        string password = Console.ReadLine();

        bool isAdult = age > 18;
        bool isPasswordCorrect = password == "OCBC";

        if (isAdult && isPasswordCorrect)
        {
            Console.WriteLine("Welcome To The Club");
        }
        else
        {
            Console.WriteLine("Sorry, Try Again");
        }
    }
}