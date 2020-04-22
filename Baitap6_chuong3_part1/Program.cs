using System;

namespace Baitap6_chuong3_part1
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            sv.Nhap();
            sv.TinhDiemTB();
            sv.InThongTinSV();
            Console.ReadLine();
        }
    }
}
