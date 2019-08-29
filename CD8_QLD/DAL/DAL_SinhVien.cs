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
    public class DAL_SinhVien
    {
        private KetNoiDuLieu cnn;

        public DAL_SinhVien()
        {
            cnn = new KetNoiDuLieu();
        }

        public DataTable showdata()
        {
            return cnn.executeShowQuery("SELECT MaL, TenL, NienKhoa FROM [Lop]");
        }

        public DataTable selectdata()
        {
            string query = string.Format("SELECT MaSV, HoSV, TenSV, GioiTinh, NgaySinh, NoiSinh, DiaChi1, DiaChi2, SoDT, TenPH1, TenPH2, SoDTPH1, SoDTPH2, GhiChu, MaL, TrangThai, NgayTao, NgayCapNhat FROM SinhVien");
            SqlParameter[] sqlPara = new SqlParameter[0];
            return cnn.executeSelectQuery(query, sqlPara);
        }

        public bool insertdata(En_SinhVien en)
        {
            string query = string.Format("INSERT INTO SinhVien(MaSV, HoSV, TenSV, GioiTinh, NgaySinh, NoiSinh, DiaChi1, DiaChi2, SoDT, TenPH1, TenPH2, SoDTPH1, SoDTPH2, GhiChu, MaL, TrangThai, NgayTao, NgayCapNhat) VALUES(@MaSV, @HoSV, @TenSV, @GioiTinh, @NgaySinh, @NoiSinh, @DiaChi1, @DiaChi2, @SoDT, @TenPH1, @TenPH2, @SoDTPH1, @SoDTPH2, @GhiChu, @MaL, @TrangThai, @NgayTao, @NgayCapNhat)");
            SqlParameter[] sqlPara = new SqlParameter[18];
            sqlPara[0] = new SqlParameter("@MaSV", en.MaSV);
            sqlPara[1] = new SqlParameter("@HoSV", en.HoSV);
            sqlPara[2] = new SqlParameter("@TenSV", en.TenSV);
            sqlPara[3] = new SqlParameter("@GioiTinh", en.GioiTinh);
            sqlPara[4] = new SqlParameter("@NgaySinh", en.NgaySinh);
            sqlPara[5] = new SqlParameter("@NoiSinh", en.NoiSinh);
            sqlPara[6] = new SqlParameter("@DiaChi1", en.DiaChi1);
            sqlPara[7] = new SqlParameter("@DiaChi2", en.DiaChi2);
            sqlPara[8] = new SqlParameter("@SoDT", en.SoDT);
            sqlPara[9] = new SqlParameter("@TenPH1", en.TenPH1);
            sqlPara[10] = new SqlParameter("@TenPH2", en.TenPH2);
            sqlPara[11] = new SqlParameter("@SoDTPH1", en.SoDTPH1);
            sqlPara[12] = new SqlParameter("@SoDTPH2", en.SoDTPH2);
            sqlPara[13] = new SqlParameter("@GhiChu", en.GhiChu);
            sqlPara[14] = new SqlParameter("@MaL", en.MaL);
            sqlPara[15] = new SqlParameter("@TrangThai", en.TrangThai);
            sqlPara[16] = new SqlParameter("@NgayTao", en.NgayTao);
            sqlPara[17] = new SqlParameter("@NgayCapNhat", en.NgayCapNhat);
            return cnn.executeInsertQuery(query, sqlPara);
        }

        public bool updatedata(En_SinhVien en)
        {
            string query = string.Format("UPDATE SinhVien SET HoSV = @HoSV, TenSV = @TenSV, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, NoiSinh = @NoiSinh, DiaChi1 = @DiaChi1, DiaChi2 = @DiaChi2, SoDT = @SoDT, TenPH1 = @TenPH1, TenPH2 = @TenPH2, SoDTPH1 = @SoDTPH1, SoDTPH2 = @SoDTPH2, GhiChu = @GhiChu, MaL = @MaL, TrangThai = @TrangThai, NgayCapNhat = @NgayCapNhat WHERE MaSV = @MaSV");
            SqlParameter[] sqlPara = new SqlParameter[17];
            sqlPara[0] = new SqlParameter("@HoSV", en.HoSV);
            sqlPara[1] = new SqlParameter("@TenSV", en.TenSV);
            sqlPara[2] = new SqlParameter("@GioiTinh", en.GioiTinh);
            sqlPara[3] = new SqlParameter("@NgaySinh", en.NgaySinh);
            sqlPara[4] = new SqlParameter("@NoiSinh", en.NoiSinh);
            sqlPara[5] = new SqlParameter("@DiaChi1", en.DiaChi1);
            sqlPara[6] = new SqlParameter("@DiaChi2", en.DiaChi2);
            sqlPara[7] = new SqlParameter("@SoDT", en.SoDT);
            sqlPara[8] = new SqlParameter("@TenPH1", en.TenPH1);
            sqlPara[9] = new SqlParameter("@TenPH2", en.TenPH2);
            sqlPara[10] = new SqlParameter("@SoDTPH1", en.SoDTPH1);
            sqlPara[11] = new SqlParameter("@SoDTPH2", en.SoDTPH2);
            sqlPara[12] = new SqlParameter("@GhiChu", en.GhiChu);
            sqlPara[13] = new SqlParameter("@MaL", en.MaL);
            sqlPara[14] = new SqlParameter("@TrangThai", en.TrangThai);
            sqlPara[15] = new SqlParameter("@NgayCapNhat", en.NgayCapNhat);
            sqlPara[16] = new SqlParameter("@MaSV", en.MaSV);
            return cnn.executeUpdateQuery(query, sqlPara);
        }

        public bool deletedata(En_SinhVien en)
        {
            string query = string.Format("DELETE FROM SinhVien WHERE MaSV=@MaSV");
            SqlParameter[] sqlPara = new SqlParameter[1];
            sqlPara[0] = new SqlParameter("@MaSV", en.MaSV);
            return cnn.executeDeleteQuery(query, sqlPara);
        }
    }
}
