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
            string query = string.Format("SELECT MaSP, TenSP, DonViTinh, DonGiaMua, SoTon FROM SanPham WHERE MaLoai=@MaLoai");
            SqlParameter[] sqlPara = new SqlParameter[1];
            sqlPara[0] = new SqlParameter("@MaLoai", req);
            return cnn.executeSelectQuery(query, sqlPara);
        }

        public bool insertdata(En_SanPham en)
        {
            string query = string.Format("INSERT INTO SanPham(TenSP, DonViTinh, DonGiaMua, SoTon, MaLoai) VALUES(@TenSP,@DonViTinh,@DonGiaMua,@SoTon,@MaLoai)");
            SqlParameter[] sqlPara = new SqlParameter[5];
            sqlPara[0] = new SqlParameter("@TenSP", en.TenSP);
            sqlPara[1] = new SqlParameter("@DonViTinh", en.DonVi);
            sqlPara[2] = new SqlParameter("@DonGiaMua", en.DonGia);
            sqlPara[3] = new SqlParameter("@SoTon", en.SoTon);
            sqlPara[4] = new SqlParameter("@MaLoai", en.MaLoai);
            return cnn.executeInsertQuery(query, sqlPara);
        }

        public bool updatedata(En_SanPham en)
        {
            string query = string.Format("UPDATE SanPham SET TenSP=@TenSP, DonViTinh=@DonViTinh, DonGiaMua=@DonGiaMua, SoTon=@SoTon WHERE MaSP=@MaSP");
            SqlParameter[] sqlPara = new SqlParameter[5];
            sqlPara[0] = new SqlParameter("@TenSP", en.TenSP);
            sqlPara[1] = new SqlParameter("@DonViTinh", en.DonVi);
            sqlPara[2] = new SqlParameter("@DonGiaMua", en.DonGia);
            sqlPara[3] = new SqlParameter("@SoTon", en.SoTon);
            sqlPara[4] = new SqlParameter("@MaSP", en.MaSP);
            return cnn.executeUpdateQuery(query, sqlPara);
        }

        public bool deletedata(En_SanPham en)
        {
            string query = string.Format("DELETE FROM SanPham WHERE MaSP=@MaSP");
            SqlParameter[] sqlPara = new SqlParameter[1];
            sqlPara[0] = new SqlParameter("@MaSP", en.MaSP);
            return cnn.executeDeleteQuery(query, sqlPara);
        }
    }
}
