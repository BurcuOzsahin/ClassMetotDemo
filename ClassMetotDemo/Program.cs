using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() {
                Id=5,
                Ad="Burcu",
              Soyad="Özşahin",
            };
            Musteri musteri2 = new Musteri()
            {
                Id = 18,
                Ad = "Engin",
                Soyad = "Demiroğ",
            };
            Musteri musteri3 = new Musteri()
            {
                Id = 20,
                Ad = "Berkay",
                Soyad = "Bilgin",
            };
            Musteri[] musteriListe = new Musteri[] {musteri1,musteri2,musteri3};

            Console.WriteLine("**********************************************************");
            MusteriManager.MusteriEkleme(musteri1);
            MusteriManager.MusteriEkleme(musteri2);
            MusteriManager.MusteriEkleme(musteri3);
            Console.WriteLine("**********************************************************");
            MusteriManager.MusteriListeleme(musteriListe);
            Console.WriteLine("**********************************************************");
            MusteriManager.MusteriSilme(musteri1);
            MusteriManager.MusteriSilme(musteri2);
            MusteriManager.MusteriSilme(musteri3);
            Console.WriteLine("**********************************************************");



        }
      
    }
}
