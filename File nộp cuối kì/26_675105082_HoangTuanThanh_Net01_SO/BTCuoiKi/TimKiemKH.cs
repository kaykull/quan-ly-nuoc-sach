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
    public partial class TimKiemKH : Form
    {
        public TimKiemKH()
        {
            InitializeComponent();
            Process_KhachHang TimkiemKH = new Process_KhachHang();

            cbb_timma.DataSource = TimkiemKH.Load_KH();
            cbb_timma.DisplayMember = "MaKH";
            cbb_timma.ValueMember = "MaKH";

            cbb_timtuoimin.DataSource = TimkiemKH.Load_ThongKeKHvsTuoi();
            cbb_timtuoimin.DisplayMember = "min";
            cbb_timtuoimin.ValueMember = "min";

            cbb_timtuoimax.DataSource = TimkiemKH.Load_ThongKeKHvsTuoi();
            cbb_timtuoimax.DisplayMember = "max";
            cbb_timtuoimax.ValueMember = "max";

            cbb_timten.DataSource = TimkiemKH.Load_KH();
            cbb_timten.DisplayMember = "TenKH";
            cbb_timten.ValueMember = "TenKH";

            cbb_timdiachi.DataSource = TimkiemKH.Load_DiaChiKH();
            cbb_timdiachi.DisplayMember = "DiaChi";
            cbb_timdiachi.ValueMember = "DiaChi";
        }

        private void bt_Load_Click(object sender, EventArgs e)
        {
            Process_KhachHang TimkiemKH = new Process_KhachHang();
            dgv_hienthiKH.DataSource = TimkiemKH.Load_KH();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process_KhachHang TimkiemKH = new Process_KhachHang();
            dgv_hienthiKH.DataSource = TimkiemKH.Load_TkiemKHtheoMa(cbb_timma.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process_KhachHang TimkiemKH = new Process_KhachHang();
            dgv_hienthiKH.DataSource = TimkiemKH.Load_TkiemKHtheoTen(cbb_timten.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process_KhachHang TimkiemKH = new Process_KhachHang();
            dgv_hienthiKH.DataSource = TimkiemKH.Load_TkiemKHtheoDiaChi(cbb_timdiachi.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process_KhachHang TimkiemKH = new Process_KhachHang();
            dgv_hienthiKH.DataSource = TimkiemKH.Load_TkiemKHtheoDoTuoi(int.Parse(cbb_timtuoimin.Text),int.Parse(cbb_timtuoimax.Text));
        }
    }
}
