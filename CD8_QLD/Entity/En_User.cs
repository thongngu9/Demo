using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class En_User
    {
        private string _HoTen;
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }

        private string _TaiKhoan;
        public string TaiKhoan
        {
            get { return _TaiKhoan; }
            set { _TaiKhoan = value; }
        }

        private string _Pass_Word;
        public string Pass_Word
        {
            get { return _Pass_Word; }
            set { _Pass_Word = value; }
        }

        private string _Quyen;
        public string Quyen
        {
            get { return _Quyen; }
            set { _Quyen = value; }
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
