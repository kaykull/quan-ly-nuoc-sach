using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCuoiKi
{
    class Process_KhachHang : Connect_KDNuocSach
    {
        int h = 0;
        public bool check(string a)
        {
            return (a != "" && int.TryParse(a, out  h));
        }
        public DataTable Load_KH()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM KhachHang";
            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.Parameters.AddWithValue();
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_TkiemKHtheoMa(string a)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM KhachHang where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaKH" , a);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_TkiemKHtheoTen(string a)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM KhachHang where TenKH = @TenKH";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TenKH", a);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_TkiemKHtheoDiaChi(string a)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM KhachHang where DiaChi = @DiaChi";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@DiaChi", a);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_TkiemKHtheoDoTuoi(int a, int b)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT * FROM KhachHang where Tuoi >= @Tuoimin AND Tuoi <= @Tuoimax ORDER BY Tuoi ASC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Tuoimin", a);
            cmd.Parameters.AddWithValue("@Tuoimax", b);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public void Them_Table(string a, string b, int c, string d)
        {
            openConnect();
            string sql = "Insert into KhachHang(MaKH,TenKH,Tuoi,DiaChi) values ( @MaKH , @TenKH , @Tuoi , @DiaChi)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaKH", a);
            cmd.Parameters.AddWithValue("@TenKH", b);
            cmd.Parameters.AddWithValue("@Tuoi", c);
            cmd.Parameters.AddWithValue("@DiaChi", d);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public void Sua_Table(string a,string b, int c, string d)
        {
            openConnect();
            string sql = "update KhachHang set TenKH = @TenKH, Tuoi = @Tuoi, DiaChi = @DiaChi where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaKH", a);
            cmd.Parameters.AddWithValue("@TenKH", b);
            cmd.Parameters.AddWithValue("@Tuoi", c);
            cmd.Parameters.AddWithValue("@DiaChi", d);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public void Xoa_Table(string a)
        {
            openConnect();
            string sql = "delete from KhachHang where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("@MaKH", a);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public DataTable Load_ThongKeKHvsTuoi()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT Count(MaKH) sl, Min(Tuoi) as min, Max(Tuoi) as max FROM KhachHang";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_ThongKeKhuVuc()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT Count(DISTINCT DiaChi) FROM KhachHang";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_DiaChiKH()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "SELECT DISTINCT DiaChi FROM KhachHang";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
    }
}
