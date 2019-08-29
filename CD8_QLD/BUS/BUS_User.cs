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
    public class BUS_User
    {
        DAL_User dal = new DAL_User();

        public DataTable selectdata()
        {
            return dal.selectdata();
        }

        public DataTable selectlevel(string reqUser, string reqPassWord)
        {
            return dal.selectlevel(reqUser, reqPassWord);
        }

        public void insertdata(En_User en)
        {
            dal.insertdata(en);
        }

        public void updatedata(En_User en)
        {
            dal.updatedata(en);
        }

        public void deletedata(En_User en)
        {
            dal.deletedata(en);
        }
    }
}
