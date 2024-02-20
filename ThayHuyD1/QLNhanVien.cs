using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThayHuyD1
{
    internal class QLNhanVien
    {
        public List<NhanVien> DanhSachNV { get; set; }
        public QLNhanVien()
        {
            DanhSachNV = new List<NhanVien>();
        }

        public void ThemNhanVien()
        {
            int TiepTuc = -1;
            do
            {
                Console.Write("Moi nhap ID: ");
                int ID = int.Parse(Console.ReadLine());
                Console.Write("Moi nhap ten nhan vien: ");
                string Ten = Console.ReadLine();
                Console.WriteLine("Moi nhap luong: ");
                double Luong = double.Parse(Console.ReadLine());
                NhanVien nhanVien = new NhanVien();
                this.DanhSachNV.Add(nhanVien);
                Console.WriteLine("Ban muon  tiep tuc  (1-co/2-khong");
                 TiepTuc = int.Parse(Console.ReadLine());
            } while (TiepTuc == 1);
        }
        public void XuatDsNv()
        {
            foreach(NhanVien nhanVien in DanhSachNV)
            {
                nhanVien.InThongTin();
            }
        }
        public void ChucNang3(double SoTienNhap)
        {
            Console.WriteLine("So tien nhap la: ");
            SoTienNhap = double.Parse(Console.ReadLine());
            foreach(NhanVien nhanVien in DanhSachNV)
            {
                if(nhanVien.GetLuong() > SoTienNhap)
                {
                    nhanVien.InThongTin();
                    Console.WriteLine("");
                }
            }
        }
    }
}
