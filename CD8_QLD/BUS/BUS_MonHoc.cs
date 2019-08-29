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
    public class BUS_MonHoc
    {
        DAL_MonHoc dal = new DAL_MonHoc();

        public DataTable selectdata()
        {
            return dal.selectdata();
        }

        public void insertdata(En_MonHoc en)
        {
            dal.insertdata(en);
        }

        public void updatedata(En_MonHoc en)
        {
            dal.updatedata(en);
        }

        public void deletedata(En_MonHoc en)
        {
            dal.deletedata(en);
        }
    }
}
