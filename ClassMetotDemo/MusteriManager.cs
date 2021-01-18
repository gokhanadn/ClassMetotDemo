using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Yeni Bir Müşteri EKLENDİ!!");
            Console.WriteLine("Eklenen Müşteri Id: " + musteri.Id + "\n" +
            "Eklenen Müsteri Adı: " + musteri.MusteriAdi + "\n" +
            "Eklenen Müsteri Soyadı: " + musteri.MusteriSoyadi + "\n" +
            "Eklenen Kimlik No.: " + musteri.KimlikNo);
            Console.WriteLine("-------------------");

        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Yeni Bir Müşteri DİLİNDİ!!");
            Console.WriteLine("Silinen Müşteri Id: " + musteri.Id + "\n" +
            "Silinen Müsteri Adı: " + musteri.MusteriAdi + "\n" +
            "Silinen Müsteri Soyadı: " + musteri.MusteriSoyadi + "\n" +
            "Silinen Kimlik No.: " + musteri.KimlikNo);
            Console.WriteLine("-------------------");

        }
        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("----------------------\n");
                Console.WriteLine("Müşteri Id: " + musteri.Id + "\n" +
                "Müsteri Adı: " + musteri.MusteriAdi + "\n" +
                "Müsteri Soyadı: " + musteri.MusteriSoyadi + "\n" +
                "Kimlik No.: " + musteri.KimlikNo);
                Console.WriteLine("-------------------");
            }
        }
    }
}
