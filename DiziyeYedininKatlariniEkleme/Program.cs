using System;

namespace DiziyeYedininKatlariniEkleme
{
    class Program
    {
        static void Main(string[] args)
        {
            //20 elemanlı bir tam sayı dizisine 7’den itibaren 7’nin katlarını
            //ekleyen ve bu sayıları yan yana ekrana yazdıran void metodu yazın kodunu yazın.

            {
                diziYediKatları();
            }

            static void diziYediKatları()
            {
                int[] dizi = new int[20];
                int sayac = 0;
                while (sayac < 20)
                {
                    dizi[sayac] = 7 * (sayac + 1);
                    Console.Write(dizi[sayac] + " ");
                    //soruda "7'den itibaren ifadesi" var
                    //7, 7'nin birinci katı oldugu için ilk eleman olarak 7*1'i yazdırdım.
                    //soruda yazdırma formatı olarak sadece yanyana diyor.
                    //eger yazdırılan sayılar arasına bir işaret konulması isteniyorsa
                    //ek kodlar yazılması gerekli
                    sayac++;
                }

            }
        }
    }
}

