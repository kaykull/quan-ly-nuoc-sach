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
    public partial class CapNhatCT : Form
    {
        public CapNhatCT()
        {
            InitializeComponent();
        }

        private void bt_timCT_Click(object sender, EventArgs e)
        {
            Process_CongTo congto = new Process_CongTo();
            dgv_CongTo.DataSource = congto.Load_TkiemCT(tb_maCT.Text);
        }
        private void bt_themCT_Click(object sender, EventArgs e)
        {
            Process_CongTo congto = new Process_CongTo();
            congto.Them_CongTo(tb_maCT.Text, tb_loaiCT.Text, tb_kichcoCT.Text,tb_tinhtrang.Text);
            dgv_CongTo.DataSource = congto.Load_CongTo();
        }
        private void bt_suaCT_Click(object sender, EventArgs e)
        {
            Process_CongTo congto = new Process_CongTo();
            congto.Sua_CongTo(tb_maCT.Text, tb_loaiCT.Text, tb_kichcoCT.Text,tb_tinhtrang.Text);
            dgv_CongTo.DataSource = congto.Load_CongTo();
        }

        private void bt_xoaCT_Click(object sender, EventArgs e)
        {
            Process_CongTo congto = new Process_CongTo();
            congto.Xoa_CongTo(tb_maCT.Text);
            dgv_CongTo.DataSource = congto.Load_CongTo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgv_CongTo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dgv_CongTo.CurrentRow.Index;
            tb_maCT.Text = dgv_CongTo.Rows[x].Cells[0].Value.ToString();
            tb_loaiCT.Text = dgv_CongTo.Rows[x].Cells[1].Value.ToString();
            tb_kichcoCT.Text = dgv_CongTo.Rows[x].Cells[2].Value.ToString();
            tb_tinhtrang.Text = dgv_CongTo.Rows[x].Cells[3].Value.ToString();
        }

        private void bt_Load_Click(object sender, EventArgs e)
        {
            Process_CongTo congto = new Process_CongTo();
            dgv_CongTo.DataSource = congto.Load_CongTo();
        }

        private void CapNhatCT_Load(object sender, EventArgs e)
        {

        }
    }
}
