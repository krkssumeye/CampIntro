using System;
using System.Collections.Generic;
using System.Text;

namespace ödev1
{
    class CustemerManager
    {
        public void Ekle(Custemer custemer)
        {
            Console.WriteLine("Musteri eklendi : " + custemer.Name + " " + custemer.surname+""+custemer.CustemerId+ "");
        }

        public void listele(Custemer custemer)
        {
            Console.WriteLine("Musteri listelendi : " + custemer.Name + " " + custemer.surname + "" + custemer.CustemerId+ "");
        }
        public void sil(Custemer custemer)
        {
            Console.WriteLine("Musteri silindi : " + custemer.Name + " " + custemer.surname + "" + custemer.CustemerId+ "");
        }
    }
}
    
