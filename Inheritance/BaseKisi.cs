using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public BaseKisi(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }

        public void KisiBilgileri()
        {
            Console.WriteLine("Adı: " + Ad + "\nSoyad: " + Soyad);
        }
    }

    public class Ogretmen : BaseKisi
    {
        public decimal Maas { get; set; }

        public Ogretmen(string ad, string soyad, decimal maas) : base(ad, soyad)
        {
            Maas = maas;
        }

        public void MaasBilgisi()
        {
            Console.WriteLine("\nÖğretmenin maaşı: " + Maas);
            KisiBilgileri();
        }
    }

    public class Ogrenci : BaseKisi
    {
        public int OgrenciNo { get; set; }

        public Ogrenci(string ad, string soyad, int ogrenciNo) : base(ad, soyad)
        {
            OgrenciNo = ogrenciNo;
        }

        public void OgrenciNoBilgisi()
        {
            Console.WriteLine("\nÖğrenci numarası: " + OgrenciNo);
            KisiBilgileri();
        }
    }
}
