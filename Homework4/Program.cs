using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {   // *** maas hesaplama *** 
            //Console.WriteLine("Lütfen maasinizi giriniz : ");
            //double maasInput = Convert.ToDouble(Console.ReadLine());
            //double netMaas = MaasHesapla(maasInput);
            //Console.WriteLine("Net maasiniz : " + netMaas);

            // *** Ortalama Hesaplama ***
            Console.WriteLine("Lütfen vize 1 notunuzu girin : ");
            double vize1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen vize 2 notunuzu girin  :");
            double vize2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen final notunuzu girin  :");
            double final = Convert.ToDouble(Console.ReadLine());
            double ort = (vize1 * 0.2) + (vize2 * 0.3) + (final*0.5);
            OrtHesapla(vize1,vize2,final,ort);

            Console.Read();
        }
        static double MaasHesapla(double maas)
        {
            double vergiDusulecekMiktar = maas * 0.1;

            if (vergiDusulecekMiktar >= 1200)
            {
                maas = maas - 1000;
                return maas;
            }
            else
            {
                return maas;
            }
            
        }
        static void OrtHesapla(double vize1, double vize2, double final, double ort)
        {
            if (ort < 0 || ort > 100)
            {
                Console.WriteLine("Lütfen 0 - 100 arasi bir not giriniz ");
            }
            else if (ort > 0 && ort < 45)
            {
                Console.WriteLine("Kaldınız, ortalamanız : " + ort);
            }
            else if (ort >= 45 && ort < 55)
            {
                Console.WriteLine("Gectiniz, ortalamaniz :  " + ort);
            }
            else if (ort >= 55 && ort < 70)
            {
                Console.WriteLine("Orta , ortalamanız : " + ort);
            }
            else if (ort >= 70 && ort <= 85)
            {
                Console.WriteLine("İyi, ortalamanız : " + ort);
            }
            else if (ort >= 85 && ort < 100)
            {
                Console.WriteLine("Cok iyi, ortalamaniz : " + ort);
            }
            else if(ort == 100)
            {
                Console.WriteLine("Tam not aldiniz, ortalamaniz : " + ort);
            }
        }
    }
}
