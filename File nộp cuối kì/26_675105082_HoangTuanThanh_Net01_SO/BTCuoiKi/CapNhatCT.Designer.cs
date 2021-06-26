namespace BTCuoiKi
{
    partial class CapNhatCT
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
            this.dgv_CongTo = new System.Windows.Forms.DataGridView();
            this.bt_themCT = new System.Windows.Forms.Button();
            this.bt_suaCT = new System.Windows.Forms.Button();
            this.bt_xoaCT = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_maCT = new System.Windows.Forms.TextBox();
            this.tb_loaiCT = new System.Windows.Forms.TextBox();
            this.tb_kichcoCT = new System.Windows.Forms.TextBox();
            this.bt_Load = new System.Windows.Forms.Button();
            this.tb_tinhtrang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CongTo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_CongTo
            // 
            this.dgv_CongTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CongTo.Location = new System.Drawing.Point(23, 39);
            this.dgv_CongTo.Name = "dgv_CongTo";
            this.dgv_CongTo.RowHeadersWidth = 51;
            this.dgv_CongTo.RowTemplate.Height = 24;
            this.dgv_CongTo.Size = new System.Drawing.Size(643, 453);
            this.dgv_CongTo.TabIndex = 0;
            this.dgv_CongTo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CongTo_CellClick);
            // 
            // bt_themCT
            // 
            this.bt_themCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_themCT.Location = new System.Drawing.Point(73, 514);
            this.bt_themCT.Name = "bt_themCT";
            this.bt_themCT.Size = new System.Drawing.Size(167, 48);
            this.bt_themCT.TabIndex = 2;
            this.bt_themCT.Text = "Thêm";
            this.bt_themCT.UseVisualStyleBackColor = true;
            this.bt_themCT.Click += new System.EventHandler(this.bt_themCT_Click);
            // 
            // bt_suaCT
            // 
            this.bt_suaCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_suaCT.Location = new System.Drawing.Point(358, 514);
            this.bt_suaCT.Name = "bt_suaCT";
            this.bt_suaCT.Size = new System.Drawing.Size(167, 48);
            this.bt_suaCT.TabIndex = 3;
            this.bt_suaCT.Text = "Sửa";
            this.bt_suaCT.UseVisualStyleBackColor = true;
            this.bt_suaCT.Click += new System.EventHandler(this.bt_suaCT_Click);
            // 
            // bt_xoaCT
            // 
            this.bt_xoaCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoaCT.Location = new System.Drawing.Point(646, 514);
            this.bt_xoaCT.Name = "bt_xoaCT";
            this.bt_xoaCT.Size = new System.Drawing.Size(167, 48);
            this.bt_xoaCT.TabIndex = 4;
            this.bt_xoaCT.Text = "Xóa";
            this.bt_xoaCT.UseVisualStyleBackColor = true;
            this.bt_xoaCT.Click += new System.EventHandler(this.bt_xoaCT_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(919, 514);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(167, 48);
            this.button5.TabIndex = 5;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(707, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã công tơ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(694, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Loại công tơ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(753, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kích cỡ";
            // 
            // tb_maCT
            // 
            this.tb_maCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_maCT.Location = new System.Drawing.Point(894, 54);
            this.tb_maCT.Name = "tb_maCT";
            this.tb_maCT.Size = new System.Drawing.Size(192, 38);
            this.tb_maCT.TabIndex = 9;
            // 
            // tb_loaiCT
            // 
            this.tb_loaiCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_loaiCT.Location = new System.Drawing.Point(894, 174);
            this.tb_loaiCT.Name = "tb_loaiCT";
            this.tb_loaiCT.Size = new System.Drawing.Size(192, 38);
            this.tb_loaiCT.TabIndex = 10;
            // 
            // tb_kichcoCT
            // 
            this.tb_kichcoCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_kichcoCT.Location = new System.Drawing.Point(894, 302);
            this.tb_kichcoCT.Name = "tb_kichcoCT";
            this.tb_kichcoCT.Size = new System.Drawing.Size(192, 38);
            this.tb_kichcoCT.TabIndex = 11;
            // 
            // bt_Load
            // 
            this.bt_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Load.Location = new System.Drawing.Point(35, 10);
            this.bt_Load.Name = "bt_Load";
            this.bt_Load.Size = new System.Drawing.Size(89, 36);
            this.bt_Load.TabIndex = 12;
            this.bt_Load.Text = "Load";
            this.bt_Load.UseVisualStyleBackColor = true;
            this.bt_Load.Click += new System.EventHandler(this.bt_Load_Click);
            // 
            // tb_tinhtrang
            // 
            this.tb_tinhtrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tinhtrang.Location = new System.Drawing.Point(894, 421);
            this.tb_tinhtrang.Name = "tb_tinhtrang";
            this.tb_tinhtrang.Size = new System.Drawing.Size(192, 38);
            this.tb_tinhtrang.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(753, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tình trạng";
            // 
            // CapNhatCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 585);
            this.Controls.Add(this.tb_tinhtrang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_Load);
            this.Controls.Add(this.tb_kichcoCT);
            this.Controls.Add(this.tb_loaiCT);
            this.Controls.Add(this.tb_maCT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bt_xoaCT);
            this.Controls.Add(this.bt_suaCT);
            this.Controls.Add(this.bt_themCT);
            this.Controls.Add(this.dgv_CongTo);
            this.Name = "CapNhatCT";
            this.Text = "Cập nhật các loại công tơ";
            this.Load += new System.EventHandler(this.CapNhatCT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CongTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CongTo;
        private System.Windows.Forms.Button bt_themCT;
        private System.Windows.Forms.Button bt_suaCT;
        private System.Windows.Forms.Button bt_xoaCT;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_maCT;
        private System.Windows.Forms.TextBox tb_loaiCT;
        private System.Windows.Forms.TextBox tb_kichcoCT;
        private System.Windows.Forms.Button bt_Load;
        private System.Windows.Forms.TextBox tb_tinhtrang;
        private System.Windows.Forms.Label label4;
    }
}