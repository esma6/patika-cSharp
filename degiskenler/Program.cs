using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5; //1 byte
            sbyte sb = 5; //1 byte

            short s = 5; //2 byte
            ushort us = 5; //2 byte

            Int16 i16 = 2;  //2 byte
            int i = 2;      //2 byte
            Int32 i32 = 2;  //4 byte
            Int64 i64 = 2;  //8 byte

            uint ui = 2;
            long l = 4;
            ulong ul = 4;

            float f = 5;
            double dbl = 4;
            decimal de = 8;

            char c = '2';  //2 byte
            string str = "Zikriye"; //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

            object o1 = "x";
            object o2 = 'x';
            object o3 = 2;
            object o4 = 4.4;

            //String İfadeler

            string str1 = string.Empty;
            str1 = "deneme";



            string strr = "20";
            int deger = 20;

            int toplam = deger + int.Parse(strr);
            Console.WriteLine("strr ve deger toplamı: " + toplam);
        }
    }
}
