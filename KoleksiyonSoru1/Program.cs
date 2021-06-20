using System;
using System.Collections;

namespace KoleksiyonSoru1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            
            ArrayList primeNumbers = new ArrayList();
            ArrayList nonprimeNumbers = new ArrayList();
            while (counter < 5)
            {
                Console.Write("{0}.Pozitif Sayi giriniz: ",counter+1);
                int value = int.Parse(Console.ReadLine());
                if (value < 0)
                {
                    Console.WriteLine("{0}. sayıyı tekrar giriniz:", counter + 1);
                }
                else
                {
                    if (IsPrime(value))
                    {
                        primeNumbers.Add(value);
                    }
                    else
                    {
                        nonprimeNumbers.Add(value);
                    }
                }
                counter++;
            }
            ReverseSort(primeNumbers);
            ReverseSort(nonprimeNumbers);
            Console.Write("Asal sayılar: ");
            foreach (var item in primeNumbers)
            {
                Console.Write(" "+item);
            }
            Console.Write("Asal olmayan sayılar: ");
            foreach (var item in nonprimeNumbers)
            {
                Console.Write(" " + item);
            }
        }
        static bool IsPrime(int number)
        {
            bool result = true;

            if(number == 1)
            {
                return false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        public static void ReverseSort(ArrayList list)
        {
            list.Sort();
            list.Reverse();
        }
        public static int ListCount(ArrayList list)
        {
            int count = list.Count;
            return count;
        }
        


    }
   
}

