using System;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            PesawatTempur tempur = new PesawatTempur();

            pesawat.nama = "Helly";
            pesawat.JumlahRoda = 3;
            pesawat.Ketinggian = "1000 kaki";
            pesawat.JumlahPenumpang = "3 penumpang";
            tempur.nama = "AZ500TPU";
            tempur.JumlahRoda=5;
            tempur.Ketinggian = "200 kaki";
            tempur.JumlahPenumpang = "2 penumpang plus kopilot dan assistance";

            pesawat.Terbang();
            tempur.TerbangTinggi();
        }
    }
}
