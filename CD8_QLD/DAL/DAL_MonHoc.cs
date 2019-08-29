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
    public class DAL_MonHoc
    {
        private KetNoiDuLieu cnn;

        public DAL_MonHoc()
        {
            cnn = new KetNoiDuLieu();
        }

        //public DataTable showdata()
        //{
        //    return cnn.executeShowQuery("SELECT MaL, TenL, NienKhoa, MaGV, TrangThai, NgayTao, NgayCapNhat FROM [Lop]");
        //}

        public DataTable selectdata()
        {
            string query = string.Format("SELECT MaMH, TenMH, SoTC, BieuPhi, DonVi, TrangThai, NgayTao, NgayCapNhat FROM MonHoc");
            SqlParameter[] sqlPara = new SqlParameter[0];
            return cnn.executeSelectQuery(query, sqlPara);
        }

        public bool insertdata(En_MonHoc en)
        {
            string query = string.Format("INSERT INTO MonHoc(MaMH, TenMH, SoTC, BieuPhi, DonVi, TrangThai, NgayTao, NgayCapNhat) VALUES(@MaMH, @TenMH, @SoTC, @BieuPhi, @DonVi, @TrangThai, @NgayTao, @NgayCapNhat)");
            SqlParameter[] sqlPara = new SqlParameter[8];
            sqlPara[0] = new SqlParameter("@MaMH", en.MaMH);
            sqlPara[1] = new SqlParameter("@TenMH", en.TenMH);
            sqlPara[2] = new SqlParameter("@SoTC", en.SoTC);
            sqlPara[3] = new SqlParameter("@BieuPhi", en.BieuPhi);
            sqlPara[4] = new SqlParameter("@DonVi", en.DonVi);
            sqlPara[5] = new SqlParameter("@TrangThai", en.TrangThai);
            sqlPara[6] = new SqlParameter("@NgayTao", en.NgayTao);
            sqlPara[7] = new SqlParameter("@NgayCapNhat", en.NgayCapNhat);
            return cnn.executeInsertQuery(query, sqlPara);
        }

        public bool updatedata(En_MonHoc en)
        {
            string query = string.Format("UPDATE MonHoc SET TenMH = @TenMH, SoTC = @SoTC, BieuPhi = @BieuPhi, DonVi = @DonVi, TrangThai = @TrangThai, NgayCapNhat = @NgayCapNhat WHERE MaMH = @MaMH");
            SqlParameter[] sqlPara = new SqlParameter[7];
            sqlPara[0] = new SqlParameter("@TenMH", en.TenMH);
            sqlPara[1] = new SqlParameter("@SoTC", en.SoTC);
            sqlPara[2] = new SqlParameter("@BieuPhi", en.BieuPhi);
            sqlPara[3] = new SqlParameter("@DonVi", en.DonVi);
            sqlPara[4] = new SqlParameter("@TrangThai", en.TrangThai);
            sqlPara[5] = new SqlParameter("@NgayCapNhat", en.NgayCapNhat);
            sqlPara[6] = new SqlParameter("@MaMH", en.MaMH);
            return cnn.executeUpdateQuery(query, sqlPara);
        }

        public bool deletedata(En_MonHoc en)
        {
            string query = string.Format("DELETE FROM MonHoc WHERE MaMH=@MaMH");
            SqlParameter[] sqlPara = new SqlParameter[1];
            sqlPara[0] = new SqlParameter("@MaMH", en.MaMH);
            return cnn.executeDeleteQuery(query, sqlPara);
        }
    }
}
