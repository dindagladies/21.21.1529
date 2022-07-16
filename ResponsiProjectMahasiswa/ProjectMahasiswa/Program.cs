using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        Mahasiswa mahasiswa = new Mahasiswa();
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                Console.Write("\n Pilih Menu Aplikasi");
                Console.Write("\n");
                Console.Write("\n 1. Tambah Mahasiswa");
                Console.Write("\n 2. Tampilan Mahasiswa");
                Console.Write("\n 3. Keluar");

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3:
                        System.Environment.Exit(0);
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            Mahasiswa mahasiswa = new Mahasiswa();

            Console.Write("\n NIM : ");
            mahasiswa.NIM = Console.ReadLine();

            Console.Write("\n Nama : ");
            mahasiswa.nama = Console.ReadLine();

            Console.Write("\n Jenis Kelamin [L/P] : ");
            mahasiswa.jenis_kelamin = Console.ReadLine();

            Console.Write("\n IPK : ");
            mahasiswa.IPK = Console.ReadLine();

            daftarMahasiswa.Add(mahasiswa);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("\n Data Mahasiswa");

            int number;
            number = 1;

            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {
                string detailJenisKelamin;

                detailJenisKelamin = (mahasiswa.jenis_kelamin == "P") ? "Perempuan" : ((mahasiswa.jenis_kelamin == "L") ? "Laki-laki" : "Invalid");

                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", number++, mahasiswa.NIM, mahasiswa.nama, detailJenisKelamin, mahasiswa.IPK);
                
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
