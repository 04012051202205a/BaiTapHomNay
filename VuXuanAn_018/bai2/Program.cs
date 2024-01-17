using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class ChuNhat
    {
        private double rong;
        private double dai;

        public ChuNhat(double x, double y)
        {
            this.rong = x;
            this.dai = y;
        }

        public double TinhChuVi()
        {
            return 2 * (rong + dai);
        }

        public double TinhDienTich()
        {
            return rong * dai;
        }

        public void XuatThongTin()
        {
            Console.WriteLine("Chieu rong: {0}", rong);
            Console.WriteLine("Chieu dai: {0}", dai);
            Console.WriteLine("Chu vi: {0}", TinhChuVi());
            Console.WriteLine("Dien tich: {0}", TinhDienTich());
        }

    }
    class Vuong : ChuNhat
    {
        public Vuong(double canh) : base(canh, canh)
        {
        }

        public void Xuat()
        {

            Console.WriteLine("Chu vi: {0}", TinhChuVi());
            Console.WriteLine("Dien tich: {0}", TinhDienTich());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap hinh chu nhat thu 1:");
            Console.Write("Nhap chieu rong: ");
            double rong1 = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu dai: ");
            double dai1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nNhap hinh chu nhat thu 2:");
            Console.Write("Nhap chieu rong: ");
            double rong2 = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu dai: ");
            double dai2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nNhap hinh vuong:");
            Console.Write("Nhap canh: ");
            double canh = double.Parse(Console.ReadLine());

            ChuNhat cn1 = new ChuNhat(rong1, dai1);
            ChuNhat cn2 = new ChuNhat(rong2, dai2);
            Vuong v = new Vuong(canh);

            Console.WriteLine("\nThong tin hinh chu nhat thu 1:");
            cn1.XuatThongTin();

            Console.WriteLine("\nThong tin hinh chu nhat thu 2:");
            cn2.XuatThongTin();

            Console.WriteLine("\nThong tin hinh vuong:");
            v.Xuat();
            Console.ReadLine()
;
        }
    }
}