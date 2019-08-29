using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Add Library
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace DAL
{
    public class DAL_LoaiDiem
    {
        private KetNoiDuLieu cnn;

        public DAL_LoaiDiem()
        {
            cnn = new KetNoiDuLieu();
        }

        //public DataTable showdata()
        //{
        //    return cnn.executeShowQuery("SELECT MaLD, TenLD, TrangThai, NgayTao, NgayCapNhat FROM [LoaiDiem]");
        //}

        public DataTable selectdata()
        {
            string query = string.Format("SELECT MaLD, TenLD, TrangThai, NgayTao, NgayCapNhat FROM LoaiDiem");
            SqlParameter[] sqlPara = new SqlParameter[0];
            return cnn.executeSelectQuery(query, sqlPara);
        }

        public bool insertdata(En_LoaiDiem en)
        {
            string query = string.Format("INSERT INTO LoaiDiem(MaLD, TenLD, TrangThai, NgayTao, NgayCapNhat) VALUES(@MaLD, @TenLD, @TrangThai, @NgayTao, @NgayCapNhat)");
            SqlParameter[] sqlPara = new SqlParameter[5];
            sqlPara[0] = new SqlParameter("@MaLD", en.MaLD);
            sqlPara[1] = new SqlParameter("@TenLD", en.TenLD);
            sqlPara[2] = new SqlParameter("@TrangThai", en.TrangThai);
            sqlPara[3] = new SqlParameter("@NgayTao", en.NgayTao);
            sqlPara[4] = new SqlParameter("@NgayCapNhat", en.NgayCapNhat);
            return cnn.executeInsertQuery(query, sqlPara);
        }

        public bool updatedata(En_LoaiDiem en)
        {
            string query = string.Format("UPDATE LoaiDiem SET TenLD = @TenLD, TrangThai = @TrangThai, NgayCapNhat = @NgayCapNhat WHERE MaLD=@MaLD");
            SqlParameter[] sqlPara = new SqlParameter[4];
            sqlPara[0] = new SqlParameter("@TenLD", en.TenLD);
            sqlPara[1] = new SqlParameter("@TrangThai", en.TrangThai);
            sqlPara[2] = new SqlParameter("@NgayCapNhat", en.NgayCapNhat);
            sqlPara[3] = new SqlParameter("@MaLD", en.MaLD);
            return cnn.executeUpdateQuery(query, sqlPara);
        }

        public bool deletedata(En_LoaiDiem en)
        {
            string query = string.Format("DELETE FROM LoaiDiem WHERE MaLD=@MaLD");
            SqlParameter[] sqlPara = new SqlParameter[1];
            sqlPara[0] = new SqlParameter("@MaLD", en.MaLD);
            return cnn.executeDeleteQuery(query, sqlPara);
        }
    }
}
