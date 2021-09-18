using System;

namespace tipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {

            // Implicit Conversion (Bilinçsiz Dönüşüm)

            byte a = 5;
            sbyte b = 10;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine(d);

            long h = d;
            Console.WriteLine(h);

            float i = h;
            Console.WriteLine(i);

            string e = "Emre";
            char f = 'K';
            object g = e + f + d;
            Console.WriteLine(g);

            //Explicit Conversion (Bilinçli Dönüşüm)

            Console.WriteLine("***Exp Conv***");

            int x = 4;
            int y = (byte)x;
            Console.WriteLine("y: " + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " + t);

            float fl = 10.3f;
            byte tf = (byte)fl;
            Console.WriteLine("tf: " + tf);

            // *** ToString ***

            int xx = 4;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.4f.ToString();
            Console.WriteLine("zz: " + zz);

            Console.WriteLine("*** Parse ***");

            ParseMethod();
        }


        public static void ParseMethod()
        {
            string s1 = "15";
            string s2 = "20";

            int toplam = int.Parse(s1) + int.Parse(s2);
            Console.WriteLine(toplam);
        }
    }
}
