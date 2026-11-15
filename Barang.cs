using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuisOOP
{
    public class Barang
    {
        public string NamaBarang;
        public int Harga;
        public int Jumlah;
        public int TotalHarga;

        public Barang(string nama, int hargaBarang, int jumlahBarang)
        {
            this.NamaBarang = nama;
            this.Harga = hargaBarang;
            this.Jumlah = jumlahBarang;
        }

        public int HitungTotal()
        {
            return Harga * Jumlah;
        }


        public void TampilkanData()
        {
            Console.WriteLine($"Nama Barang : {NamaBarang}");
            Console.WriteLine($"Harga       : Rp {Harga:N0}");
            Console.WriteLine($"Jumlah      : {Jumlah}");
            Console.WriteLine($"Total Harga : Rp {HitungTotal():N0}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== PROGRAM KASIR SEDERHANA =====");
            Console.Write("Masukkan jumlah jenis barang : ");
            int jumlahJenis = int.Parse(Console.ReadLine());

            Barang[] daftarBarang = new Barang[jumlahJenis];

            int totalSeluruh = 0;

            for (int i = 0; i < daftarBarang.Length; i++)
            {
                Console.WriteLine($"\n===== BARANG KE {i + 1} =====");
                Console.Write("Nama Barang : ");
                string namaInput = Console.ReadLine();
                Console.Write("Harga       : ");
                int hargaInput = int.Parse(Console.ReadLine());
                Console.Write("Jumlah      : ");
                int jumlahInput = int.Parse(Console.ReadLine());

                daftarBarang[i] = new Barang(namaInput, hargaInput, jumlahInput);
                daftarBarang[i].TampilkanData();
                totalSeluruh += daftarBarang[i].HitungTotal();
            }

            Console.WriteLine("\n===== RINCIAN BELANJA =====");

            for (int i = 0; i < daftarBarang.Length; i++)
            {
                Console.WriteLine($"Barang ke-{i + 1}");
                daftarBarang[i].TampilkanData();
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("\n===== STRUK PEMBAYARAN =====");
            Console.WriteLine($"Total Seluruh Pembelian : Rp {totalSeluruh:N0}");

            Console.WriteLine("\nTekan tombol ENTER untuk menutup jendela...");
            Console.ReadLine();
        }
    }
}
