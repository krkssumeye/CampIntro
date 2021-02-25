using System;

namespace ders2
{
    class Program
    {
        static void Main(string[] args)
        {
           
//tek tek verileri tanımlamak yerine bir array oluşturup istediğimiz kadar veri 
//tanımlayabiliriz.
            string[] kurslar = new string[] {"yazılım kursu","programlama","java" }; //array
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)//dizi yapılı temaları tek te dolaşır.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");

        }
    }
}
