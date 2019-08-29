using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Add Library
using System.Data;
using DAL;
using Entity;

namespace BUS
{
    public class BUS_SinhVien
    {
        DAL_SinhVien dal = new DAL_SinhVien();

        public DataTable showdata()
        {
            return dal.showdata();
        }

        public DataTable selectdata()
        {
            return dal.selectdata();
        }

        public void insertdata(En_SinhVien en)
        {
            dal.insertdata(en);
        }

        public void updatedata(En_SinhVien en)
        {
            dal.updatedata(en);
        }

        public void deletedata(En_SinhVien en)
        {
            dal.deletedata(en);
        }
    }
}
