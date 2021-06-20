using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           // Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır.
           Console.Write("Lütfen bir sayı giriniz: ");
           int sayac = int.Parse(Console.Readline());
           for (int i = 1; i <= sayac; sayac++)
           {
               if (i % 2 == 1)
               {
                   Console.WriteLine(i);
               }
           }
           // 1 ile 1000 arasında ki tek ve çift sayıların toplamlarını yazdır.
           int tekToplam = 0;
           int çiftToplam = 0;
           for (int i = 1; i <= 1000; i++)
           {
               if (i % 2 == 0)
               {
                   çiftToplam += i;
               }
               else
               {
                   tekToplam += i;
               }
           }
           Console.WriteLine("Tek Toplam: " + tekToplam);
           Console.WriteLine("Çift Toplam: " + çiftToplam);
           */

            // Break Continue
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }

                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}