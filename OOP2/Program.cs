using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ömer Saldıran
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Ömer";
            musteri1.Soyadi = "Saldıran";
            musteri1.TcNo = "1234568910";

            // Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 1;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12345667899";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri4);


        }
    }
}
