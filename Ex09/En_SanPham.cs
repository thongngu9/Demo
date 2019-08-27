using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09
{
    class En_SanPham
    {
        private string _MaLoai;
        public string MaLoai
        {
            get { return _MaLoai; }
            set { _MaLoai = value; }
        }

        private string _MaSP;
        public string MaSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }

        private string _TenSP;
        public string TenSP
        {
            get { return _TenSP; }
            set { _TenSP = value; }
        }

        private string _DonVi;
        public string DonVi
        {
            get { return _DonVi; }
            set { _DonVi = value; }
        }

        private float _DonGia;
        public float DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }

        private Int64 _SoTon;
        public Int64 SoTon
        {
            get { return _SoTon; }
            set { _SoTon = value; }
        }
    }
}
