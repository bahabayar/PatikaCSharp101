using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();
            
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz","Arda",330,1);
            ogrenci1.OgrenciBilgileriniGetir();

            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim 
        {
            get { return isim; }
            set { isim = value; } 
        }


        public string Soyisim 
        {
            get { return soyisim; }
            set { soyisim = value; } 
        }

        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif;
            set 
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olaiblir!");
                    sinif = 1;
                }
                else
                    sinif = value; 
            }
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci(){ }
        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("******Ogrenci Bilgileri*******");
            Console.WriteLine("Öğrenci Adı     :{0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı  :{0}", this.Soyisim);
            Console.WriteLine("Öğrenci No      :{0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı  :{0}", this.Sinif);
        }
        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
