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
    public partial class ThongKeKH : Form
    {
        public ThongKeKH()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_Load_Click(object sender, EventArgs e)
        {
            Process_KhachHang thongkeKH = new Process_KhachHang();
            dgv_hienthiKH.DataSource = thongkeKH.Load_KH();
        }

        private void bt_ThongKe_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_ThongKe_Click_1(object sender, EventArgs e)
        {
            Process_KhachHang thongkeKH = new Process_KhachHang();
            dgv_ThongKeSL_Tuoi.DataSource = thongkeKH.Load_ThongKeKHvsTuoi();
            tb_slKH.Text = dgv_ThongKeSL_Tuoi.Rows[0].Cells[0].Value.ToString();
            tb_TuoiMin.Text = dgv_ThongKeSL_Tuoi.Rows[0].Cells[1].Value.ToString();
            tb_TuoiMax.Text = dgv_ThongKeSL_Tuoi.Rows[0].Cells[2].Value.ToString();
            dgv_thongkeKhuVuc.DataSource = thongkeKH.Load_ThongKeKhuVuc();
            tb_khuvucNN.Text = dgv_thongkeKhuVuc.Rows[0].Cells[0].Value.ToString();
        }
    }
}
