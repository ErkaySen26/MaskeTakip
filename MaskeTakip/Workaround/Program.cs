using Business.Concrete;
using Entities.Concrete;
using System;
using System.Xml;
namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler();
            Vatandas vatandas1 = new Vatandas();
            SelamVer(isim:"Engin");
            SelamVer(isim:"Ahmet");
            int sonuc =Topla();

            //Diziler /Arrays
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Erlay";
            ogrenciler[2] = "Ercay";

            ogrenciler =new string[4];
            ogrenciler[3] = "İlker";

            for(int i = 0;i<ogrenciler.Length;i++) {

                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1=new Person();
            person1.FirstName = "Erkay";
            person1.LastName = "ŞEN";
            person1.DateOfBirthYear = 2003;
            person1.NationalIdentity = 47371026482;

            Person person2=new Person();
            person2.FirstName = "Murat";


            foreach(string sehir in sehirler1)
            {

                Console.WriteLine(sehir);
            }
            //ÖDEV!!!!!!!!
            //aşağıdaki list yapısını bilmiyor olsaydın sen bu yapıyı nasıl yazardın ??
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add(item: "Adana 1");
            foreach(var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }
            //Ödev ifadesiiii
            //string[] yeniSehirler2 = new string[] { "Ankara 1 ", "İstanbul 1 ", "İzmir 1" };
            //string[] genisSehirler=new string[yeniSehirler2.Length+1];

            //for(int i=0;i<yeniSehirler2.Length;i++) 
            //{
            //    genisSehirler[i] = yeniSehirler2[i];
            //}
            //genisSehirler[genisSehirler.Length - 1] = "Adana 1";

            //foreach(var sehir in genisSehirler)
            //{
            //    Console.WriteLine(sehir);
            //}


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            Console.ReadLine();
        }
        static void SelamVer(string isim)
        {
            Console.WriteLine("Merhaba" + " "+ isim);
        }
        static int Topla(int sayi1=50,int sayi2 = 150)
        { 
             int sonuc =sayi1 + sayi2;
            Console.WriteLine("Toplam"+sonuc);
            return sonuc;
        }


        private static void Değişkenler()
        {
            string mesaj = "Selam";
            double tutar = 1000000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Erkay";
            string soyad = "ŞEN";
            int dogumYili = 2003;
            long tcNo = 12345678910;
            
            Console.WriteLine(mesaj);
            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(1000000 * 1.18);

            Console.ReadLine();
        
        }
    }
    public class Vatandas
    {
        public string Ad { get ; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
//SOLID yazlım kodlama standartları
//entitites katmanı nesneleri verileri tutar 
//Business içerisinde şart bloklarını kullanırız