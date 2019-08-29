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
    public class DAL_Lop
    {
        private KetNoiDuLieu cnn;

        public DAL_Lop()
        {
            cnn = new KetNoiDuLieu();
        }

        public DataTable showdata()
        {
            return cnn.executeShowQuery("SELECT MaGV, TenGV FROM [GiaoVien]");
        }

        public DataTable selectdata()
        {
            string query = string.Format("SELECT MaL, TenL, NienKhoa, MaGV, TrangThai, NgayTao, NgayCapNhat FROM Lop");
            SqlParameter[] sqlPara = new SqlParameter[0];
            return cnn.executeSelectQuery(query, sqlPara);
        }

        public bool insertdata(En_Lop en)
        {
            string query = string.Format("INSERT INTO Lop(MaL, TenL, NienKhoa, MaGV, TrangThai, NgayTao, NgayCapNhat) VALUES(@MaL, @TenL, @NienKhoa, @MaGV, @TrangThai, @NgayTao, @NgayCapNhat)");
            SqlParameter[] sqlPara = new SqlParameter[7];
            sqlPara[0] = new SqlParameter("@MaL", en.MaL);
            sqlPara[1] = new SqlParameter("@TenL", en.TenL);
            sqlPara[2] = new SqlParameter("@NienKhoa", en.NienKhoa);
            sqlPara[3] = new SqlParameter("@MaGV", en.MaGV);
            sqlPara[4] = new SqlParameter("@TrangThai", en.TrangThai);
            sqlPara[5] = new SqlParameter("@NgayTao", en.NgayTao);
            sqlPara[6] = new SqlParameter("@NgayCapNhat", en.NgayCapNhat);
            return cnn.executeInsertQuery(query, sqlPara);
        }

        public bool updatedata(En_Lop en)
        {
            string query = string.Format("UPDATE Lop SET TenL = @TenL, NienKhoa = @NienKhoa, MaGV = @MaGV, TrangThai = @TrangThai, NgayCapNhat = @NgayCapNhat WHERE MaL = @MaL");
            SqlParameter[] sqlPara = new SqlParameter[6];
            sqlPara[0] = new SqlParameter("@TenL", en.TenL);
            sqlPara[1] = new SqlParameter("@NienKhoa", en.NienKhoa);
            sqlPara[2] = new SqlParameter("@MaGV", en.MaGV);
            sqlPara[3] = new SqlParameter("@TrangThai", en.TrangThai);
            sqlPara[4] = new SqlParameter("@NgayCapNhat", en.NgayCapNhat);
            sqlPara[5] = new SqlParameter("@MaL", en.MaL);
            return cnn.executeUpdateQuery(query, sqlPara);
        }

        public bool deletedata(En_Lop en)
        {
            string query = string.Format("DELETE FROM Lop WHERE MaL=@MaL");
            SqlParameter[] sqlPara = new SqlParameter[1];
            sqlPara[0] = new SqlParameter("@MaL", en.MaL);
            return cnn.executeDeleteQuery(query, sqlPara);
        }
    }
}
