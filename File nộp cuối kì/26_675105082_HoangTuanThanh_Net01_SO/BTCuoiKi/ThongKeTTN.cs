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
    public partial class ThongKeTTN : Form
    {
        public ThongKeTTN()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process_TieuThuNuoc thongkeTTN = new Process_TieuThuNuoc();
            dgv_thongkeTTN.DataSource = thongkeTTN.Load_thongkeTTN(cbb_ky.Text);
            tb_slKH.Text = dgv_thongkeTTN.Rows[0].Cells[0].Value.ToString();
            tb_Tongkhoi.Text = dgv_thongkeTTN.Rows[0].Cells[1].Value.ToString();
            tb_minKhoi.Text = dgv_thongkeTTN.Rows[0].Cells[2].Value.ToString();
            tb_maxKhoi.Text = dgv_thongkeTTN.Rows[0].Cells[3].Value.ToString();
        }

        private void ThongKeTTN_Load(object sender, EventArgs e)
        {
            Process_TieuThuNuoc thongkeTTN = new Process_TieuThuNuoc();
            cbb_ky.DataSource = thongkeTTN.Load_Ky();
            cbb_ky.DisplayMember = "Ky";
            cbb_ky.ValueMember = "Ky";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process_TieuThuNuoc thongkeTTN = new Process_TieuThuNuoc();
            dgv_hienthi.DataSource = thongkeTTN.Load_TieuThuNuoc();
        }
    }
}
