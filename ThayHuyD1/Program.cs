using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThayHuyD1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
  
           Menu();

        }
        static void Menu()
        {    QLNhanVien qLNhanVien = new QLNhanVien();
            int LuaChon = 0;
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("1. Nhap 1 hoac nhieu nhan vien ");
            Console.WriteLine("2. Xuat danh sach nhan vien");
            Console.WriteLine("3. Xuat ds cac nv co tien luong lon hon so tien ma nguoi dung nhap");
            Console.WriteLine("4. Tim nhan vien theo ma ID");
            Console.WriteLine("0. Thaot");
            Console.WriteLine("Moi ban nhap lua chon");
            Console.WriteLine("-------------------------------------------------------------------");
            LuaChon = int.Parse(Console.ReadLine());
            switch (LuaChon)
            {
                case 1:
                    qLNhanVien.ThemNhanVien();
                    break;
                case 2:
                    qLNhanVien.XuatDsNv();
                    break;
                case 3:
                    Console.WriteLine("So tien nhap la: ");
                    double SoTienNhap = double.Parse(Console.ReadLine());

                    qLNhanVien.ChucNang3(SoTienNhap);
                    break;
                case 4:
                     break;
                 case 5:
                           break;
       }
    }
    }
}
