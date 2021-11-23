using System;

class String4{
    public static void Main(string [] args){
        string stringAwal = "C# membuat string mudah";

        string subStr = stringAwal.Substring(5,12);

        Console.WriteLine("String Awal: "+stringAwal);
        Console.WriteLine("Sub String: "+subStr);
    }
}