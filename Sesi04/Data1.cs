using System;

class Data1{
    public static void Main(string[] args){
        int[] aAngka = new int[5];
        string [] aNama = new string[] {"Joni","Meri","David"};
        object[] aObjek = {20.33, "Lorem ipsum", DateTime.Now, true, 'D'};

        aAngka[0]=1;
        aAngka[1]=3;
        aAngka[2]=6;

        Console.WriteLine("Angka yang anda buat : "+aAngka[2]);
        Console.WriteLine("Nama Anda : "+aNama[0]);
        Console.WriteLine("Objek anda : "+aObjek[2]);
    }
}