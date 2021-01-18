using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 001;
            musteri1.MusteriAdi = "Ahmet";
            musteri1.MusteriSoyadi = "Yılmaz";
            musteri1.KimlikNo = 11111111111;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 002;
            musteri2.MusteriAdi = "Mustafa";
            musteri2.MusteriSoyadi = "Kale";
            musteri2.KimlikNo = 22222222222;

            Musteri[] musteriListesi = new Musteri[] {musteri1, musteri2 };

            MusteriManager Musterimanager = new MusteriManager();
            Musterimanager.MusteriEkle(musteri1);
            Musterimanager.MusteriSil(musteri2);
            Musterimanager.MusteriListele(musteriListesi);
        }
    }
}
