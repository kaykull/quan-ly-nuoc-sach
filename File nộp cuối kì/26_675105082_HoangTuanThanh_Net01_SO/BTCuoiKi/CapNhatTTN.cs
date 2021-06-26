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
    public partial class CapNhatTTN : Form
    {
        public CapNhatTTN()
        {
            InitializeComponent();
        }

        private void bt_timTTN_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_themTTN_Click(object sender, EventArgs e)
        {
            Process_TieuThuNuoc TTN = new Process_TieuThuNuoc();
            TTN.Them_TieuThuNuoc(int.Parse(tb_maKH.Text), int.Parse(tb_maCT.Text), int.Parse(tb_SoKhoi.Text), int.Parse(tb_Ky.Text), int.Parse(tb_Nam.Text), float.Parse(tb_ThanhTien.Text), float.Parse(tb_Thue.Text), float.Parse(tb_TongTien.Text));
            dgv_TieuThuNuoc.DataSource = TTN.Load_TieuThuNuoc();
        }

        private void bt_suaTTN_Click(object sender, EventArgs e)
        {
            Process_TieuThuNuoc TTN = new Process_TieuThuNuoc();
            TTN.Sua_TieuThuNuoc(int.Parse(tb_maKH.Text), int.Parse(tb_maCT.Text), int.Parse(tb_SoKhoi.Text), int.Parse(tb_Ky.Text), int.Parse(tb_Nam.Text), float.Parse(tb_ThanhTien.Text), float.Parse(tb_Thue.Text), float.Parse(tb_TongTien.Text));
            dgv_TieuThuNuoc.DataSource = TTN.Load_TieuThuNuoc();
        }

        private void bt_xoaTTN_Click(object sender, EventArgs e)
        {
            Process_TieuThuNuoc TTN = new Process_TieuThuNuoc();
            TTN.Xoa_TieuThuNuoc(int.Parse(tb_maKH.Text));
            dgv_TieuThuNuoc.DataSource = TTN.Load_TieuThuNuoc();
        }

        private void dgv_TieuThuNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dgv_TieuThuNuoc.CurrentRow.Index;
            tb_maKH.Text = dgv_TieuThuNuoc.Rows[x].Cells[0].Value.ToString();
            tb_maCT.Text = dgv_TieuThuNuoc.Rows[x].Cells[1].Value.ToString();
            tb_SoKhoi.Text = dgv_TieuThuNuoc.Rows[x].Cells[2].Value.ToString();
            tb_Ky.Text = dgv_TieuThuNuoc.Rows[x].Cells[3].Value.ToString();
            tb_Nam.Text = dgv_TieuThuNuoc.Rows[x].Cells[4].Value.ToString();
            tb_ThanhTien.Text = dgv_TieuThuNuoc.Rows[x].Cells[5].Value.ToString();
            tb_Thue.Text = dgv_TieuThuNuoc.Rows[x].Cells[6].Value.ToString();
            tb_TongTien.Text = dgv_TieuThuNuoc.Rows[x].Cells[7].Value.ToString();
        }

        private void CapNhatTTN_Load(object sender, EventArgs e)
        {
            tb_ThanhTien.Text = "0";
            tb_Thue.Text = "0";
            tb_TongTien.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process_TieuThuNuoc TTN = new Process_TieuThuNuoc();
            dgv_TieuThuNuoc.DataSource = TTN.Load_TieuThuNuoc();
        }

        private void bt_thoatTTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
