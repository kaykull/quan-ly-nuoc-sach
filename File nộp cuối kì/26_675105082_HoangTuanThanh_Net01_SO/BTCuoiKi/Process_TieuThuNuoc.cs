using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTCuoiKi
{
    class Process_TieuThuNuoc : Connect_KDNuocSach
    {
        int h = 0;
        public bool check(string a)
        {
            return (a != "" && int.TryParse(a, out h));
        }
        public DataTable Load_TieuThuNuoc()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "select * from TieuThuNuoc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public void Them_TieuThuNuoc(int a, int b, int c, int d, int e, float f, float g, float h)
        {
            openConnect();
            string sql = "Insert into TieuThuNuoc(MaKH,MaCT,SoKhoi,Ky,Nam,ThanhTien,Thue,TongTien) values( @MaKH,@MaCT,@SoKhoi,@Ky,@Nam,@ThanhTien,@Thue,@TongTien)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaKH", a);
            cmd.Parameters.AddWithValue("@MaCT", b);
            cmd.Parameters.AddWithValue("@SoKhoi", c);
            cmd.Parameters.AddWithValue("@Ky", d);
            cmd.Parameters.AddWithValue("@Nam", e);
            cmd.Parameters.AddWithValue("@ThanhTien", f);
            cmd.Parameters.AddWithValue("@Thue", g);
            cmd.Parameters.AddWithValue("@TongTien", h);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public void Sua_TieuThuNuoc(int a, int b, int c, int d, int e, float f, float g, float h)
        {
            openConnect();
            string sql = "Update TieuThuNuoc set MaCT =@MaCT, SoKhoi =@SoKhoi, Ky=@Ky, Nam=@Nam, ThanhTien= @ThanhTien, Thue=@Thue, TongTien= @TongTien where MaKH=@MaKH";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaKH", a);
            cmd.Parameters.AddWithValue("@MaCT", b);
            cmd.Parameters.AddWithValue("@SoKhoi", c);
            cmd.Parameters.AddWithValue("@Ky", d);
            cmd.Parameters.AddWithValue("@Nam", e);
            cmd.Parameters.AddWithValue("@ThanhTien", f);
            cmd.Parameters.AddWithValue("@Thue", g);
            cmd.Parameters.AddWithValue("@TongTien", h);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public void Xoa_TieuThuNuoc(int a)
        {
            openConnect();
            string sql = "Delete TieuThuNuoc where MaKH=@MaKH";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaKH", a);
            cmd.ExecuteNonQuery();
            closeConnect();
        }
        public DataTable Load_thongkeTTN(string a)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "Select Count(distinct MaKH) as slkh, SUM(SoKhoi) AS tb, Min(SoKhoi) AS min, Max(SoKhoi) AS max FROM TieuThuNuoc Where Ky=@Ky";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Ky", a);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_Ky()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "Select distinct Ky From TieuThuNuoc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return 22
                222222222222222222222;
        }
        public DataTable Load_maKH()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "Select distinct MaKH From TieuThuNuoc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_ThanhTienMinMax()
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "Select Min(ThanhTien) AS min, Max(ThanhTien) AS max From TieuThuNuoc";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_thongkeTTNtheoMaKH(string a)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "Select * From TieuThuNuoc where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaKH", a);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_thongkeTTNtheoKy(string a)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "Select * From TieuThuNuoc where Ky = @Ky";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Ky", a);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
        public DataTable Load_thongkeTTNtheoThanhTien(string a,string b)
        {
            DataTable bang = new DataTable();
            openConnect();
            string sql = "Select * From TieuThuNuoc where ThanhTien > @Tienmin AND ThanhTien < @Tienmax";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Tienmin", a);
            cmd.Parameters.AddWithValue("@Tienmax", b);
            SqlDataReader reader = cmd.ExecuteReader();
            bang.Load(reader);
            closeConnect();
            return bang;
        }
    }
}
