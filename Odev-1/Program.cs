using System;

namespace Odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Soru

            //Console.Write("Pozitif bir sayı giriniz: ");
            //int counter = int.Parse(Console.ReadLine());
            //int[] numbers = new int[counter];
            //if (counter < 1)
            //{
            //    Console.WriteLine("Lütfen tekrar pozitif sayı giriniz.");
            //}
            //else
            //{
            //    for (int i = 0; i < counter; i++)
            //    {

            //        Console.Write("{0}.sayiyi giriniz: ", i + 1);
            //        numbers[i] = int.Parse(Console.ReadLine());
            //    }
            //    foreach (var number in numbers)
            //    {
            //        if (number % 2 == 0)
            //        {
            //            Console.WriteLine("Çift Sayi:" + number);
            //        }
            //    }
            //}


            //  2.Soru

            //Console.Write("Gireceğiniz sayı miktarını giriniz: ");
            //int counter = int.Parse(Console.ReadLine());
            //Console.Write("Bölünecek sayıyı giriniz: ");
            //int dividing = int.Parse(Console.ReadLine());
            //int[] numbers = new int[counter];

            //if (counter < 1)
            //{
            //    Console.WriteLine("Lütfen tekrar pozitif sayı giriniz...");
            //}
            //else
            //{
            //    for (int i = 0; i < counter; i++)
            //    {
            //        Console.Write("{0}. sayiyi giriniz: ", i + 1);
            //        numbers[i] = int.Parse(Console.ReadLine());
            //    }
            //    Console.Write("Tam bölünen sayilar: ");
            //    foreach (var number in numbers)
            //    {
            //        if(number % dividing == 0)
            //        {
            //            Console.Write(" " + number);
            //        }
            //    }
            //}



            // 3.Soru

            //Console.Write("Yazacağınız kelimenin sayısını giriniz:");
            //int counter = int.Parse(Console.ReadLine());
            //string[] words = new string[counter];
            //for (int i = 0; i < counter; i++)
            //{
            //    Console.Write("{0}. kelimeyi giriniz: ", i+1);
            //    words[i] = Console.ReadLine();
            //}
            //Array.Reverse(words);
            //Console.Write("Girilen kelimelerin sondan başa doğru yazılması: ");
            //foreach (var word in words)
            //{
            //    Console.Write(" " +word);
            //}



            // 4.Soru

            Console.Write("Bir cümle giriniz: ");
            string Sentence = Console.ReadLine();
            string[] NumberofWord = Sentence.Split(" ");
            
            int NumberofCharacter = Sentence.Length;
            NumberofCharacter = NumberofCharacter - (NumberofWord.Length-1);

            Console.WriteLine("Kelime Sayisi: " + NumberofWord.Length);
            Console.WriteLine("Harf Sayisi: " + NumberofCharacter);
            
        }
    }
    
}


//Console.WriteLine("Bir kelime yazınız:");

//string yazi = Console.ReadLine();

//string[] dizi = yazi.Split(" ");

//Console.WriteLine("Kelime Sayisi= " + dizi.Length);

//int f = yazi.Length;

//int harfsayisi = f - (dizi.Length - 1);


//Console.WriteLine("Harf Sayisi= " + harfsayisi);
