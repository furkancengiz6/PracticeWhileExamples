using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWhileExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;

            while (sayac < 10)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
                sayac++;
            }
            Console.WriteLine("---------------------------------------------------------------------------");

            int sayac2 = 2;

            while (sayac2 < 20) 
            {

                Console.WriteLine($"1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.{sayac2}");
                sayac2++;
            
            }
            Console.WriteLine("---------------------------------------------------------------------------");

            int sayaç3 = 1;


            while (sayaç3 <=20)
            {
                if
                (sayaç3 % 2 == 0)
                {
                    Console.WriteLine($"{sayaç3} çift sayıdır.");
                }
                else
                {
                    Console.WriteLine($"{sayaç3} tek sayıdır.");
                }
                Console.WriteLine($"{sayaç3}");
                sayaç3++;
            }

            Console.WriteLine("---------------------------------------------------------------------------");

            int sayac4 = 50;
            while (sayac4 <= 150)
            {
                int sum = 0;
                sum += sayac4;
                sayac4++;
                Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı:{sum}");
            }
            Console.WriteLine("---------------------------------------------------------------------------");

            int sayac5 = 1;
            int tekSayi = 0;
            int ciftSayi = 0;
            while (sayac5 <= 120)
            {

                if (sayac5 % 2 == 0)
                {
                    ciftSayi += sayac5;
                }
                else  
                {
                    tekSayi += sayac5;
                }
               
                sayac5++;

            }

            Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı:{ciftSayi}");
            Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı:{tekSayi}");








        }
    }
}
