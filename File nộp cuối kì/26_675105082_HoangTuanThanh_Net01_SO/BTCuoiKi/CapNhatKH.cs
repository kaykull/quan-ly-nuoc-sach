using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTCuoiKi
{
    public partial class CapNhatKH : Form
    {
        public CapNhatKH()
        {
            InitializeComponent();
            
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            Process_KhachHang tkKH = new Process_KhachHang();
            dgv_hienthiKH.DataSource = tkKH.Load_TkiemKHtheoMa(tb_MaKH.Text);
        }

        private void dgv_hienthiKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dgv_hienthiKH.CurrentRow.Index;
            tb_MaKH.Text = dgv_hienthiKH.Rows[x].Cells[0].Value.ToString();
            tb_TenKH.Text = dgv_hienthiKH.Rows[x].Cells[1].Value.ToString();
            tb_Tuoi.Text = dgv_hienthiKH.Rows[x].Cells[2].Value.ToString();
            tb_DiaChi.Text = dgv_hienthiKH.Rows[x].Cells[3].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            Process_KhachHang themKH = new Process_KhachHang();
            //int check = 0;
            //bool ktra = true;
            //for (int i = 0; i< dgv_hienthiKH.Rows.Count; i++)
            //{
            //check += int.Parse(dgv_hienthiKH.Rows[i].Cells[0].Value.
            //  if (check == int.Parse(tb_MaKH.Text)) ktra = false;
            //check = 0;
            //}
            //if (ktra == true)
            if (themKH.check(tb_Tuoi.Text) == false)
                MessageBox.Show("Nhập lại tuổi chính xác", "Alo alo");
            else
            {
                if (int.Parse(tb_Tuoi.Text) < 18)
                    MessageBox.Show("Bạn chưa đủ tuổi đi làm");
                else if (int.Parse(tb_Tuoi.Text) > 60)
                    MessageBox.Show("Bạn về hưu chưa");
                else
                    themKH.Them_Table(tb_MaKH.Text, tb_TenKH.Text, int.Parse(tb_Tuoi.Text), tb_DiaChi.Text);
            }
            //else
            //MessageBox.Show("Trung ma khach hang. Xin nhap lai", "Alo alo");
            dgv_hienthiKH.DataSource = themKH.Load_KH();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            Process_KhachHang SuaKH = new Process_KhachHang();
            if (SuaKH.check(tb_Tuoi.Text) == false)
                MessageBox.Show("Nhập lại tuổi chính xác", "Alo alo");
            else
            {
                if (int.Parse(tb_Tuoi.Text) < 18)
                    MessageBox.Show("Bạn chưa đủ tuổi đi làm");
                else if (int.Parse(tb_Tuoi.Text) > 60)
                    MessageBox.Show("Bạn muốn nghỉ hưu rồi à");
                else
                    SuaKH.Sua_Table(tb_MaKH.Text, tb_TenKH.Text, int.Parse(tb_Tuoi.Text), tb_DiaChi.Text);
            }
            dgv_hienthiKH.DataSource = SuaKH.Load_KH();

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            Process_KhachHang XoaKH = new Process_KhachHang();
            XoaKH.Xoa_Table(tb_MaKH.Text);
            dgv_hienthiKH.DataSource = XoaKH.Load_KH();
        }

        private void bt_Load_Click(object sender, EventArgs e)
        {
            Process_KhachHang tkKH = new Process_KhachHang();
            dgv_hienthiKH.DataSource = tkKH.Load_KH();
        }

        private void dgv_hienthiKH_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

        }
    }
    
}
