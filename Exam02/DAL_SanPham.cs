using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Add Library
using System.Data;
using System.Data.SqlClient;

namespace DangPhuThong_01_3Player
{
    class DAL_SanPham
    {
        private KetNoiDuLieu cnn;

        public DAL_SanPham()
        {
            cnn = new KetNoiDuLieu();
        }

        public DataTable showdata()
        {
            return cnn.executeShowQuery("SELECT MaLoai, TenLoai FROM [LoaiSanPham]");
        }

        public DataTable selectdata(string req)
        {
            string query = string.Format("SELECT MaHang, TenHang, MaLoai, SoLuong, GiaBan FROM SanPham WHERE MaLoai=@MaLoai");
            SqlParameter[] sqlPara = new SqlParameter[1];
            sqlPara[0] = new SqlParameter("@MaLoai", req);
            return cnn.executeSelectQuery(query, sqlPara);
        }

        public bool insertdata(En_SanPham en)
        {
            string query = string.Format("INSERT INTO SanPham(MaHang, TenHang, SoLuong, GiaBan, MaLoai) VALUES(@MaHang,@TenHang,@SoLuong,@GiaBan,@MaLoai)");
            SqlParameter[] sqlPara = new SqlParameter[5];
            sqlPara[0] = new SqlParameter("@MaHang", en.MaHang);
            sqlPara[1] = new SqlParameter("@TenHang", en.TenHang);
            sqlPara[2] = new SqlParameter("@SoLuong", en.SoLuong);
            sqlPara[3] = new SqlParameter("@GiaBan", en.GiaBan);
            sqlPara[4] = new SqlParameter("@MaLoai", en.MaLoai);
            return cnn.executeInsertQuery(query, sqlPara);
        }

        public bool updatedata(En_SanPham en)
        {
            string query = string.Format("UPDATE SanPham SET TenHang=@TenHang, SoLuong=@SoLuong, GiaBan=@GiaBan WHERE MaHang=@MaHang");
            SqlParameter[] sqlPara = new SqlParameter[4];
            sqlPara[0] = new SqlParameter("@TenHang", en.TenHang);
            sqlPara[1] = new SqlParameter("@SoLuong", en.SoLuong);
            sqlPara[2] = new SqlParameter("@GiaBan", en.GiaBan);
            sqlPara[3] = new SqlParameter("@MaHang", en.MaHang);
            return cnn.executeUpdateQuery(query, sqlPara);
        }

        public bool deletedata(En_SanPham en)
        {
            string query = string.Format("DELETE FROM SanPham WHERE MaHang=@MaHang");
            SqlParameter[] sqlPara = new SqlParameter[1];
            sqlPara[0] = new SqlParameter("@MaHang", en.MaHang);
            return cnn.executeDeleteQuery(query, sqlPara);
        }
    }
}
