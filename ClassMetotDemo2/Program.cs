using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Yasin";
            musteri1.Soyad = "Gündoğdu";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Engin";
            musteri2.Soyad = "Demiroğ";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "İlker";
            musteri3.Soyad = "Korkmaz";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            Console.WriteLine("-----------------------------Metotlar-----------------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Listele(musteriler);

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);

            


        }
    }
}