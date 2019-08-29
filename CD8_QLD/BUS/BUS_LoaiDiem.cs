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
    public class BUS_LoaiDiem
    {
        DAL_LoaiDiem dal = new DAL_LoaiDiem();

        public DataTable selectdata()
        {
            return dal.selectdata();
        }

        public void insertdata(En_LoaiDiem en)
        {
            dal.insertdata(en);
        }

        public void updatedata(En_LoaiDiem en)
        {
            dal.updatedata(en);
        }

        public void deletedata(En_LoaiDiem en)
        {
            dal.deletedata(en);
        }
    }
}
