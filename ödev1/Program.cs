using System;

namespace ödev1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] custemer = new string[] { };

            Custemer custemer1 = new Custemer();
            custemer1.CustemerId = 5874 ;
            custemer1.Name = "Sümeyye";
            custemer1.surname = "Karakaş";

            Custemer custemer2 = new Custemer();
            custemer2.CustemerId = 5875 ;
            custemer2.Name = " Beyza ";
            custemer2.surname = " Alışık";

            Custemer custemer3 = new Custemer();
            custemer3.CustemerId = 5876 ;
            custemer3.Name = " Ahmet ";
            custemer3.surname = " Batman ";

            Custemer custemer4 = new Custemer();
            custemer4.CustemerId = 5877 ;
            custemer4.Name = " Burak ";
            custemer4.surname = " Emir ";

            CustemerManager custemermanager = new CustemerManager();

            custemermanager.Ekle(custemer2);
            custemermanager.sil(custemer4);
            custemermanager.listele(custemer3);
            custemermanager.Ekle(custemer1);
            Console.WriteLine("-----------------");



        }
    }
}
