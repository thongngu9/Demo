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
    public class BUS_GiaoVien
    {
        DAL_GiaoVien dal = new DAL_GiaoVien();

        public DataTable selectdata()
        {
            return dal.selectdata();
        }

        public void insertdata(En_GiaoVien en)
        {
            dal.insertdata(en);
        }

        public void updatedata(En_GiaoVien en)
        {
            dal.updatedata(en);
        }

        public void deletedata(En_GiaoVien en)
        {
            dal.deletedata(en);
        }
    }
}
