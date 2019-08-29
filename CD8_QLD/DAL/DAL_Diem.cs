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
    public class DAL_Diem
    {
        private KetNoiDuLieu cnn;

        public DAL_Diem()
        {
            cnn = new KetNoiDuLieu();
        }

        public DataTable showdata_Lop()
        {
            return cnn.executeShowQuery("SELECT MaL, TenL FROM [Lop]");
        }

        public DataTable showdata_SinhVien()
        {
            return cnn.executeShowQuery("SELECT MaSV, HoSV, TenSV FROM [SinhVien]");
        }

        public DataTable showdata_MonHoc()
        {
            return cnn.executeShowQuery("SELECT MaMH, TenMH FROM [MonHoc]");
        }

        public DataTable showdata_GiaoVien()
        {
            return cnn.executeShowQuery("SELECT MaGV, TenGV FROM [GiaoVien]");
        }

        public DataTable showdata_LoaiDiem()
        {
            return cnn.executeShowQuery("SELECT MaLD, TenLD FROM [LoaiDiem]");
        }

        public DataTable selectdata(string req)
        {
            string query = string.Format("SELECT id, MaL, MaSV, MaMH, MaGV, MaLD, Diem, TrangThai, NgayTao, NgayCapNhat FROM Diem WHERE MaL=@MaL AND MaSV=@MaSV AND MaMH=@MaMH AND MaGV=@MaGV AND MaLD=@MaLD");
            SqlParameter[] sqlPara = new SqlParameter[5];
            sqlPara[0] = new SqlParameter("@MaL", req);
            sqlPara[1] = new SqlParameter("@MaSV", req);
            sqlPara[2] = new SqlParameter("@MaMH", req);
            sqlPara[3] = new SqlParameter("@MaGV", req);
            sqlPara[4] = new SqlParameter("@MaLD", req);
            return cnn.executeSelectQuery(query, sqlPara);
        }

        public bool insertdata(En_Diem en)
        {
            string query = string.Format("INSERT INTO Diem(MaL, MaSV, MaMH, MaGV, MaLD, Diem, TrangThai, NgayTao, NgayCapNhat) VALUES(@MaL, @MaSV, @MaMH, @MaGV, @MaLD, @Diem, @TrangThai, @NgayTao, @NgayCapNhat)");
            SqlParameter[] sqlPara = new SqlParameter[9];
            sqlPara[0] = new SqlParameter("@MaL", en.MaL);
            sqlPara[1] = new SqlParameter("@MaSV", en.MaSV);
            sqlPara[2] = new SqlParameter("@MaMH", en.MaMH);
            sqlPara[3] = new SqlParameter("@MaGV", en.MaGV);
            sqlPara[4] = new SqlParameter("@MaLD", en.MaLD);
            sqlPara[5] = new SqlParameter("@Diem", en.Diem);
            sqlPara[6] = new SqlParameter("@TrangThai", en.TrangThai);
            sqlPara[7] = new SqlParameter("@NgayTao", en.NgayTao);
            sqlPara[8] = new SqlParameter("@NgayCapNhat", en.NgayCapNhat);
            return cnn.executeInsertQuery(query, sqlPara);
        }

        public bool updatedata(En_Diem en)
        {
            string query = string.Format("UPDATE Diem SET MaL = @MaL, MaSV = @MaSV, MaMH = @MaMH, MaGV = @MaGV, MaLD = @MaLD, Diem = @Diem, TrangThai = @TrangThai, NgayCapNhat = @NgayCapNhat WHERE id=@id");
            SqlParameter[] sqlPara = new SqlParameter[9];
            sqlPara[0] = new SqlParameter("@MaL", en.MaL);
            sqlPara[1] = new SqlParameter("@MaSV", en.MaSV);
            sqlPara[2] = new SqlParameter("@MaMH", en.MaMH);
            sqlPara[3] = new SqlParameter("@MaGV", en.MaGV);
            sqlPara[4] = new SqlParameter("@MaLD", en.MaLD);
            sqlPara[5] = new SqlParameter("@Diem", en.Diem);
            sqlPara[6] = new SqlParameter("@TrangThai", en.TrangThai);
            sqlPara[7] = new SqlParameter("@NgayCapNhat", en.NgayCapNhat);
            sqlPara[8] = new SqlParameter("@id", en.id);
            return cnn.executeUpdateQuery(query, sqlPara);
        }

        public bool deletedata(En_Diem en)
        {
            string query = string.Format("DELETE FROM Diem WHERE id=@id");
            SqlParameter[] sqlPara = new SqlParameter[1];
            sqlPara[0] = new SqlParameter("@id", en.id);
            return cnn.executeDeleteQuery(query, sqlPara);
        }
    }
}
