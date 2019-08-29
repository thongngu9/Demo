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
    public class DAL_User
    {
        private KetNoiDuLieu cnn;

        public DAL_User()
        {
            cnn = new KetNoiDuLieu();
        }

        //public DataTable showdata()
        //{
        //    return cnn.executeShowQuery("SELECT MaL, TenL, NienKhoa FROM [Lop]");
        //}

        public DataTable selectdata()
        {
            string query = string.Format("SELECT HoTen, TaiKhoan, Pass_Word, Quyen, TrangThai, NgayTao, NgayCapNhat FROM [User]");
            SqlParameter[] sqlPara = new SqlParameter[0];
            return cnn.executeSelectQuery(query, sqlPara);
        }

        public DataTable selectlevel(string reqUser, string reqPassWord)
        {
            string query = string.Format("SELECT Quyen FROM [User] WHERE TaiKhoan=@TaiKhoan AND Pass_Word=@Pass_Word");
            SqlParameter[] sqlPara = new SqlParameter[2];
            sqlPara[0] = new SqlParameter("@TaiKhoan", reqUser);
            sqlPara[1] = new SqlParameter("@Pass_Word", reqPassWord);
            return cnn.executeSelectQuery(query, sqlPara);
        }

        public bool insertdata(En_User en)
        {
            string query = string.Format("INSERT INTO [User](HoTen, TaiKhoan, Pass_Word, Quyen, TrangThai, NgayTao, NgayCapNhat) VALUES(@HoTen, @TaiKhoan, @Pass_Word, @Quyen, @TrangThai, @NgayTao, @NgayCapNhat)");
            SqlParameter[] sqlPara = new SqlParameter[7];
            sqlPara[0] = new SqlParameter("@HoTen", en.HoTen);
            sqlPara[1] = new SqlParameter("@TaiKhoan", en.TaiKhoan);
            sqlPara[2] = new SqlParameter("@Pass_Word", en.Pass_Word);
            sqlPara[3] = new SqlParameter("@Quyen", en.Quyen);
            sqlPara[4] = new SqlParameter("@TrangThai", en.TrangThai);
            sqlPara[5] = new SqlParameter("@NgayTao", en.NgayTao);
            sqlPara[6] = new SqlParameter("@NgayCapNhat", en.NgayCapNhat);
            return cnn.executeInsertQuery(query, sqlPara);
        }

        public bool updatedata(En_User en)
        {
            string query = string.Format("UPDATE [User] SET HoTen = @HoTen, Pass_Word = @Pass_Word, Quyen = @Quyen, TrangThai = @TrangThai, NgayCapNhat = @NgayCapNhat WHERE TaiKhoan = @TaiKhoan");
            SqlParameter[] sqlPara = new SqlParameter[6];
            sqlPara[0] = new SqlParameter("@HoTen", en.HoTen);
            sqlPara[1] = new SqlParameter("@Pass_Word", en.Pass_Word);
            sqlPara[2] = new SqlParameter("@Quyen", en.Quyen);
            sqlPara[3] = new SqlParameter("@TrangThai", en.TrangThai);
            sqlPara[4] = new SqlParameter("@NgayCapNhat", en.NgayCapNhat);
            sqlPara[5] = new SqlParameter("@TaiKhoan", en.TaiKhoan);
            return cnn.executeUpdateQuery(query, sqlPara);
        }

        public bool deletedata(En_User en)
        {
            string query = string.Format("DELETE FROM [User] WHERE TaiKhoan=@TaiKhoan");
            SqlParameter[] sqlPara = new SqlParameter[1];
            sqlPara[0] = new SqlParameter("@TaiKhoan", en.TaiKhoan);
            return cnn.executeDeleteQuery(query, sqlPara);
        }
    }
}
