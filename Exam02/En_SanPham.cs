using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangPhuThong_01_3Player
{
    class En_SanPham
    {
        private string _MaHang;
        public string MaHang
        {
            get { return _MaHang; }
            set { _MaHang = value; }
        }

        private string _TenHang;
        public string TenHang
        {
            get { return _TenHang; }
            set { _TenHang = value; }
        }

        private Int64 _SoLuong;
        public Int64 SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        private float _GiaBan;
        public float GiaBan
        {
            get { return _GiaBan; }
            set { _GiaBan = value; }
        }

        private string _MaLoai;
        public string MaLoai
        {
            get { return _MaLoai; }
            set { _MaLoai = value; }
        }
    }
}
