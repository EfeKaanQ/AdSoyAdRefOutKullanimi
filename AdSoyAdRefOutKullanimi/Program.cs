using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdSoyAdRefOutKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "efe";
            string soyad = "dokumacı";
            int yas = 30;
            AdSoyad adSoyad = new AdSoyad();
            adSoyad.BilgiGuncelle(ref ad, ref soyad, ref yas);

            
            Console.WriteLine("Önceki Değerler:");
            Console.WriteLine("Ad: " + ad);
            Console.WriteLine("Soyad: " + soyad);
            Console.WriteLine("Yaş: " + yas);

         
        }
    }
    class AdSoyad
    {
        public  void BilgiGuncelle(ref string ad, ref string soyad, ref int yas)
        {
             ad = "Nuri";
            soyad = "TIRAŞ";
            yas = 30;
        }
    }
}
