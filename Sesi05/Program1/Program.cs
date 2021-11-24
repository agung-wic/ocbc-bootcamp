using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop();

            Console.Write("Enter Laptop Name: ");
            laptop1.merk = Console.ReadLine();
            Console.Write("Enter RAM Volume: ");
            laptop1.ram = int.Parse(Console.ReadLine());
            Console.Write("Enter Memory Volume: ");
            laptop1.memory = int.Parse(Console.ReadLine());

            Console.WriteLine("\nMerk laptop adalah {0}", laptop1.merk);
            Console.WriteLine("RAM laptop adalah {0} GB", laptop1.ram);
            Console.WriteLine("Memory laptop adalah {0} GB", laptop1.memory);

            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();
        }
    }
}
