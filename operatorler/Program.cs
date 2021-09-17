using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve İşlemli Atama

            int x = 4;
            int y = 4;
            y += 2;
            Console.WriteLine("y: " + y);
            x /= 2;
            Console.WriteLine("x: " + x);

            //Mantıksal Operatörler

            bool isSuccess = true;
            bool isComplete = true;

            if (isSuccess && isComplete)
            {
                Console.WriteLine("Perfect");
            }
            else if (isSuccess || isComplete)
            {
                Console.WriteLine("Great");
            }
            else if (isSuccess && !isComplete)
            {
                Console.WriteLine("Fine");
            }

            //İlişkisel Operatörler

            int a = 3;
            int b = 4;
            bool sonuc = a < b;

            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            // Aritmetik Operatörler

            int s1 = 18;
            int s2 = 5;
            int sonuc1 = s1 / s2;
            Console.WriteLine(sonuc1);
            sonuc1 = s1 + s2;
            Console.WriteLine(sonuc1);
            sonuc1 = s1 * s2;
            Console.WriteLine(sonuc1);
            sonuc1 = s1 - s2;
            Console.WriteLine(sonuc1);
            sonuc1 = s1 % s2;
            Console.WriteLine(sonuc1);
        }
    }
}
