using System;

namespace Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            Arac arac1 =new Arac();
            arac1.Id = 1;
            arac1.Marka = "Opel";
            arac1.Model = "Astra";

            AracManager aracManager = new AracManager();
            aracManager.aracBilgileri(arac1);
        }
    }
}
