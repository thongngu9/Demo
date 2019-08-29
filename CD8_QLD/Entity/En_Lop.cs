using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class En_Lop
    {
        private string _MaL;
        public string MaL
        {
            get { return _MaL; }
            set { _MaL = value; }
        }

        private string _TenL;
        public string TenL
        {
            get { return _TenL; }
            set { _TenL = value; }
        }

        private string _NienKhoa;
        public string NienKhoa
        {
            get { return _NienKhoa; }
            set { _NienKhoa = value; }
        }

        private string _MaGV;
        public string MaGV
        {
            get { return _MaGV; }
            set { _MaGV = value; }
        }

        private Int32 _TrangThai;
        public Int32 TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

        private DateTime _NgayTao;
        public DateTime NgayTao
        {
            get { return _NgayTao; }
            set { _NgayTao = value; }
        }

        private DateTime _NgayCapNhat;
        public DateTime NgayCapNhat
        {
            get { return _NgayCapNhat; }
            set { _NgayCapNhat = value; }
        }
    }
}
