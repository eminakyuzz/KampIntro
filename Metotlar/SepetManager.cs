using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : "+ urun.Adi +" "+urun.StokAdedi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }
    }
}
