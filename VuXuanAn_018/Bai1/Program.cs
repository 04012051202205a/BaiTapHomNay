using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class NhanVien
    {
        private string hoten;
        private double songaycong;
        private double songaylamthem;
        private string xeploai;
        private string bophan;
        public NhanVien()
        { }
        public NhanVien(string hoten, double songaycong, double songaylamthem, string xeploai, string bophan)
        {
            this.hoten = hoten;
            this.songaycong = songaycong;
            this.songaylamthem = songaylamthem;
            this.xeploai = xeploai;
            this.bophan = bophan;

        }
        public string HoTen
        {
            get { return HoTen; }
            set { hoten = value; }

        }
        public double SoNgayCong
        {
            get { return songaycong; }
            set { songaycong = value; }
        }
        public double SoNgayLamThem
        {
            get { return songaylamthem; }
            set { songaylamthem = value; }
        }
        public string XepLoai
        {
            get { return xeploai; }
            set { xeploai = value; }
        }
        public string Bophan
        {
            get { return bophan; }
            set { bophan = value; }

        }
        public double TinhLuong()
        {
            double tangPercent = (bophan == "TrucTiep") ? 3.0 : (bophan == "GianTiep") ? 2.0 : 0.0;
            double luongNgay = 100000;
            return (SoNgayCong + SoNgayLamThem * (tangPercent / 100)) * luongNgay;
        }
        public double TinhThuNhap()
        {
            if (XepLoai == "A")
                return 1.5 * TinhLuong();
            else if (XepLoai == "B")
                return 1.2 * TinhLuong();
            else if (XepLoai == "C")
                return TinhLuong();
            else
                return 0.0;
        }
        public void InThongTin()
        {
            Console.WriteLine("Ho Ten: {0}", HoTen);
            Console.WriteLine("Bo Phan: {0}", bophan);
            Console.WriteLine("Thu Nhap: {0}", TinhThuNhap());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien nv1 = new NhanVien();
            Console.Write("Nhap Ho Ten: ");
            nv1.HoTen = Console.ReadLine();
            Console.Write("Nhap So Ngay Cong: ");
            nv1.SoNgayCong = int.Parse(Console.ReadLine());
            Console.Write("Nhap So Ngay Lam Them: ");
            nv1.SoNgayLamThem = int.Parse(Console.ReadLine());
            Console.Write("Nhap Xep Loai (A/B/C): ");
            nv1.XepLoai = Console.ReadLine();
            Console.Write("Nhap Bo Phan (TrucTiep/GianTiep): ");
            nv1.Bophan = Console.ReadLine();
            nv1.InThongTin();
            NhanVien nv2 = new NhanVien("Nguyen Van B", 25, 5, "B", "GianTiep");
            nv2.InThongTin();
            Console.ReadLine();


        }
    }
}