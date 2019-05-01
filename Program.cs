using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan kry1 = new karyawan();

            kry1.Nama = "Indra";
            kry1.Nik = "1811";
            kry1.GajiBulanan = 3000000;

            karyawan kry2 = new karyawan();

            kry2.Nama = "Bagus";
            kry2.Nik = "2268";
            kry2.GajiBulanan = 2000000;

            Console.WriteLine("no.\tNik/Nama\t\tGajiBulanan");
            Console.WriteLine("============================");
            Console.WriteLine("1.\t{0}  {1}\t\t{2}", kry1.Nik, kry1.Nama, kry1.GajiBulanan);
            Console.WriteLine("2.\t{0}  {1}\t\t{2}", kry2.Nik, kry2.Nama, kry2.GajiBulanan);

            Console.WriteLine("\n\n");
            Console.WriteLine("Gaji Naik 10%");
            Console.WriteLine("\n");
            Console.WriteLine("no.\tNik/Nama\t\tGajiBulanan");
            Console.WriteLine("=============================");
            Console.WriteLine("1.\t{0}  {1}\t\t{2}", kry1.Nik, kry1.Nama, kry1.GajiBulanan + (kry1.GajiBulanan * 0.10));
            Console.WriteLine("2.\t{0}  {1}\t\t{2}", kry2.Nik, kry2.Nama, kry2.GajiBulanan + (kry2.GajiBulanan * 0.10));
            Console.ReadKey();
        }
    }
}
