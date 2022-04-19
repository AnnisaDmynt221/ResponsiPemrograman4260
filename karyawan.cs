using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4260
{
    class karyawan
    {
        public int NIK { get; set; }
        public string NAMA { get; set; }
        public int GajiBulanan { get; set; }
        public int TambahGaji { get; set; }

        public karyawan(int nik, string nama, int gajibulanan)
        {
            this.NIK = nik;
            this.NAMA = nama;

            if (gajibulanan < 0)
            {
                this.GajiBulanan = 0;
                TambahGaji = Convert.ToInt32((GajiBulanan * 1.1));
            }
            else
            {
                this.GajiBulanan = gajibulanan;
                TambahGaji = Convert.ToInt32((GajiBulanan * 1.1));
            }
        }
    }
}
