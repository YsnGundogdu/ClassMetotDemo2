using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Hoşgeldin " + musteri.Ad + " başarıyla eklendin.\n");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("---------------------------------------------------------------------------------\n");
                Console.WriteLine("Id: " + musteri.Id + "\nAd: " + musteri.Ad + "\nSoyad: " + musteri.Soyad);
                Console.WriteLine("---------------------------------------------------------------------------------");
            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " nolu ID'ye sahip müşteri silindi.");
        }
    }
}