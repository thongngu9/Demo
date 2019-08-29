using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class En_LoaiDiem
    {
        private string _MaLD;
        public string MaLD
        {
            get { return _MaLD; }
            set { _MaLD = value; }
        }

        private string _TenLD;
        public string TenLD
        {
            get { return _TenLD; }
            set { _TenLD = value; }
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
