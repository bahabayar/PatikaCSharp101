using System;
using System.Collections.Generic;

namespace telefon_rehberi
{
    class Program
    {
        public static List<PersonInfo> persons;
        static void Main(string[] args)
        {
            persons = new List<PersonInfo>();

            persons.Add(new PersonInfo("Baha", "Bayar", 5458799545));
            persons.Add(new PersonInfo("Reha", "Bayar", 5458799542));
            persons.Add(new PersonInfo("Selim", "Karakuş", 5458799541));
            persons.Add(new PersonInfo("Şafak ", "Hazer", 5458799543));
            persons.Add(new PersonInfo("Emre", "Ekiz", 5458799548));

            MainMenu();
        }

        public static void MainMenu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek\n(2) Varolan Numarayı Silmek\n(3) Varolan Numarayı Güncellemek\n(4) Rehberi Listelemek\n(5) Rehberde Arama Yapmak\n");
            Console.Write("İşlem tercihiniz: ");

            int task = int.Parse(Console.ReadLine());

            switch (task)
            {
                case 1:
                    AddNewNumber();
                    break;
                case 2:
                    DeleteNumber();
                    break;
                case 3:
                    UpdateNumber();
                    break;
                case 4:
                    ShowPhoneBook();
                    break;
                case 5:
                    SearchPhoneBook();
                    break;
                default:
                    Console.WriteLine("Hatalı giriş yaptınız!\n");
                    MainMenu();
                    break;
            }
        }

        public static void AddNewNumber()
        {
            Console.Write("Lütfen isim giriniz: ");
            string name = Console.ReadLine();

            Console.Write("Lütfen soyisim giriniz: ");
            string surname = Console.ReadLine();

            Console.Write("Lütfen telefon numarası giriniz (başında 0 olmadan): ");
            string phoneNumber = Console.ReadLine();

            while (phoneNumber.Length != 10)
            {
                Console.Write("Telefon numaranız 10 haneli olmalıdır! Lütfen telefon numarınızı tekrar giriniz (başında 0 olmadan): ");
                phoneNumber = Console.ReadLine();
            }

            persons.Add(new PersonInfo(name, surname, long.Parse(phoneNumber)));
            MainMenu();
        }

        public static void DeleteNumber()
        {
            Console.Write("Lütfen numarısını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string personName = Console.ReadLine();

            foreach (PersonInfo person in persons)
            {
                if (person.Name == personName || person.Surname == personName)
                {
                    Console.WriteLine("{0} {1} isimli kişi rehberden silinmek üzere, onaylıyor musunuz? (y/n)", person.Name, person.Surname);
                    string input = Console.ReadLine();

                    if (input == "y")
                    {
                        persons.Remove(person);
                        Console.WriteLine("Silme işlemi başarılı.\n");
                        MainMenu();
                    }
                    else if (input == "n")
                    {
                        MainMenu();
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş yaptınız!\n");
                        MainMenu();
                    }
                }
            }

            Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için : (2)");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                MainMenu();
            }
            else if (choice == "2")
            {
                DeleteNumber();
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız!");
                MainMenu();
            }
            
        }

        public static void UpdateNumber()
        {
             Console.Write("Lütfen numarısını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string personName = Console.ReadLine();

            foreach (PersonInfo person in persons)
            {
                if (person.Name == personName || person.Surname == personName)
                {
                    Console.Write("{0} {1} isimli kişinin yeni numarasını giriniz: ", person.Name, person.Surname);
                    string newNumber = Console.ReadLine();

                    while (newNumber.Length != 10)
                    {
                        Console.Write("Numara 10 haneli olmalıdır, lütfen tekrar deneyin: ");
                        newNumber = Console.ReadLine();
                    }

                    person.PhoneNumber = long.Parse(newNumber);
                    MainMenu();
                }
            }

            Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Güncellemeyi sonlandırmak için : (1)\n* Yeniden denemek için : (2)");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                MainMenu();
            }
            else if (choice == "2")
            {
                UpdateNumber();
            }
            else
            {
                Console.WriteLine("Hatalı giriş yaptınız!");
                MainMenu();
            }
        }

        public static void ShowPhoneBook()
        {
            persons.Sort(delegate(PersonInfo p1, PersonInfo p2) { return p1.Name.CompareTo(p2.Name); });

            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************");
            foreach (PersonInfo person in persons)
            {
                Console.WriteLine("İsim: {0}\nSoyisim: {1}\nTelefon Numarası: {2}\n-", person.Name, person.Surname, person.PhoneNumber);
            }

            MainMenu();
        }

        public static void SearchPhoneBook()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("*********************************************");
            Console.WriteLine("\nİsim veya soyisime göre arama yapmak için : (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için : (2)");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("İsim veya soyisim giriniz: ");
                string personName = Console.ReadLine();

                foreach (PersonInfo person in persons)
                {
                    if (person.Name == personName || person.Surname == personName)
                    {
                        Console.WriteLine("İsim: {0}\nSoyisim: {1}\nTelefon Numarası: {2}\n-", person.Name, person.Surname, person.PhoneNumber);
                    }
                }

                MainMenu();
            }
            else if (choice == "2")
            {
                Console.Write("Telefon numarası giriniz: ");
                long phoneNumber = long.Parse(Console.ReadLine());

                foreach (PersonInfo person in persons)
                {
                    if (person.PhoneNumber == phoneNumber)
                    {
                        Console.WriteLine("İsim: {0}\nSoyisim: {1}\nTelefon Numarası: {2}\n-", person.Name, person.Surname, person.PhoneNumber);
                    }
                }

                MainMenu();
            }
            else
            {
                Console.WriteLine("Hatalı Giriş Yaptınız!\n");
                MainMenu();
            }
        }
    }

    

    public class PersonInfo
    {
        private string name;
        private string surname;
        private long phoneNumber;

        public PersonInfo(string name, string surname, long phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public long PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
