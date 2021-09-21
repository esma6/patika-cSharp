using System;

namespace extensionMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool isEven = MyExtensionClass.IsEventNumber(123);
            Console.WriteLine(isEven);

            int sonuc=MyExtensionClass.FibonacciSerisi(9);
            Console.WriteLine(sonuc);

        }
    }
    public static class MyExtensionClass
    {
        //extansion
        public static bool IsEventNumber(this int value)
        {
            if (value % 2 == 0)
                return true;
            else
                return false;
        }

        //rekürsif
        public static int FibonacciSerisi(int sayi)
        {
            if (sayi == 0)
            {
                return 0;
            }

            else if (sayi == 1)
            {
                return 1;
            }

            else
            {
                return FibonacciSerisi(sayi - 1) + FibonacciSerisi(sayi - 2);
            }

        }

    }


}
