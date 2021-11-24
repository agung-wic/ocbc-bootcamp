using System;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat1 = new Pesawat();

            Console.Write("Masukan Nama Pesawat: ");
            pesawat1.nama = Console.ReadLine();
            Console.Write("Masukan Ketinggian Pesawat: ");
            pesawat1.Ketinggian = Console.ReadLine();

            pesawat1.Terbang();
            pesawat1.SudahTerbang();
        }
    }
}
