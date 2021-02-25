using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

 //int,decimal,float,double,bool=değer tip
 // array,class,interface = referaans tip
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[]sayılar= new int[] { 100, 200, 300 };
            sayilar1 = sayılar;
            sayılar[0] = 999;
            // sayila[0] = 999 
//referans tipolduğu için 14. satırda eşitlik sağlarız ve sayılar1 sayıların listesine 
//eşit olur 
//15. satırda ise sayıların 0. indis satısını 999 eşitlediğimiz için sayilar1 inde 0.indis numarsı 999 olur 
        }
    }
}