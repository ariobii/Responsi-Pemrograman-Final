using System;
using System.Collections.Generic;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Customer");
            Console.WriteLine("2. Hapus Customer");
            Console.WriteLine("3. Tampilkan Customer");
            Console.WriteLine("4. Keluar\n");
        }

        static void TambahCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Customer customerBaru = new Customer();
            Console.WriteLine("Tambah Data Customer\n");

            Console.Write("Kode Customer : ");
            customerBaru.Kode = Console.ReadLine();

            int index = daftarCustomer.FindIndex(customer => customer.Kode == customerBaru.Kode);
            if(index == -1)
            {
                Console.Write("Nama Customer : ");
                customerBaru.Nama = Console.ReadLine();
                Console.Write("Total Piutang : ");
                customerBaru.Piutang = Console.ReadLine();

                daftarCustomer.Add(customerBaru);
            }
            else
            {
                Console.WriteLine("Kode sudah terdaftar!!");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Hapus Data Customer\n");

            Console.Write("Kode Customer : ");
            string kode = Console.ReadLine();

            int index = daftarCustomer.FindIndex(customer => customer.Kode == kode);
            if (index == -1)
            {
                Console.WriteLine("Kode Customer tidak ditemukan!");
            }
            else
            {
                daftarCustomer.RemoveAt(index);
                Console.WriteLine("Data Customer berhasil dihapus!");                
            }
            

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();

            // TODO: tuliskan logika Anda di sini ...
            Console.WriteLine("Data Customer\n");
            int nomer = 1;
            foreach(Customer customer in daftarCustomer)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}", nomer, customer.Kode, customer.Nama, customer.Piutang);
                nomer++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
