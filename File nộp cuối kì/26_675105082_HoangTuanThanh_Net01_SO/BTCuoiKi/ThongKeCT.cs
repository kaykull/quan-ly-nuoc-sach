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
    public partial class ThongKeCT : Form
    {
        public ThongKeCT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process_CongTo ThongKeCT = new Process_CongTo();
            dgv_hienthi.DataSource = ThongKeCT.Load_CongTo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_thongkeCTdangsuachua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Process_CongTo ThongKeCT = new Process_CongTo();
            dgv_thongkeCT.DataSource = ThongKeCT.Load_ThongKeCT();
            tb_slCT.Text = dgv_thongkeCT.Rows[0].Cells[0].Value.ToString();
            tb_slLoaiCT.Text = dgv_thongkeCT.Rows[0].Cells[1].Value.ToString();
            dgv_thongkeCTsdtot.DataSource = ThongKeCT.Load_ThongKeCTtheoTot("Tốt");
            tb_slCThdTot.Text = dgv_thongkeCTsdtot.Rows[0].Cells[0].Value.ToString();
            dgv_thongkeCTdangsuachua.DataSource = ThongKeCT.Load_ThongKeCTtheoTot("Đang sửa chữa");
            tb_slCTdangsuachua.Text = dgv_thongkeCTdangsuachua.Rows[0].Cells[0].Value.ToString();
            dgv_thongkeCTdangbaoloi.DataSource = ThongKeCT.Load_ThongKeCTtheoTot("Báo lỗi");
            tb_slCTdangbaoloi.Text = dgv_thongkeCTdangbaoloi.Rows[0].Cells[0].Value.ToString();
        }
    }
}
