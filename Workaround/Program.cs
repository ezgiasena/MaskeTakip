using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Vatandas vatandas1 = new Vatandas();

            SelamVer(isim: "Ezgi");
            SelamVer(isim: "Asena");
            SelamVer(isim: "Furkan");
            SelamVer();
            int sonuc = Topla(6,58);

            //Diziler = arrays 
            string ogrenci1 = "ezgi";
            string ogrenci2 = "asena";
            string ogrenci3 = "furkan";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "ezgi";
            ogrenciler[1] = "asena";
            ogrenciler[2] = "furkan";

            for (int i = 0; i < ogrenciler.Length; i++) 
            {
                Console.WriteLine(ogrenciler[i]);

            }

            string[] sehirler1 = new[] { "Ankara", "Istanbul", "Izmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakir" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);


            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            Person person1= new Person();
            person1.FirstName = "ezgi asena ";
            person1.LastName = "özüdoğru";
            person1.DateOfBirthYear = 1945;
            person1.NationalIdentity =456;

            Person person2= new Person();
            person2.FirstName = "furkan";


            List<string> yeniSehirler1 = new List<string> { "Ankara1", "istanbul1", "izmir1" };
            yeniSehirler1.Add("Adana1");
            foreach(var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();

        }

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc.ToString());
            return sonuc;


        }



        public class Vatandas
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int DogumYili { get; set; }
            public long tcNo { get; set; }

        }




    }


}