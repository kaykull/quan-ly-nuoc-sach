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
    public partial class TimKiemCT : Form
    {
        public TimKiemCT()
        {
            InitializeComponent();
            Process_CongTo TimkiemCT = new Process_CongTo();
            cbb_MaCT.DataSource = TimkiemCT.Load_CongTo();
            cbb_MaCT.DisplayMember = "MaCT";
            cbb_MaCT.ValueMember = "MaCT";

            cbb_LoaiCT.DataSource = TimkiemCT.Load_LoaiCT();
            cbb_LoaiCT.DisplayMember = "LoaiCT";
            cbb_LoaiCT.ValueMember = "LoaiCT";

            cbb_KichCo.DataSource = TimkiemCT.Load_KichCoCT();
            cbb_KichCo.DisplayMember = "KichCo";
            cbb_KichCo.ValueMember = "KichCo";

            cbb_TinhTrang.DataSource = TimkiemCT.Load_TinhTrangCT();
            cbb_TinhTrang.DisplayMember = "TinhTrangSD";
            cbb_TinhTrang.ValueMember = "TinhTrangSD";

        }

        private void TimKiemCT_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process_CongTo TimkiemCT = new Process_CongTo();
            dgv_hienthi.DataSource = TimkiemCT.Load_CongTo();
        }

        private void bt_timkiemCTtheoMaCT_Click(object sender, EventArgs e)
        {
            Process_CongTo TimkiemCT = new Process_CongTo();
            dgv_hienthi.DataSource = TimkiemCT.Load_TimkiemCTtheoMaCT(cbb_MaCT.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process_CongTo TimkiemCT = new Process_CongTo();
            if (check_kichco.Checked == true && check_loai.Checked == true) 
                dgv_hienthi.DataSource = TimkiemCT.Load_TimkiemCTtheoLoaiCT2(cbb_LoaiCT.Text, cbb_KichCo.Text);
            else
            {
                if (check_kichco.Checked == true)
                    dgv_hienthi.DataSource = TimkiemCT.Load_TimkiemCTtheoLoaiCTKich(cbb_KichCo.Text);
                else if (check_loai.Checked == true)
                    dgv_hienthi.DataSource = TimkiemCT.Load_TimkiemCTtheoLoaiCTLoai(cbb_LoaiCT.Text);
                else
                    dgv_hienthi.DataSource = TimkiemCT.Load_CongTo();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process_CongTo TimkiemCT = new Process_CongTo();
            dgv_hienthi.DataSource = TimkiemCT.Load_TimkiemCTtheoLoaiCTtheoTinhTrang(cbb_TinhTrang.Text);
        }
    }
}
