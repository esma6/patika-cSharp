using System;
using System.Collections.Generic;
using System.Text;

namespace odev1
{
    //Odev1 ikinci soru
    //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
    //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
    //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
    class ikinciSoru
    {
        static void Main(string[] args)
        {
            Console.Write("Pozitif iki sayi giriniz ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} adet sayi giriniz", n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}.Sayıyı Giriniz;", i + 1);
                int sayi = Convert.ToInt32(Console.ReadLine());
                if ((sayi == m) || (sayi % m == 0))
                {

                    Console.WriteLine("Tam bölünüyor " + sayi);
                }
            }
        }
    }
}
