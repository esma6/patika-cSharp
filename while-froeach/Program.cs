using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // While
            // 1'den başlayarak console'dan girilen sayı dahil sayıya kadar ort hesaplayıp konsola yazdıran program

            Console.WriteLine("Sayı Giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi1)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi1);

            // A'dan Z'ye kadar tüm harfleri yazdıralım.
            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character);
                character++;
            }


            // Foreach

            string[] cars = { "Toyota", "BMW", "Honda", "Ford" };

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
