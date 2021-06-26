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
    public partial class TimKiemTTN : Form
    {
        public TimKiemTTN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process_TieuThuNuoc TTN = new Process_TieuThuNuoc();
            dgv_hienthi.DataSource = TTN.Load_TieuThuNuoc();

            cbb_MaKH.DataSource = TTN.Load_maKH();
            cbb_MaKH.DisplayMember = "MaKH";
            cbb_MaKH.ValueMember = "MaKH";

            cbb_ky.DataSource = TTN.Load_Ky();
            cbb_ky.DisplayMember = "Ky";
            cbb_ky.ValueMember = "Ky";

            cbb_max.DataSource = TTN.Load_ThanhTienMinMax();
            cbb_max.DisplayMember = "max";
            cbb_max.ValueMember = "max";

            cbb_min.DataSource = TTN.Load_ThanhTienMinMax();
            cbb_min.DisplayMember = "min";
            cbb_min.ValueMember = "min";
        }

        private void bt_timkiemCTtheoMaCT_Click(object sender, EventArgs e)
        {
            Process_TieuThuNuoc TTN = new Process_TieuThuNuoc();
            dgv_hienthi.DataSource = TTN.Load_thongkeTTNtheoMaKH(cbb_MaKH.Text);
        }

        private void bt_thongketheoKy_Click(object sender, EventArgs e)
        {
            Process_TieuThuNuoc TTN = new Process_TieuThuNuoc();
            dgv_hienthi.DataSource = TTN.Load_thongkeTTNtheoKy(cbb_ky.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process_TieuThuNuoc TTN = new Process_TieuThuNuoc();
            dgv_hienthi.DataSource = TTN.Load_thongkeTTNtheoThanhTien(cbb_min.Text,cbb_max.Text);
        }

        private void TimKiemTTN_Load(object sender, EventArgs e)
        {

        }
    }
}
