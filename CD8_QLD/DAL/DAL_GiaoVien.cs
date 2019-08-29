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
    public class DAL_GiaoVien
    {
        private KetNoiDuLieu cnn;

        public DAL_GiaoVien()
        {
            cnn = new KetNoiDuLieu();
        }

        //public DataTable showdata()
        //{
        //    return cnn.executeShowQuery("SELECT MaGV, TenGV, NgaySinh, GioiTinh, NoiSinh, DiaChi1, DiaChi2, SoDT1, SoDT2, NgayNhanViec, TrangThai FROM [GiaoVien]");
        //}

        public DataTable selectdata()
        {
            string query = string.Format("SELECT MaGV, TenGV, NgaySinh, GioiTinh, NoiSinh, DiaChi1, DiaChi2, SoDT1, SoDT2, NgayNhanViec, TrangThai, NgayTao, NgayCapNhat FROM GiaoVien");
            SqlParameter[] sqlPara = new SqlParameter[0];
            return cnn.executeSelectQuery(query, sqlPara);
        }

        public bool insertdata(En_GiaoVien en)
        {
            string query = string.Format("INSERT INTO GiaoVien(MaGV, TenGV, NgaySinh, GioiTinh, NoiSinh, DiaChi1, DiaChi2, SoDT1, SoDT2, NgayNhanViec, TrangThai, NgayTao, NgayCapNhat) VALUES(@MaGV, @TenGV, @NgaySinh, @GioiTinh, @NoiSinh, @DiaChi1, @DiaChi2, @SoDT1, @SoDT2, @NgayNhanViec, @TrangThai, @NgayTao, @NgayCapNhat)");
            SqlParameter[] sqlPara = new SqlParameter[13];
            sqlPara[0] = new SqlParameter("@MaGV", en.MaGV);
            sqlPara[1] = new SqlParameter("@TenGV", en.TenGV);
            sqlPara[2] = new SqlParameter("@NgaySinh", en.NgaySinh);
            sqlPara[3] = new SqlParameter("@GioiTinh", en.GioiTinh);
            sqlPara[4] = new SqlParameter("@NoiSinh", en.NoiSinh);
            sqlPara[5] = new SqlParameter("@DiaChi1", en.DiaChi1);
            sqlPara[6] = new SqlParameter("@DiaChi2", en.DiaChi2);
            sqlPara[7] = new SqlParameter("@SoDT1", en.SoDT1);
            sqlPara[8] = new SqlParameter("@SoDT2", en.SoDT2);
            sqlPara[9] = new SqlParameter("@NgayNhanViec", en.NgayNhanViec);
            sqlPara[10] = new SqlParameter("@TrangThai", en.TrangThai);
            sqlPara[11] = new SqlParameter("@NgayTao", en.NgayTao);
            sqlPara[12] = new SqlParameter("@NgayCapNhat", en.NgayCapNhat);
            return cnn.executeInsertQuery(query, sqlPara);
        }

        public bool updatedata(En_GiaoVien en)
        {
            string query = string.Format("UPDATE GiaoVien SET TenGV = @TenGV, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, NoiSinh = @NoiSinh, DiaChi1 = @DiaChi1, DiaChi2 = @DiaChi2, SoDT1 = @SoDT1, SoDT2 = @SoDT2, NgayNhanViec = @NgayNhanViec, TrangThai = @TrangThai, NgayCapNhat = @NgayCapNhat WHERE MaGV=@MaGV");
            SqlParameter[] sqlPara = new SqlParameter[12];
            sqlPara[0] = new SqlParameter("@TenGV", en.TenGV);
            sqlPara[1] = new SqlParameter("@NgaySinh", en.NgaySinh);
            sqlPara[2] = new SqlParameter("@GioiTinh", en.GioiTinh);
            sqlPara[3] = new SqlParameter("@NoiSinh", en.NoiSinh);
            sqlPara[4] = new SqlParameter("@DiaChi1", en.DiaChi1);
            sqlPara[5] = new SqlParameter("@DiaChi2", en.DiaChi2);
            sqlPara[6] = new SqlParameter("@SoDT1", en.SoDT1);
            sqlPara[7] = new SqlParameter("@SoDT2", en.SoDT2);
            sqlPara[8] = new SqlParameter("@NgayNhanViec", en.NgayNhanViec);
            sqlPara[9] = new SqlParameter("@TrangThai", en.TrangThai);
            sqlPara[10] = new SqlParameter("@NgayCapNhat", en.NgayCapNhat);
            sqlPara[11] = new SqlParameter("@MaGV", en.MaGV);
            return cnn.executeUpdateQuery(query, sqlPara);
        }

        public bool deletedata(En_GiaoVien en)
        {
            string query = string.Format("DELETE FROM GiaoVien WHERE MaGV=@MaGV");
            SqlParameter[] sqlPara = new SqlParameter[1];
            sqlPara[0] = new SqlParameter("@MaGV", en.MaGV);
            return cnn.executeDeleteQuery(query, sqlPara);
        }
    }
}
