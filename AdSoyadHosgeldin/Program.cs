using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdSoyadHosgeldin
{
    class Program
    {
        static void Main(string[] args)
        {
            
          Console.WriteLine("İsminizi girin");
          string name =   Console.ReadLine();
            Console.WriteLine("Soyadınızı Girin");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba" + name + " " +surname);
        }
    }
}
