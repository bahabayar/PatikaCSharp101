using System;
using System.Collections;
using System.Collections.Generic;

namespace Array_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();

            /*
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');
            Console.WriteLine(liste[1]);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            */

            Console.WriteLine("***** Add Range *****");
            List<int> sayılar = new List<int>(){1, 8, 3, 7, 9, 92, 5};

            liste.AddRange(sayılar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***** Sort *****");
            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***** Binary Search *****");
            Console.WriteLine(liste.BinarySearch(9));

            Console.WriteLine("***** Reverse ******");
            liste.Reverse();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***** Clear *****");
            liste.Clear();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}