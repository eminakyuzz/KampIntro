using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 20;
            urun2.Aciklama = "Kelek karpuz";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------------");

            }

            Console.WriteLine("---------METOTLAR----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);

            sepetManager.Ekle2("Armut", "yeşil", 12,10);
            sepetManager.Ekle2("elma", "kırmızı", 12,8);
            sepetManager.Ekle2("karpuz", "adana", 12,9);
        }
    }
}
