using System;

class HitungNilai3
{
    public static void Main(string[] args)
    {
        int nilai1, nilai2 = 0;

        Console.Write("Masukan Nilai Pertama: ");
        nilai1 = int.Parse(Console.ReadLine());
        Console.Write("Masukan Nilai Kedua: ");
        nilai2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Hasil Perbandingan");
        Console.WriteLine($"nilai1 > nilai2 = {nilai1>nilai2}");
        Console.WriteLine($"nilai1 >= nilai2 = {nilai1>=nilai2}");
        Console.WriteLine($"nilai1 < nilai2 = {nilai1<nilai2}");
        Console.WriteLine($"nilai1 <= nilai2 = {nilai1<=nilai2}");
        Console.WriteLine($"nilai1 == nilai2 = {nilai1>nilai2}");
        Console.WriteLine($"nilai1 != nilai2 = {nilai1>nilai2}");
    }
}