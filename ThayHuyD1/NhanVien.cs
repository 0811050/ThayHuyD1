using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThayHuyD1
{
    //Tạo Class NhanVien gồm các thuộc tính: ID – int, Ten – string, Luong– double – InThongTin() :void -
    //(Đối với class Private các thuộc tính, Property, Constructor có tham số và không tham số) - (1 điểm)

    internal class NhanVien
    {
        private   int ID { get; set; }
        private string Ten { get; set; }
        private double  Luong { get; set; }
        public NhanVien()
        {
            
        }

        public NhanVien(int iD, string ten, double luong)
        {
            ID = iD;
            Ten = ten;
            Luong = luong;
        }
        public void InThongTin()
        {

        }
        public double GetLuong()
        {
            return this.Luong;
        }
    }
}
