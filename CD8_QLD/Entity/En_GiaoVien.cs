using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class En_GiaoVien
    {
        private string _MaGV;
        public string MaGV
        {
            get { return _MaGV; }
            set { _MaGV = value; }
        }

        private string _TenGV;
        public string TenGV
        {
            get { return _TenGV; }
            set { _TenGV = value; }
        }

        private DateTime _NgaySinh;
        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }

        private Int32 _GioiTinh;
        public Int32 GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }

        private string _NoiSinh;
        public string NoiSinh
        {
            get { return _NoiSinh; }
            set { _NoiSinh = value; }
        }

        private string _DiaChi1;
        public string DiaChi1
        {
            get { return _DiaChi1; }
            set { _DiaChi1 = value; }
        }

        private string _DiaChi2;
        public string DiaChi2
        {
            get { return _DiaChi2; }
            set { _DiaChi2 = value; }
        }

        private string _SoDT1;
        public string SoDT1
        {
            get { return _SoDT1; }
            set { _SoDT1 = value; }
        }

        private string _SoDT2;
        public string SoDT2
        {
            get { return _SoDT2; }
            set { _SoDT2 = value; }
        }

        private DateTime _NgayNhanViec;
        public DateTime NgayNhanViec
        {
            get { return _NgayNhanViec; }
            set { _NgayNhanViec = value; }
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
