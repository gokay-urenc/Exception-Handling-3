using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_Yonetimleri_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Bir sayı giriniz: ");
                byte sayi = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Tebrikler.");
            }
            catch (Exception hata) // Exception her türlü hata biçimini bularak uygun hatayı verir.
            {
                Console.WriteLine(hata.Message);
            }
            finally // try ve catch kısmında oluşan hata umrunda olmadan çalışan bloktur.
            {
                Console.Write("Deneme");
            }
            Console.ReadKey();
        }
    }
}
