using System;

class HitungNilai
{
    public static void Main(string[] args)
    {
        int pertama, kedua, ketiga, jumlah;
        double rata;

        Console.WriteLine("=====Menghitung Nilai=====");
        Console.Write("Masukan Angka Pertamma: ");
        pertama = int.Parse(Console.ReadLine());
        Console.Write("Masukan Angka Kedua :");
        kedua = int.Parse(Console.ReadLine());
        Console.Write("Masukan Angka Ketiga :");
        ketiga = int.Parse(Console.ReadLine());

        jumlah = pertama+kedua+ketiga;
        rata = jumlah/3;

        Console.WriteLine("Total Nilai adalah "+jumlah);
        Console.WriteLine("Rata-rata Nilai adalah "+rata);


    }
}