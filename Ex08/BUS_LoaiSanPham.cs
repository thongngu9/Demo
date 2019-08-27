using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Add Library
using System.Data;

namespace Ex08
{
    class BUS_LoaiSanPham
    {
        DAL_LoaiSanPham dal = new DAL_LoaiSanPham();

        public DataTable showdata()
        {
            return dal.showdata();
        }

        public void insertdata(En_LoaiSanPham en)
        {
            dal.insertdata(en);
        }

        public void updatedata(En_LoaiSanPham en)
        {
            dal.updatedata(en);
        }

        public void deletedata(En_LoaiSanPham en)
        {
            dal.deletedata(en);
        }
    }
}
