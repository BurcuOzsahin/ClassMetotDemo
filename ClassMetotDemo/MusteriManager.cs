using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public static void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" "+ musteri.Soyad+ " sisteme eklenmiştir.");
         
        }

        public static void MusteriListeleme(Musteri[] musteriListesi)
        {
            foreach (Musteri musteri in musteriListesi)
            {
                Console.WriteLine("Id: "+musteri.Id + ", Müşteri Adı: " + musteri.Ad+ ", Müşteri Soyadı: "+musteri.Soyad);

            }

        }

        public static void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Id bilgisi " + musteri.Id + " olan " + musteri.Ad + " " + musteri.Soyad + " sistemden silinmiştir.");

        }

    }
}
