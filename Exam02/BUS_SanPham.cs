using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Add Library
using System.Data;

namespace DangPhuThong_01_3Player
{
    class BUS_SanPham
    {
        DAL_SanPham dal = new DAL_SanPham();

        public DataTable showdata()
        {
            return dal.showdata();
        }

        public DataTable selectdata(string req)
        {
            return dal.selectdata(req);
        }

        public void insertdata(En_SanPham en)
        {
            dal.insertdata(en);
        }

        public void updatedata(En_SanPham en)
        {
            dal.updatedata(en);
        }

        public void deletedata(En_SanPham en)
        {
            dal.deletedata(en);
        }
    }
}
