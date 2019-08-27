using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08
{
    class En_LoaiSanPham
    {
        private string _MaLoai;
        public string MaLoai
        {
            get { return _MaLoai; }
            set { _MaLoai = value; }
        }

        private string _TenLoai;
        public string TenLoai
        {
            get { return _TenLoai; }
            set { _TenLoai = value; }
        }

        private string _MoTa;
        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }
    }
}
