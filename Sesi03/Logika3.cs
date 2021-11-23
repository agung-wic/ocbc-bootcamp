using System;

class Logika3
{
    public static void Main(string[] args)
    {
        string username, password;

        Console.Write("Enter Your Username: ");
        username = Console.ReadLine();
        Console.Write("Enter Your Password: ");
        password = Console.ReadLine();

        if (username == "ocbc" && password == "bootcamp")
        {
            Console.WriteLine("You have successfully logged in");
        }
        else
        {
            Console.WriteLine("Your username or password is wrong!");
        }
    }
}