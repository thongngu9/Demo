using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class En_MonHoc
    {
        private string _MaMH;
        public string MaMH
        {
            get { return _MaMH; }
            set { _MaMH = value; }
        }

        private string _TenMH;
        public string TenMH
        {
            get { return _TenMH; }
            set { _TenMH = value; }
        }

        private Int32 _SoTC;
        public Int32 SoTC
        {
            get { return _SoTC; }
            set { _SoTC = value; }
        }

        private float _BieuPhi;
        public float BieuPhi
        {
            get { return _BieuPhi; }
            set { _BieuPhi = value; }
        }

        private string _DonVi;
        public string DonVi
        {
            get { return _DonVi; }
            set { _DonVi = value; }
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
