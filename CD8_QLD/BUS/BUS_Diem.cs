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
    public class BUS_Diem
    {
        DAL_Diem dal = new DAL_Diem();

        public DataTable showdata_Lop()
        {
            return dal.showdata_Lop();
        }

        public DataTable showdata_SinhVien()
        {
            return dal.showdata_SinhVien();
        }

        public DataTable showdata_MonHoc()
        {
            return dal.showdata_MonHoc();
        }

        public DataTable showdata_GiaoVien()
        {
            return dal.showdata_GiaoVien();
        }

        public DataTable showdata_LoaiDiem()
        {
            return dal.showdata_LoaiDiem();
        }

        public DataTable selectdata(string req)
        {
            return dal.selectdata(req);
        }

        public void insertdata(En_Diem en)
        {
            dal.insertdata(en);
        }

        public void updatedata(En_Diem en)
        {
            dal.updatedata(en);
        }

        public void deletedata(En_Diem en)
        {
            dal.deletedata(en);
        }
    }
}
