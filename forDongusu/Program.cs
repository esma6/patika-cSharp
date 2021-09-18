using System;

namespace forDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı Giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayi; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                }
                else if (i % 2 == 0)
                {
                    ciftToplam += i;
                }
            }

            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Çift Toplam: " + ciftToplam);

            // break, continue

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 7)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
