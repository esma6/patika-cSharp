using System;

namespace metotTanımlama
{
    class Program
    {
        static void Main(string[] args)
        {
            //erişim_belirteci geri_donus_tipi metot_adi(argüman / parametre) 
            //{
            //    //komutlar;
            //}

            //ref
            int x = 3;
            int y = 4;
            int sonuc = ArttırVeTopla(ref x, ref y);
            Console.WriteLine(sonuc);

            int ArttırVeTopla(ref int x, ref int y)
            {
                x += 1;
                y += y;
                return (x + y);
            }
            
        }
    }
}
