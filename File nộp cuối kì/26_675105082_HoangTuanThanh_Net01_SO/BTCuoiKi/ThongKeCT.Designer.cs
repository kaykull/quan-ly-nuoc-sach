namespace BTCuoiKi
{
    partial class ThongKeCT
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_slCT = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tb_slLoaiCT = new System.Windows.Forms.TextBox();
            this.tb_slCTdangsuachua = new System.Windows.Forms.TextBox();
            this.tb_slCThdTot = new System.Windows.Forms.TextBox();
            this.tb_slCTdangbaoloi = new System.Windows.Forms.TextBox();
            this.dgv_thongkeCT = new System.Windows.Forms.DataGridView();
            this.dgv_thongkeCTsdtot = new System.Windows.Forms.DataGridView();
            this.dgv_thongkeCTdangsuachua = new System.Windows.Forms.DataGridView();
            this.dgv_thongkeCTdangbaoloi = new System.Windows.Forms.DataGridView();
            this.bt_tk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongkeCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongkeCTsdtot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongkeCTdangsuachua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongkeCTdangbaoloi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_hienthi
            // 
            this.dgv_hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hienthi.Location = new System.Drawing.Point(12, 43);
            this.dgv_hienthi.Name = "dgv_hienthi";
            this.dgv_hienthi.RowHeadersWidth = 51;
            this.dgv_hienthi.RowTemplate.Height = 24;
            this.dgv_hienthi.Size = new System.Drawing.Size(656, 497);
            this.dgv_hienthi.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(754, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số lượng công tơ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(754, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 58);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng loại\r\ncông tơ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(754, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 58);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng công tơ\r\nsử dụng tốt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(754, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 58);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng công tơ\r\nđang sửa chữa\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(754, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 87);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số lượng công tơ\r\nđang báo lỗi\r\n\r\n";
            // 
            // tb_slCT
            // 
            this.tb_slCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_slCT.Location = new System.Drawing.Point(980, 105);
            this.tb_slCT.Name = "tb_slCT";
            this.tb_slCT.Size = new System.Drawing.Size(74, 34);
            this.tb_slCT.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(980, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(74, 34);
            this.textBox2.TabIndex = 9;
            // 
            // tb_slLoaiCT
            // 
            this.tb_slLoaiCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_slLoaiCT.Location = new System.Drawing.Point(980, 187);
            this.tb_slLoaiCT.Name = "tb_slLoaiCT";
            this.tb_slLoaiCT.Size = new System.Drawing.Size(74, 34);
            this.tb_slLoaiCT.TabIndex = 9;
            // 
            // tb_slCTdangsuachua
            // 
            this.tb_slCTdangsuachua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_slCTdangsuachua.Location = new System.Drawing.Point(980, 353);
            this.tb_slCTdangsuachua.Name = "tb_slCTdangsuachua";
            this.tb_slCTdangsuachua.Size = new System.Drawing.Size(74, 34);
            this.tb_slCTdangsuachua.TabIndex = 10;
            // 
            // tb_slCThdTot
            // 
            this.tb_slCThdTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_slCThdTot.Location = new System.Drawing.Point(980, 266);
            this.tb_slCThdTot.Name = "tb_slCThdTot";
            this.tb_slCThdTot.Size = new System.Drawing.Size(74, 34);
            this.tb_slCThdTot.TabIndex = 10;
            // 
            // tb_slCTdangbaoloi
            // 
            this.tb_slCTdangbaoloi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_slCTdangbaoloi.Location = new System.Drawing.Point(980, 450);
            this.tb_slCTdangbaoloi.Name = "tb_slCTdangbaoloi";
            this.tb_slCTdangbaoloi.Size = new System.Drawing.Size(74, 34);
            this.tb_slCTdangbaoloi.TabIndex = 11;
            // 
            // dgv_thongkeCT
            // 
            this.dgv_thongkeCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongkeCT.Location = new System.Drawing.Point(722, 42);
            this.dgv_thongkeCT.Name = "dgv_thongkeCT";
            this.dgv_thongkeCT.RowHeadersWidth = 51;
            this.dgv_thongkeCT.RowTemplate.Height = 24;
            this.dgv_thongkeCT.Size = new System.Drawing.Size(10, 10);
            this.dgv_thongkeCT.TabIndex = 12;
            // 
            // dgv_thongkeCTsdtot
            // 
            this.dgv_thongkeCTsdtot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongkeCTsdtot.Location = new System.Drawing.Point(738, 42);
            this.dgv_thongkeCTsdtot.Name = "dgv_thongkeCTsdtot";
            this.dgv_thongkeCTsdtot.RowHeadersWidth = 51;
            this.dgv_thongkeCTsdtot.RowTemplate.Height = 24;
            this.dgv_thongkeCTsdtot.Size = new System.Drawing.Size(10, 10);
            this.dgv_thongkeCTsdtot.TabIndex = 13;
            // 
            // dgv_thongkeCTdangsuachua
            // 
            this.dgv_thongkeCTdangsuachua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongkeCTdangsuachua.Location = new System.Drawing.Point(754, 42);
            this.dgv_thongkeCTdangsuachua.Name = "dgv_thongkeCTdangsuachua";
            this.dgv_thongkeCTdangsuachua.RowHeadersWidth = 51;
            this.dgv_thongkeCTdangsuachua.RowTemplate.Height = 24;
            this.dgv_thongkeCTdangsuachua.Size = new System.Drawing.Size(10, 10);
            this.dgv_thongkeCTdangsuachua.TabIndex = 14;
            this.dgv_thongkeCTdangsuachua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thongkeCTdangsuachua_CellContentClick);
            // 
            // dgv_thongkeCTdangbaoloi
            // 
            this.dgv_thongkeCTdangbaoloi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thongkeCTdangbaoloi.Location = new System.Drawing.Point(770, 52);
            this.dgv_thongkeCTdangbaoloi.Name = "dgv_thongkeCTdangbaoloi";
            this.dgv_thongkeCTdangbaoloi.RowHeadersWidth = 51;
            this.dgv_thongkeCTdangbaoloi.RowTemplate.Height = 24;
            this.dgv_thongkeCTdangbaoloi.Size = new System.Drawing.Size(10, 10);
            this.dgv_thongkeCTdangbaoloi.TabIndex = 15;
            // 
            // bt_tk
            // 
            this.bt_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tk.Location = new System.Drawing.Point(722, 12);
            this.bt_tk.Name = "bt_tk";
            this.bt_tk.Size = new System.Drawing.Size(133, 51);
            this.bt_tk.TabIndex = 16;
            this.bt_tk.Text = "Thống kê";
            this.bt_tk.UseVisualStyleBackColor = true;
            this.bt_tk.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ThongKeCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 552);
            this.Controls.Add(this.bt_tk);
            this.Controls.Add(this.dgv_thongkeCTdangbaoloi);
            this.Controls.Add(this.dgv_thongkeCTdangsuachua);
            this.Controls.Add(this.dgv_thongkeCTsdtot);
            this.Controls.Add(this.dgv_thongkeCT);
            this.Controls.Add(this.tb_slCTdangbaoloi);
            this.Controls.Add(this.tb_slCThdTot);
            this.Controls.Add(this.tb_slCTdangsuachua);
            this.Controls.Add(this.tb_slLoaiCT);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tb_slCT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_hienthi);
            this.Name = "ThongKeCT";
            this.Text = "Thống kê công tơ";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongkeCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongkeCTsdtot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongkeCTdangsuachua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thongkeCTdangbaoloi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_hienthi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_slCT;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tb_slLoaiCT;
        private System.Windows.Forms.TextBox tb_slCTdangsuachua;
        private System.Windows.Forms.TextBox tb_slCThdTot;
        private System.Windows.Forms.TextBox tb_slCTdangbaoloi;
        private System.Windows.Forms.DataGridView dgv_thongkeCT;
        private System.Windows.Forms.DataGridView dgv_thongkeCTsdtot;
        private System.Windows.Forms.DataGridView dgv_thongkeCTdangsuachua;
        private System.Windows.Forms.DataGridView dgv_thongkeCTdangbaoloi;
        private System.Windows.Forms.Button bt_tk;
    }
}