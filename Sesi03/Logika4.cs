using System;

class Logika4
{
    public static void Main(string[] args)
    {
        double nilai;
        char grade = ' ';
        Console.Write("Masukan nilai anda: ");
        nilai = Convert.ToDouble(Console.ReadLine());

        if (nilai >= 85)
        {
            grade = 'A';
        }
        else if (nilai >= 65)
        {
            grade = 'B';
        }
        else if (nilai >= 45)
        {
            grade = 'C';
        }
        else if (nilai <= 25)
        {
            grade = 'D';
        }
        Console.WriteLine($"Kamu mendapat {grade}");
    }
}