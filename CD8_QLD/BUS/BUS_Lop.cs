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
    public class BUS_Lop
    {
        DAL_Lop dal = new DAL_Lop();

        public DataTable showdata()
        {
            return dal.showdata();
        }

        public DataTable selectdata()
        {
            return dal.selectdata();
        }

        public void insertdata(En_Lop en)
        {
            dal.insertdata(en);
        }

        public void updatedata(En_Lop en)
        {
            dal.updatedata(en);
        }

        public void deletedata(En_Lop en)
        {
            dal.deletedata(en);
        }
    }
}
