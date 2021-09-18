using System;

namespace tryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir Sayı Giriniz: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayı: " + sayi1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı!");
            }


        }
    }
}
