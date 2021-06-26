namespace BTCuoiKi
{
    partial class CapNhatKH
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_MaKH = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_TenKH = new System.Windows.Forms.TextBox();
            this.tb_Tuoi = new System.Windows.Forms.TextBox();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_Load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthiKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_hienthiKH
            // 
            this.dgv_hienthiKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hienthiKH.Location = new System.Drawing.Point(26, 47);
            this.dgv_hienthiKH.Name = "dgv_hienthiKH";
            this.dgv_hienthiKH.RowHeadersWidth = 51;
            this.dgv_hienthiKH.RowTemplate.Height = 24;
            this.dgv_hienthiKH.Size = new System.Drawing.Size(619, 440);
            this.dgv_hienthiKH.TabIndex = 0;
            this.dgv_hienthiKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hienthiKH_CellClick);
            this.dgv_hienthiKH.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgv_hienthiKH_ColumnAdded);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(684, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(760, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(780, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tuổi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(677, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên khách hàng";
            // 
            // tb_MaKH
            // 
            this.tb_MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaKH.Location = new System.Drawing.Point(876, 71);
            this.tb_MaKH.Name = "tb_MaKH";
            this.tb_MaKH.Size = new System.Drawing.Size(196, 34);
            this.tb_MaKH.TabIndex = 5;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DiaChi.Location = new System.Drawing.Point(876, 373);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(196, 34);
            this.tb_DiaChi.TabIndex = 6;
            // 
            // tb_TenKH
            // 
            this.tb_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenKH.Location = new System.Drawing.Point(876, 172);
            this.tb_TenKH.Name = "tb_TenKH";
            this.tb_TenKH.Size = new System.Drawing.Size(196, 34);
            this.tb_TenKH.TabIndex = 6;
            // 
            // tb_Tuoi
            // 
            this.tb_Tuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Tuoi.Location = new System.Drawing.Point(876, 273);
            this.tb_Tuoi.Name = "tb_Tuoi";
            this.tb_Tuoi.Size = new System.Drawing.Size(196, 34);
            this.tb_Tuoi.TabIndex = 7;
            // 
            // bt_sua
            // 
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(355, 527);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(134, 45);
            this.bt_sua.TabIndex = 8;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(70, 527);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(134, 45);
            this.bt_them.TabIndex = 9;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(653, 527);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(134, 45);
            this.bt_xoa.TabIndex = 10;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Location = new System.Drawing.Point(938, 527);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(134, 45);
            this.bt_thoat.TabIndex = 11;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_Load
            // 
            this.bt_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Load.Location = new System.Drawing.Point(41, 12);
            this.bt_Load.Name = "bt_Load";
            this.bt_Load.Size = new System.Drawing.Size(88, 42);
            this.bt_Load.TabIndex = 12;
            this.bt_Load.Text = "Load";
            this.bt_Load.UseVisualStyleBackColor = true;
            this.bt_Load.Click += new System.EventHandler(this.bt_Load_Click);
            // 
            // CapNhatKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 594);
            this.Controls.Add(this.bt_Load);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.tb_Tuoi);
            this.Controls.Add(this.tb_TenKH);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.tb_MaKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_hienthiKH);
            this.Name = "CapNhatKH";
            this.Text = "Cập nhật khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthiKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_hienthiKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_MaKH;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_TenKH;
        private System.Windows.Forms.TextBox tb_Tuoi;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_Load;
    }
}