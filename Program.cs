////////using System;
////////using System.Collections.Generic;
////////using System.Linq;
////////using System.Text;
////////using System.Threading.Tasks;

////////namespace KuisGabungan
////////{
////////    internal class Program
////////    {
////////        internal class Barang
////////        {
////////            public string namaBarang;
////////            public int harga;
////////            public int jumlah;
////////            public int totalHarga;


////////            public Barang(string namaBarangA, int hargaA, int jumlahA)
////////            {
////////                this.namaBarang = namaBarangA;
////////                this.harga = hargaA;
////////                this.jumlah = jumlahA;
////////                this.totalHarga = HitungTotal();   
////////            }

////////            public int HitungTotal()
////////            {
////////                return harga * jumlah;
////////            }

////////            public void TampilkanData()
////////            {
////////                Console.WriteLine($"Nama Barang : {namaBarang}");
////////                Console.WriteLine($"Harga       : Rp {harga:N0}");
////////                Console.WriteLine($"Jumlah      : {jumlah}");
////////                Console.WriteLine($"Total Harga : Rp {totalHarga:N0}");
////////            }
////////        }


////////        static void Main(string[] args)
////////        {
////////            Console.Write("Masukkan jumlah jenis barang : ");
////////            int jumlah = int.Parse(Console.ReadLine());
////////            Barang[] daftarBarang = new Barang[jumlah];

////////            for (int i = 0; i < daftarBarang.Length; i++)
////////            {
////////                Console.WriteLine($"====== BARANG KE-{i + 1} ======");
////////                Console.Write("Nama Barang   : ");
////////                string barangInput = Console.ReadLine();
////////                Console.Write("Harga         : ");
////////                int hargaInput = int.Parse(Console.ReadLine());
////////                Console.Write("Jumlah        : ");
////////                int jumlahInput = int.Parse(Console.ReadLine());

////////                daftarBarang[i] = new Barang(barangInput, hargaInput, jumlahInput);

////////                Console.WriteLine($"Total Harga   : Rp {daftarBarang[i].totalHarga}");
////////                Console.WriteLine();
////////            }

////////            Console.WriteLine();

////////            int totalSemua = 0;

////////            for (int i = 0; i < daftarBarang.Length; i++)
////////            {
////////                Console.WriteLine($"Barang ke-{i + 1}");
////////                daftarBarang[i].TampilkanData();
////////                Console.WriteLine("----------------------------------");

////////                totalSemua += daftarBarang[i].totalHarga;
////////            }

////////            Console.WriteLine($"Total seluruh barang : Rp {totalSemua:N0}");

////////            Console.ReadKey();
////////        }
////////    }
////////}


//////using System;
//////using System.Collections.Generic;
//////using System.Linq;
//////using System.Text;
//////using System.Threading.Tasks;

//////namespace KuisOOP
//////{
//////    public class Barang
//////    {
//////        public string NamaBarang;
//////        public int Harga;
//////        public int Jumlah;
//////        public int TotalHarga;

//////        public Barang(string nama, int hargaBarang, int jumlahBarang)
//////        {
//////            this.NamaBarang = nama;
//////            this.Harga = hargaBarang;
//////            this.Jumlah = jumlahBarang;
//////        }

//////        public int HitungTotal()
//////        {
//////            return Harga * Jumlah;
//////        }


//////        public void TampilkanData()
//////        {
//////            Console.WriteLine($"Nama Barang : {NamaBarang}");
//////            Console.WriteLine($"Harga       : {Harga}");
//////            Console.WriteLine($"Jumlah      : {Jumlah}");
//////            Console.WriteLine($"Total Harga : Rp{HitungTotal()}");
//////        }


//////    }
//////    internal class Program
//////    {
//////        static void Main(string[] args)
//////        {
//////            int TotalSeluruh = 0;
//////            Console.WriteLine("===== PROGRAM KASIR SEDERHANA =====");
//////            Console.Write("Masukkan jumlah jenis barang : ");
//////            int jumlahJenis = int.Parse(Console.ReadLine());

//////            for (int i = 0; i < jumlahJenis; i++)
//////            {
//////                Console.WriteLine($"===== BARANG KE {i + 1}");
//////                Console.Write("Nama Barang : ");
//////                string NamaBarang = Console.ReadLine();
//////                Console.Write("Harga       : ");
//////                int Harga = int.Parse(Console.ReadLine());
//////                Console.Write("Jumlah      : ");
//////                int Jumlah = int.Parse(Console.ReadLine());

//////                Barang barang = new Barang(NamaBarang, Harga, Jumlah);
//////                barang.TampilkanData();
//////                TotalSeluruh += barang.HitungTotal();
//////            }

//////            Console.WriteLine("===== STRUK PEMBAYARAN =====");
//////            Console.Write($"Total Seluruh Pembelian : Rp{TotalSeluruh}");

//////            Console.ReadKey();
//////        }
//////    }
//////}


////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace KuisOOP
////{
////    public class Barang
////    {
////        public string NamaBarang;
////        public int Harga;
////        public int Jumlah;
////        public int TotalHarga;

////        public Barang(string nama, int hargaBarang, int jumlahBarang)
////        {
////            this.NamaBarang = nama;
////            this.Harga = hargaBarang;
////            this.Jumlah = jumlahBarang;
////        }

////        public int HitungTotal()
////        {
////            return Harga * Jumlah;
////        }


////        public void TampilkanData()
////        {
////            Console.WriteLine($"Nama Barang : {NamaBarang}");
////            Console.WriteLine($"Harga       : Rp {Harga:N0}");
////            Console.WriteLine($"Jumlah      : {Jumlah}");
////            Console.WriteLine($"Total Harga : Rp {HitungTotal():N0}");
////        }
////    }

////    internal class Program
////    {
////        static void Main(string[] args)
////        {
////            Console.WriteLine("===== PROGRAM KASIR SEDERHANA =====");
////            Console.Write("Masukkan jumlah jenis barang : ");
////            int jumlahJenis = int.Parse(Console.ReadLine());

////            Barang[] daftarBarang = new Barang[jumlahJenis];

////            int totalSeluruh = 0;   

////            for (int i = 0; i < daftarBarang.Length; i++)
////            {
////                Console.WriteLine($"\n===== BARANG KE {i + 1} =====");
////                Console.Write("Nama Barang : ");
////                string namaInput = Console.ReadLine();
////                Console.Write("Harga       : ");
////                int hargaInput = int.Parse(Console.ReadLine());
////                Console.Write("Jumlah      : ");
////                int jumlahInput = int.Parse(Console.ReadLine());

////                daftarBarang[i] = new Barang(namaInput, hargaInput, jumlahInput);
////                daftarBarang[i].TampilkanData();
////                totalSeluruh += daftarBarang[i].HitungTotal();
////            }

////            Console.WriteLine("\n===== RINCIAN BELANJA =====");

////            for (int i = 0; i < daftarBarang.Length; i++)
////            {
////                Console.WriteLine($"Barang ke-{i + 1}");
////                daftarBarang[i].TampilkanData();
////                Console.WriteLine("----------------------------------");
////            }

////            Console.WriteLine("\n===== STRUK PEMBAYARAN =====");
////            Console.WriteLine($"Total Seluruh Pembelian : Rp {totalSeluruh:N0}");

////            Console.WriteLine("\nTekan tombol ENTER untuk menutup jendela...");
////            Console.ReadLine();
////        }
////    }
////}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace KuisGabungan
//{
//    internal class Program
//    {
//        //internal class Barang
//        //{

//        public string namaBarang;
//        public int harga;
//        public int jumlah;
//        public int totalHarga;


//        public Program(string namaBarangA, int hargaA, int jumlahA, int TotalHargaA)
//        {
//            this.namaBarang = namaBarangA;
//            this.harga = hargaA;
//            this.jumlah = jumlahA;
//            this.totalHarga = TotalHargaA;
//        }

//        public int HitungTotal()
//        {
//            return harga * jumlah;
//        }

//        public void TamppilkanData()
//        {
//            Console.WriteLine($"Nama Barang :{namaBarang}");
//            Console.WriteLine($" Harga      :{harga}");
//            Console.WriteLine($"Jumlah       :{jumlah}");
//            Console.WriteLine($"Total Harga :{totalHarga}");
//        }


//        static void Main(string[] args)
//        {

//            Console.Write("Masukkan jumlah jenis barang :");
//            int jumlah = int.Parse(Console.ReadLine());
//            Program[] daftarProgram = new Program[jumlah];
//            for (int i = 0; i < daftarProgram.Length; i++)
//            {
//                Console.WriteLine($"====== BARANG KE{i + 1} ======");
//                Console.Write("Nama Barang   :");
//                string barangInput = Console.ReadLine();
//                Console.Write("Harga         :");
//                int hargaInput = int.Parse(Console.ReadLine());
//                Console.Write("Jumlah        :");
//                int jumlahInput = int.Parse(Console.ReadLine());
//                //Console.WriteLine("Total Harga   :");
//                //int totalInput = int.Parse(Console.ReadLine());
//                daftarProgram[i].TamppilkanData();

//            }
//            //int totalSemua = 0;
//            for (int i = 0; i < daftarProgram.Length; i++)
//            {
//                Console.WriteLine($"Barang ke-{i + 1}");
//                daftarProgram[i].TamppilkanData();

//                double totalBarang = daftarProgram[i].HitungTotal();
//                Console.WriteLine($"Total Nilai : Rp {totalBarang:N0}");
//                Console.WriteLine("----------------------------------");

//                //totalSemua += ;   
//            }


//            //daftarProgram[i] = new Program(string barangInput, hargaInput,)
//            Console.ReadKey();

//            //}
//        }
//    }
//}