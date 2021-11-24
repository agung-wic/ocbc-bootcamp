using System;

namespace Program3
{
    public class Pesawat
    {
        public string nama;
        public string Ketinggian
        { get; set; }
        public string JumlahPenumpang
        { get; set; }
        public int JumlahRoda
        { get; set; }

        public void Terbang()
        {
            Console.WriteLine("Pesawat dengan nama {0} sedang takeoff", this.nama);
        }
        public void SudahTerbang()
        {
            Console.WriteLine("Pesawat dengan nama {0}\n" +
            " sedang berada pada ketinggian {1}\n",
            this.nama,
            this.Ketinggian
            );
        }

    }

    public class PesawatTempur : Pesawat
    {
        public void TerbangTinggi()
        {
            Console.WriteLine("Pesawat dengan nama {0}, yang mempunyai jumlah roda {1}, sedang terbang pada ketinggian {2} dengan membawa jumlah penumpang {3} akan meledakkan senjata", this.nama, this.JumlahRoda, this.Ketinggian, this.JumlahPenumpang);
        }
    }
}