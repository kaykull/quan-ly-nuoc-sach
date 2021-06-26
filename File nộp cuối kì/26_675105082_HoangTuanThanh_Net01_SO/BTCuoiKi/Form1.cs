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
    public partial class MenuQL : Form
    {
        public MenuQL()
        {
            InitializeComponent();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatKH tk = new CapNhatKH();
            tk.Show();
        }

        private void côngTơToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatCT congto = new CapNhatCT();
            congto.Show();
        }

        private void tiêuThụNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatTTN TTN = new CapNhatTTN();
            TTN.Show();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongKeKH KH = new ThongKeKH();
            KH.Show();
        }

        private void côngTơToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongKeCT CT = new ThongKeCT();
            CT.Show();
        }

        private void tiêuThụNướcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongKeTTN TTN = new ThongKeTTN();
            TTN.Show();
        }

        private void kháchHàngToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TimKiemKH KH = new TimKiemKH();
            KH.Show();
        }

        private void côngTơToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TimKiemCT CT = new TimKiemCT();
            CT.Show();
        }

        private void tiêuThụNướcToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TimKiemTTN TTN = new TimKiemTTN();
            TTN.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TroGiup TG = new TroGiup();
            TG.Show();
        }

        private void bảnQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanQuyen BQ = new BanQuyen();
            BQ.Show();
        }
    }
}
