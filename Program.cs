
using System;
using System.Collections.Generic;

namespace Proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kisi> kisilistesi = new List<Kisi>();
            KisiYonetimi kisiyonetimi = new KisiYonetimi();
            kisilistesi.Add(new Kisi("Ferhat","Ersoy","9815"));
            kisilistesi.Add(new Kisi("Betul","Ersoy2","5816"));
            kisilistesi.Add(new Kisi("Sadık","Ersoy4","3719"));


            
           

            int number = 0;
            while(number != 6)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                Console.WriteLine("******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetme");
                Console.WriteLine("(2) Varolan Numarayı Silme");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listeleme");
                Console.WriteLine("(5) Rehberde Arama Yapma");
                Console.WriteLine("(6) İşlemden çıkış");
                number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        kisiyonetimi.KisiEkle(kisilistesi);
                        break;
                    case 2:
                        kisiyonetimi.KisiSil(kisilistesi);
                        break;
                    case 3:
                        kisiyonetimi.KisiGuncelleme(kisilistesi);
                        break;
                    case 4:
                        kisiyonetimi.KisiGoruntele(kisilistesi);
                        break;
                    case 5:
                        kisiyonetimi.KisiAra(kisilistesi);
                        break;
                    case 6:
                        Console.WriteLine("İşlem sonlandırılıyor.");
                        break;
                }
            }
        }
    }
}