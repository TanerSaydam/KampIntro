using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayiler1 = new int[] { 10, 20, 30 };
            int[] sayiler2 = new int[] { 100, 200, 300 };
            sayiler1 = sayiler2;
            sayiler2[0] = 999;
            Console.WriteLine(sayiler1[0]);
        }
    }
}
