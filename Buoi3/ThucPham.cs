using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class ThucPham
    {
        private string maHang;
        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }

        private string tenHang;
        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }

        private float donGia;
        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        private DateTime ngaySX;
        public DateTime NgaySX
        {
            get { return ngaySX; }
            set { ngaySX = value; }
        }

        private DateTime ngayHH;
        public DateTime NgayHH
        {
            get { return ngayHH; }
            set { ngayHH = value; }
        }

        public ThucPham()
        {
            MaHang = "001";
            TenHang = "Do An";
            DonGia = 10000;
            NgaySX = DateTime.Parse("10/12/2022");
            NgayHH = DateTime.Now;
        }
        public void Input()
        {
            Console.Write("Ma : ");
            MaHang = Console.ReadLine();
            Console.Write("Ten : ");
            TenHang = Console.ReadLine();
            Console.Write("Don gia : ");
            DonGia = float.Parse(Console.ReadLine());
            Console.Write("Ngay san xuat Example ('12/03/2015') : ");
            NgaySX = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ngay het han  : ");
        }
        public void Show()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Ma : " + MaHang);
            Console.WriteLine("Ten : " + TenHang);
            Console.WriteLine("Don gia : " + DonGia);
            Console.WriteLine("Ngay san xuat : " + NgaySX.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngay het han : " + NgayHH.ToString("dd/MM/yyyy"));
        }  

    }

    class Program
    {
        static void Main(string[] args)
        {
            ThucPham a = new ThucPham();
            a.Input();
            a.Show();
            Console.ReadKey();
        }
    }
}
