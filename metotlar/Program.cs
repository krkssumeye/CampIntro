using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] meyveler = new string[] { };
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

          
            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 50;
            urun2.Aciklama = "diyarbakır karpuzu";

            
            Urun urun3 = new Urun();
            urun3.Adi = "kayısı";
            urun3.Fiyati = 30;
            urun3.Aciklama = "malatya kayısı";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------");
            }

            Console.WriteLine("-------------metotlar--------------");
            //instance - örnek

            sepetmanager Sepetmanager = new sepetmanager();
            Sepetmanager.Ekle(urun3);
            Sepetmanager.Ekle(urun2);//farklı sayfalar gibi düşün
            Sepetmanager.Ekle(urun1);
            






        }
    }
}
