using System;

namespace kalitim // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                 Canlılar
            //                     |
            //     Bitkiler                    Hayvanlar
            //     |       |                |              |       
            // Tohumlu    Tohumsuz        Sürüngenler      Kuşlar

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
           
            tohumluBitki.TohumlaCogalma();
            Console.WriteLine("*********");
            Kuslar Marti = new Kuslar();
            Marti.Ucmak();


        }
    }
}