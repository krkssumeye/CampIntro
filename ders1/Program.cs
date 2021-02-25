using System;

namespace ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sistemeGirisYapmısMı = true;
            //eğer bool değişkeni false olsaydı else devreye girecekti.

            if (sistemeGirisYapmısMı == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giris yap butonu ");
            }
            double dolarDün = 7.35;
            double dolarBugün = 7.25;
            // doların değişimine göre koşul blokları çalışır.
            if (dolarDün > dolarBugün)
            {
                Console.WriteLine("azalış butonu");

            }
            else if (dolarDün < dolarBugün) 
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
        }
    }
}
