using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4260
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NAMA    : ANNISA DAMAYANTI");
            Console.WriteLine("NIM     : 21.11.4260");
            Console.WriteLine("KELAS   : 21 IF 07");

            Console.WriteLine("\n");

            karyawan karyawan1 = new karyawan(199872111, "MUTYA", 3000000);
            karyawan karyawan2 = new karyawan(196704260, "RAYYAN", 4000000);
            karyawan karyawan3 = new karyawan(190674567, "JULI", -2000000);


            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.NAMA, karyawan1.GajiBulanan);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.NAMA, karyawan2.GajiBulanan);
            Console.WriteLine(" 3. | {0} {1} \t\t | {2}\t\t |", karyawan3.NIK, karyawan3.NAMA, karyawan3.GajiBulanan);

            Console.WriteLine("\n\nAsiiiiikkkkk dapat tambahan gaji 10% nih !!!\n");

            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.NAMA, karyawan1.TambahGaji);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.NAMA, karyawan2.TambahGaji);
            Console.WriteLine(" 3. | {0} {1} \t\t | {2}\t\t |", karyawan3.NIK, karyawan3.NAMA, karyawan3.GajiBulanan);


            Console.ReadKey();
        }
    }

}
