using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BTCuoiKi
{
    class Process_CongTo : Connect_KDNuocSach
    {
        public DataTable Load_CongTo()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * from CongTo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_TkiemCT(string a)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * from CongTo where MaCT = @MaCT";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaCT", a);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public void Them_CongTo(string a, string b, string c,string d)
        {
            openConnect();
            string sql = "insert into CongTo(MaCT,LoaiCT,KichCo,TinhTrangSD) values ( @MaCT, @LoaiCT, @KichCo, @TinhTrangSD)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaCT", a);
            cmd.Parameters.AddWithValue("@LoaiCT", c);
            cmd.Parameters.AddWithValue("@KichCo", b);
            cmd.Parameters.AddWithValue("@TinhTrangSD", d);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public void Sua_CongTo(string a, string b, string c, string d)
        {
            openConnect();
            string sql = "update CongTo set LoaiCT = @LoaiCT, KichCo = @KichCo, TinhTrangSD = @TinhTrangSD where MaCT = @MaCT";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaCT", a);
            cmd.Parameters.AddWithValue("@LoaiCT", b);
            cmd.Parameters.AddWithValue("@KichCo", c);
            cmd.Parameters.AddWithValue("@TinhTrangSD", d);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public void Xoa_CongTo(string a)
        {
            openConnect();
            string sql = "delete CongTo where MaCT = @MaCT";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaCT", a);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public DataTable Load_ThongKeCT()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select Count(MaCT), Count(Distinct LoaiCT) from CongTo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_ThongKeCTtheoTot(string a)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select Count(MaCT) from CongTo where TinhTrangSD = @TinhTrangSD";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TinhTrangSD", a);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable Load_LoaiCT()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select Distinct LoaiCT FROM CongTo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_KichCoCT()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select Distinct KichCo FROM CongTo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_TinhTrangCT()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select Distinct TinhTrangSD FROM CongTo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_TimkiemCTtheoMaCT(string a)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * FROM CongTo where MaCT = @MaCT";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaCT", a);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable Load_TimkiemCTtheoLoaiCT2(string a,string b)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * FROM CongTo where LoaiCT = @LoaiCT AND  KichCo = @KichCo ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@LoaiCT", a);
            cmd.Parameters.AddWithValue("@KichCo", b);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable Load_TimkiemCTtheoLoaiCTLoai(string a)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * FROM CongTo where LoaiCT = @LoaiCT";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@LoaiCT", a);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable Load_TimkiemCTtheoLoaiCTKich(string a)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * FROM CongTo where KichCo = @KichCo ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@KichCo", a);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }

        public DataTable Load_TimkiemCTtheoLoaiCTtheoTinhTrang(string a)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * FROM CongTo where TinhTrangSD = @TinhTrang ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TinhTrang", a);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
    }
}
