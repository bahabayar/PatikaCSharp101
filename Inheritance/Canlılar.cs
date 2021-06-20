using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Canlılar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir");
        }
        protected void Solunu()
        {
            Console.WriteLine("Canlılar solunum yapar.");
        }
        protected void Bosaltim()
        {
            Console.WriteLine("Canlılar bosaltim yapar.");
        }
    }
}
