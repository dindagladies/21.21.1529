using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman1529
{
    public class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public void InfoKaryawan()
        {
            if (GajiBulanan < 1)
            {
                Console.WriteLine("Gaji Bulanan  = 0");
            }
            else
            {
                Console.WriteLine("No NIK/Nama              Gaji Bulanan");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. {0} - {1}             Rp.{2:#,0}", Nik, Nama, GajiBulanan);
                NaikGaji();
            }
        }

        public void NaikGaji()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Yey naik gaji 10%");
            Console.WriteLine("");
            
            int bonus = (GajiBulanan / 100) * 10;
            int amount = bonus + GajiBulanan;
            Console.WriteLine("No NIK/Nama              Gaji Bulanan");
            Console.WriteLine("=======================================");
            Console.WriteLine("1. {0} - {1}             Rp.{2:#,0}", Nik, Nama, amount);
        }
    }
}
