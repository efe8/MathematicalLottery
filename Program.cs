using System;

namespace SayisalLoto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6 adet sayı giriniz.");

            int[] tahminler = new int[6];

            for (int i = 0; i < tahminler.Length; i++)
            {
                Console.Write((i + 1) + ". sayıyı girin: ");
                tahminler[i] = int.Parse(Console.ReadLine());
            }

            Random rnd = new Random();

            int[] loto = new int[6];

            for (int i = 0; i < loto.Length; i++)
            {
                loto[i] = rnd.Next(50);
            }

            int sayac = 0;

            int[] bilinenler = new int[6];

            for (int i = 0; i < tahminler.Length; i++)
            {
                for (int t = 0; t < loto.Length; t++)
                {
                    if (tahminler[i] == loto[t])
                    {
                        sayac++;
                        bilinenler[i] = loto[t];
                    }
                }
            }

            Console.WriteLine();

            if (sayac < 3)
            {
                Console.WriteLine("Kazanamadınız.");
            }
            else
            {
                Console.WriteLine("tebrikler " + sayac + " adet sayı bildiniz.");
            }

            Console.WriteLine();

            for (int i = 0; i < bilinenler.Length; i++)
            {
                if (bilinenler[i] != 0)
                {
                    Console.Write(bilinenler[i] + " ");
                }

            }

            Console.WriteLine();

            for (int i = 0; i < loto.Length; i++)
            {
                Console.Write(loto[i] + " ");
            }
        }
    }
}
