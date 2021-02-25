using System;

namespace ders3ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.KursAdi = "C#";
            kurs1.IzlenmeOranı = 10;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.KursAdi = "java";
            kurs2.IzlenmeOranı = 15;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Engin Demiroğ";
            kurs3.KursAdi = "C++";
            kurs3.IzlenmeOranı = 20;

            //Console.WriteLine(kurs1.KursAdi + " ;" + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                // Console.WriteLine(kurs.KursAdi); sadece kursların adını yazar
                Console.WriteLine(kurs.KursAdi + " ;" + kurs.Egitmen+" : " +kurs.IzlenmeOranı);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOranı { get; set; }
    }
}
