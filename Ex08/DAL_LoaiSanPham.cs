using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Add Library
using System.Data;
using System.Data.SqlClient;

namespace Ex08
{
    class DAL_LoaiSanPham
    {
        private KetNoiDuLieu cnn;
        
        public DAL_LoaiSanPham()
        {
            cnn = new KetNoiDuLieu();
        }

        public DataTable showdata()
        {
            return cnn.executeShowQuery("SELECT MaLoai, TenLoai, MoTa FROM [LoaiSanPham]");
        }

        public int insertdata(En_LoaiSanPham en)
        {
            string query = string.Format("INSERT INTO LoaiSanPham(TenLoai, MoTa) VALUES(@TenLoai,@MoTa)");
            SqlParameter[] sqlPara = new SqlParameter[2];
            sqlPara[0] = new SqlParameter("@TenLoai", en.TenLoai);
            sqlPara[1] = new SqlParameter("@MoTa", en.MoTa);
            int rows = 0;
            try
            {
                cnn.executeInsertQuery(query, sqlPara);
                rows += 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rows;
        }

        public int updatedata(En_LoaiSanPham en)
        {
            string query = string.Format("UPDATE LoaiSanPham SET TenLoai=@TenLoai, MoTa=@MoTa WHERE MaLoai=@MaLoai");
            SqlParameter[] sqlPara = new SqlParameter[3];
            sqlPara[0] = new SqlParameter("@TenLoai", en.TenLoai);
            sqlPara[1] = new SqlParameter("@MoTa", en.MoTa);
            sqlPara[2] = new SqlParameter("@MaLoai", en.MaLoai);
            int rows = 0;
            try
            {
                cnn.executeUpdateQuery(query, sqlPara);
                rows += 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rows;
        }

        public int deletedata(En_LoaiSanPham en)
        {
            string query = string.Format("DELETE FROM LoaiSanPham WHERE MaLoai=@MaLoai");
            SqlParameter[] sqlPara = new SqlParameter[1];
            sqlPara[0] = new SqlParameter("@MaLoai", en.MaLoai);
            int rows = 0;
            try
            {
                cnn.executeDeleteQuery(query, sqlPara);
                rows += 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rows;
        }
    }
}
