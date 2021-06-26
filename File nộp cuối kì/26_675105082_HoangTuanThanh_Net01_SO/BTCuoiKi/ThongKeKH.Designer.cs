namespace BTCuoiKi
{
    partial class ThongKeKH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_hienthiKH = new System.Windows.Forms.DataGridView();
            this.bt_Load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_slKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_TuoiMin = new System.Windows.Forms.TextBox();
            this.tb_TuoiMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_khuvucNN = new System.Windows.Forms.TextBox();
            this.dgv_ThongKeSL_Tuoi = new System.Windows.Forms.DataGridView();
            this.dgv_thongkeKhuVuc = new System.Windows.Forms.DataGridView();
            this.bt_ThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthiKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeSL_Tuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongkeKhuVuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_hienthiKH
            // 
            this.dgv_hienthiKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hienthiKH.Location = new System.Drawing.Point(12, 51);
            this.dgv_hienthiKH.Name = "dgv_hienthiKH";
            this.dgv_hienthiKH.RowHeadersWidth = 51;
            this.dgv_hienthiKH.RowTemplate.Height = 24;
            this.dgv_hienthiKH.Size = new System.Drawing.Size(626, 375);
            this.dgv_hienthiKH.TabIndex = 0;
            // 
            // bt_Load
            // 
            this.bt_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Load.Location = new System.Drawing.Point(33, 12);
            this.bt_Load.Name = "bt_Load";
            this.bt_Load.Size = new System.Drawing.Size(90, 43);
            this.bt_Load.TabIndex = 1;
            this.bt_Load.Text = "Load";
            this.bt_Load.UseVisualStyleBackColor = true;
            this.bt_Load.Click += new System.EventHandler(this.bt_Load_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(669, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số lượng \r\nkhách hàng";
            // 
            // tb_slKH
            // 
            this.tb_slKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_slKH.Location = new System.Drawing.Point(838, 136);
            this.tb_slKH.Name = "tb_slKH";
            this.tb_slKH.Size = new System.Drawing.Size(102, 38);
            this.tb_slKH.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(669, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Độ tuổi từ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(944, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "đến";
            // 
            // tb_TuoiMin
            // 
            this.tb_TuoiMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TuoiMin.Location = new System.Drawing.Point(838, 217);
            this.tb_TuoiMin.Name = "tb_TuoiMin";
            this.tb_TuoiMin.Size = new System.Drawing.Size(74, 38);
            this.tb_TuoiMin.TabIndex = 10;
            // 
            // tb_TuoiMax
            // 
            this.tb_TuoiMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TuoiMax.Location = new System.Drawing.Point(1029, 217);
            this.tb_TuoiMax.Name = "tb_TuoiMax";
            this.tb_TuoiMax.Size = new System.Drawing.Size(74, 38);
            this.tb_TuoiMax.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(669, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 87);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số lượng \r\nkhu vực\r\nkhác nhau\r\n";
            // 
            // tb_khuvucNN
            // 
            this.tb_khuvucNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_khuvucNN.Location = new System.Drawing.Point(838, 333);
            this.tb_khuvucNN.Name = "tb_khuvucNN";
            this.tb_khuvucNN.Size = new System.Drawing.Size(262, 38);
            this.tb_khuvucNN.TabIndex = 13;
            // 
            // dgv_ThongKeSL_Tuoi
            // 
            this.dgv_ThongKeSL_Tuoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKeSL_Tuoi.Location = new System.Drawing.Point(751, 51);
            this.dgv_ThongKeSL_Tuoi.Name = "dgv_ThongKeSL_Tuoi";
            this.dgv_ThongKeSL_Tuoi.RowHeadersWidth = 51;
            this.dgv_ThongKeSL_Tuoi.RowTemplate.Height = 24;
            this.dgv_ThongKeSL_Tuoi.Size = new System.Drawing.Size(10, 10);
            this.dgv_ThongKeSL_Tuoi.TabIndex = 14;
            // 
            // dgv_thongkeKhuVuc
            // 
            this.dgv_thongkeKhuVuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongkeKhuVuc.Location = new System.Drawing.Point(773, 51);
            this.dgv_thongkeKhuVuc.Name = "dgv_thongkeKhuVuc";
            this.dgv_thongkeKhuVuc.RowHeadersWidth = 51;
            this.dgv_thongkeKhuVuc.RowTemplate.Height = 24;
            this.dgv_thongkeKhuVuc.Size = new System.Drawing.Size(10, 10);
            this.dgv_thongkeKhuVuc.TabIndex = 15;
            // 
            // bt_ThongKe
            // 
            this.bt_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThongKe.Location = new System.Drawing.Point(712, 28);
            this.bt_ThongKe.Name = "bt_ThongKe";
            this.bt_ThongKe.Size = new System.Drawing.Size(142, 43);
            this.bt_ThongKe.TabIndex = 16;
            this.bt_ThongKe.Text = "Thống kê";
            this.bt_ThongKe.UseVisualStyleBackColor = true;
            this.bt_ThongKe.Click += new System.EventHandler(this.bt_ThongKe_Click_1);
            // 
            // ThongKeKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 444);
            this.Controls.Add(this.bt_ThongKe);
            this.Controls.Add(this.dgv_thongkeKhuVuc);
            this.Controls.Add(this.dgv_ThongKeSL_Tuoi);
            this.Controls.Add(this.tb_khuvucNN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_TuoiMax);
            this.Controls.Add(this.tb_TuoiMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_slKH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Load);
            this.Controls.Add(this.dgv_hienthiKH);
            this.Name = "ThongKeKH";
            this.Text = "Thống kê khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthiKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeSL_Tuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongkeKhuVuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_hienthiKH;
        private System.Windows.Forms.Button bt_Load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_slKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_TuoiMin;
        private System.Windows.Forms.TextBox tb_TuoiMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_khuvucNN;
        private System.Windows.Forms.DataGridView dgv_ThongKeSL_Tuoi;
        private System.Windows.Forms.DataGridView dgv_thongkeKhuVuc;
        private System.Windows.Forms.Button bt_ThongKe;
    }
}