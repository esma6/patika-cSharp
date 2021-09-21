using System;

namespace metotOverloading
{
    class Program
    {
        public void EkranaYazdir(int deger)
        {
            Console.WriteLine(deger);
        }

        public void EkranaYazdir(string deger)
        {
            Console.WriteLine(deger);
        }

        public void EkranaYazdir(string deger1, string deger2)
        {
            Console.WriteLine(deger1 + deger2);
        }
        static void Main(string[] args)
        {
            Program instance = new Program();
           instance.EkranaYazdir("Esma");
           instance.EkranaYazdir(1);
           instance.EkranaYazdir("Esma", " Karagülle");
        }
      
    }
}
