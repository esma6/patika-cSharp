using System;

namespace ArraySinifiMethodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORT,Diziler üzerinden sıralama işlemi yapar. 
            //Eğer string bir dizi ise alfabetik olarak olarak A'dan Z'ye sıralar.
            //Eğer numeric bir dizi ise dizi elemanlarını küçükten büyüğe sıralar.
            int[] sayiDizisi = { 1, 2, 3, 4, 5, 6, };
            Array.Sort(sayiDizisi);

            //CLEAR,Dizinin belirtilen elemanlarını varsayılan değerine getirir. Yani örneğin numeric bir dizi ise 0 olarak setler.
            //Örnek: Aşağıdaki örnek sayi dizisinin 2.indexinden başlayarak 2 tane elemanı temizler.
            Array.Clear(sayiDizisi, 2, 2);

            //REVERSE,Dizinin ortasını belirleyerek elemanlarını aynalar gibi düşünebilirsiniz. Yani dizinin ilk elemanı ile son elemanını yer değiştirir
            Array.Reverse(sayiDizisi);

            //IndexOf,Verilen dizinin verilen elemanının indexini getirir. Eğer dizi içerisinde elemanı bulamazsa -1 döner.
            Array.IndexOf(sayiDizisi, 7);

            //RESIZE,Dizileri yeniden boyutlandırmak için kullanılır.
            int[] sayiDizisi1 = { 1, 3, 4, 9, 8, 7 };
            Array.Resize<int>(ref sayiDizisi1, 12);
            sayiDizisi1[6] = 10;

        }
    }
}
