using System;

class Project3
{
    static void Main(string[] args)
    {
        string nama;
        int umur;

        Console.WriteLine("=====Program Pendaftaran Penduduk=====");
        Console.Write("Masukan Nama: ");
        nama = Console.ReadLine();
        Console.Write("Masukan Alamat: ");
        var alamat = Console.ReadLine();
        Console.Write("Masukan Umur: ");
        umur = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Terimakasih");
        Console.WriteLine("Data yang dimasukkan: ");
        Console.WriteLine($"Nama: {nama}");
        Console.WriteLine($"Alamat: {alamat}");
        Console.WriteLine($"Umur: {umur}");
        Console.WriteLine("Data Sudah Disimpan");
    }
}