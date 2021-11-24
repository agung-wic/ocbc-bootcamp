using System;

namespace Program2
{
    public class Pesawat
    {
        public string nama;
        private string ketinggian;
        public string Ketinggian
        {
            get { return this.ketinggian; }
            set { this.ketinggian = value; }
        }

        public void Terbang()
        {
            Console.WriteLine("Pesawat dengan nama {0} sedang takeoff", this.nama);
        }
        public void SudahTerbang()
        {
            Console.WriteLine("Pesawat dengan nama {0} sedang berada pada ketinggian {1}", this.nama, this.ketinggian);
        }
    }
}