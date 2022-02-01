using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    class KisiYonetimi
    {
        public void KisiEkle(List<Kisi> KisiListesi)
        {
            Console.WriteLine("Yeni Numara Kaydet");
            Console.WriteLine("Lütfen isim giriniz                          : ");
            string firtName = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz                       : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz              : ");
            string phone = Console.ReadLine();
            Kisi newKisi = new Kisi(firtName, lastName, phone);
            KisiListesi.Add(newKisi);
            Console.WriteLine("Kişi rehbere eklendi.");
        }

        public void KisiSil(List<Kisi> KisiListesi)
        {
            Console.WriteLine("Silmek istediğiniz kişinin adını ve soyadını giriniz: ");
            Console.WriteLine("Lütfen isim giriniz                          : ");
            string firtName = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz                       : ");
            string lastName = Console.ReadLine();
            int count = 0;
            foreach (var item in KisiListesi)
            {
                if (item.Isim == firtName || item.Soyisim == lastName)
                {
                    goto a1;
                }
            }

            a1: if (true)
            {
                Console.WriteLine(firtName + " " + lastName + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                char secim = Convert.ToChar(Console.ReadLine());
                if (secim == 'y')
                {
                    foreach (var item in KisiListesi)
                    {
                        if (item.Isim == firtName || item.Soyisim == lastName)
                        {
                            KisiListesi.Remove(item);
                            Console.WriteLine(item.Isim + " isimli kişi rehberden silinmiştir.");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Silme işlemi sonlandırıldı.");
                }
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int secim2= Convert.ToInt32(Console.ReadLine());
                if (secim2 == 2)
                {
                    KisiSil(KisiListesi);
                }
                else
                {
                    Console.WriteLine("Silme işlemi sonlandırıldı.");
                }

            }
        }

        public void KisiGuncelleme(List<Kisi> kisilistesi)
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ve soyadını giriniz:  ");
            Console.WriteLine("Lütfen isim giriniz                          : ");
            string firtName = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz                       : ");
            string lastName = Console.ReadLine();
            int count = 0;
            foreach (var item in kisilistesi)
            {
                if (item.Isim == firtName || item.Soyisim == lastName)
                {
                    goto a2;
                }
            }

            a2:if (true)
            {
                Console.WriteLine(firtName + " " + lastName + " isimli kişinin numarasını güncellemeyi, onaylıyor musunuz ?(y/n)");
                char choose = Convert.ToChar(Console.ReadLine());
                if (choose == 'y')
                {
                    foreach (var item in kisilistesi)
                    {
                        if (item.Isim == firtName || item.Soyisim == lastName)
                        {
                            Console.WriteLine("Lütfen yeni telefon numarası giriniz: ");
                            string phone = Console.ReadLine();
                            item.Telno = phone;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Güncelleme işlemi sonlandırıldı.");
                }
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 2)
                {
                   KisiGuncelleme(kisilistesi);
                }
                else
                {
                    Console.WriteLine("Güncelleme işlemi sonlandırıldı.");
                }

            }
        }

        public void KisiGoruntele(List<Kisi> kisilistesi)
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("*****************************************");
            foreach (var item in kisilistesi)
            {
                Console.WriteLine("İsim: " + item.Isim);
                Console.WriteLine("Soyisim: " + item.Soyisim);
                Console.WriteLine("Telefon Numarası: " + item.Telno);
                Console.WriteLine("-");
            }
        }

        public void KisiAra(List<Kisi> kisilistesi)
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**************************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("Lütfen isim giriniz                          : ");
                string firtName = Console.ReadLine();
                Console.WriteLine("Lütfen soyisim giriniz                       : ");
                string lastName = Console.ReadLine();
                foreach (var item in kisilistesi)
                {
                    if (item.Isim == firtName || item.Soyisim == lastName)
                    {
                        Console.WriteLine("İsim: " + item.Isim);
                        Console.WriteLine("Soyisim: " + item.Soyisim);
                        Console.WriteLine("Telefon Numarası: " + item.Telno);
                        Console.WriteLine("-");
                    }
                }
            }
            else
            {
                Console.WriteLine("Lütfen telefon numarası giriniz: ");
                string phone = Console.ReadLine();
                foreach (var item in kisilistesi)
                {
                    if (item.Telno == phone)
                    {
                        Console.WriteLine("İsim: " + item.Isim);
                        Console.WriteLine("Soyisim: " + item.Soyisim);
                        Console.WriteLine("Telefon Numarası: " + item.Telno);
                        Console.WriteLine("-");
                    }
                }
            }
        }
    }
}