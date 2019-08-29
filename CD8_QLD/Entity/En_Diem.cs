using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class En_Diem
    {
        private Int32 _id;
        public Int32 id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _MaL;
        public string MaL
        {
            get { return _MaL; }
            set { _MaL = value; }
        }

        private string _MaSV;
        public string MaSV
        {
            get { return _MaSV; }
            set { _MaSV = value; }
        }

        private string _MaMH;
        public string MaMH
        {
            get { return _MaMH; }
            set { _MaMH = value; }
        }

        private string _MaGV;
        public string MaGV
        {
            get { return _MaGV; }
            set { _MaGV = value; }
        }

        private string _MaLD;
        public string MaLD
        {
            get { return _MaLD; }
            set { _MaLD = value; }
        }

        private string _Diem;
        public string Diem
        {
            get { return _Diem; }
            set { _Diem = value; }
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
