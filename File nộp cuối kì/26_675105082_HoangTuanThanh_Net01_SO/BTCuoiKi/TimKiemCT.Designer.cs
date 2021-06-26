namespace BTCuoiKi
{
    partial class TimKiemCT
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
            this.dgv_hienthi = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_timkiemCTtheoMaCT = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbb_MaCT = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_LoaiCT = new System.Windows.Forms.ComboBox();
            this.cbb_KichCo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_TinhTrang = new System.Windows.Forms.ComboBox();
            this.check_loai = new System.Windows.Forms.CheckBox();
            this.check_kichco = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_hienthi
            // 
            this.dgv_hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hienthi.Location = new System.Drawing.Point(13, 55);
            this.dgv_hienthi.Name = "dgv_hienthi";
            this.dgv_hienthi.RowHeadersWidth = 51;
            this.dgv_hienthi.RowTemplate.Height = 24;
            this.dgv_hienthi.Size = new System.Drawing.Size(670, 492);
            this.dgv_hienthi.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_timkiemCTtheoMaCT
            // 
            this.bt_timkiemCTtheoMaCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiemCTtheoMaCT.Location = new System.Drawing.Point(715, 38);
            this.bt_timkiemCTtheoMaCT.Name = "bt_timkiemCTtheoMaCT";
            this.bt_timkiemCTtheoMaCT.Size = new System.Drawing.Size(224, 36);
            this.bt_timkiemCTtheoMaCT.TabIndex = 2;
            this.bt_timkiemCTtheoMaCT.Text = "Tìm kiếm theo mã";
            this.bt_timkiemCTtheoMaCT.UseVisualStyleBackColor = true;
            this.bt_timkiemCTtheoMaCT.Click += new System.EventHandler(this.bt_timkiemCTtheoMaCT_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(715, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 77);
            this.button2.TabIndex = 3;
            this.button2.Text = "Tìm kiếm theo loại Công tơ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbb_MaCT
            // 
            this.cbb_MaCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_MaCT.FormattingEnabled = true;
            this.cbb_MaCT.Location = new System.Drawing.Point(850, 89);
            this.cbb_MaCT.Name = "cbb_MaCT";
            this.cbb_MaCT.Size = new System.Drawing.Size(210, 37);
            this.cbb_MaCT.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(715, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 72);
            this.button3.TabIndex = 5;
            this.button3.Text = "Tìm kiếm theo tình trạng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(771, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã";
            // 
            // cbb_LoaiCT
            // 
            this.cbb_LoaiCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LoaiCT.FormattingEnabled = true;
            this.cbb_LoaiCT.Location = new System.Drawing.Point(850, 257);
            this.cbb_LoaiCT.Name = "cbb_LoaiCT";
            this.cbb_LoaiCT.Size = new System.Drawing.Size(210, 37);
            this.cbb_LoaiCT.TabIndex = 9;
            // 
            // cbb_KichCo
            // 
            this.cbb_KichCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_KichCo.FormattingEnabled = true;
            this.cbb_KichCo.Location = new System.Drawing.Point(850, 313);
            this.cbb_KichCo.Name = "cbb_KichCo";
            this.cbb_KichCo.Size = new System.Drawing.Size(210, 37);
            this.cbb_KichCo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(709, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tình trạng";
            // 
            // cbb_TinhTrang
            // 
            this.cbb_TinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TinhTrang.FormattingEnabled = true;
            this.cbb_TinhTrang.Location = new System.Drawing.Point(850, 477);
            this.cbb_TinhTrang.Name = "cbb_TinhTrang";
            this.cbb_TinhTrang.Size = new System.Drawing.Size(210, 37);
            this.cbb_TinhTrang.TabIndex = 12;
            // 
            // check_loai
            // 
            this.check_loai.AutoSize = true;
            this.check_loai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_loai.Location = new System.Drawing.Point(715, 261);
            this.check_loai.Name = "check_loai";
            this.check_loai.Size = new System.Drawing.Size(81, 33);
            this.check_loai.TabIndex = 13;
            this.check_loai.Text = "Loại";
            this.check_loai.UseVisualStyleBackColor = true;
            // 
            // check_kichco
            // 
            this.check_kichco.AutoSize = true;
            this.check_kichco.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_kichco.Location = new System.Drawing.Point(714, 315);
            this.check_kichco.Name = "check_kichco";
            this.check_kichco.Size = new System.Drawing.Size(114, 33);
            this.check_kichco.TabIndex = 14;
            this.check_kichco.Text = "Kích cỡ";
            this.check_kichco.UseVisualStyleBackColor = true;
            // 
            // TimKiemCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 578);
            this.Controls.Add(this.check_kichco);
            this.Controls.Add(this.check_loai);
            this.Controls.Add(this.cbb_TinhTrang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbb_KichCo);
            this.Controls.Add(this.cbb_LoaiCT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbb_MaCT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_timkiemCTtheoMaCT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_hienthi);
            this.Name = "TimKiemCT";
            this.Text = "Tìm kiếm công tơ";
            this.Load += new System.EventHandler(this.TimKiemCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_hienthi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_timkiemCTtheoMaCT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbb_MaCT;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_LoaiCT;
        private System.Windows.Forms.ComboBox cbb_KichCo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_TinhTrang;
        private System.Windows.Forms.CheckBox check_loai;
        private System.Windows.Forms.CheckBox check_kichco;
    }
}