﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Hayvanlar : Canlılar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyos kuraiblir");
        }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlara temasa tepki verir");
        }
    }
    public class Sürüngenler : Hayvanlar
    {
        public Sürüngenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunu();
        }
        public void SurunerekHareketEderler()
        {
            Console.WriteLine("Surungenler surunerek hareket eder.");
        }
    }
    public class Kuslar : Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunu();
            base.UyaranlaraTepki();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }
}
