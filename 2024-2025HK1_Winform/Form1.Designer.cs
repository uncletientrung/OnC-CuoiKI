namespace _2024_2025HK1_Winform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRefresh = new Button();
            btnLoc = new Button();
            btnSua = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txTenHang = new TextBox();
            txNSX = new TextBox();
            txMaHang = new TextBox();
            dgv = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txDonGia = new TextBox();
            txGhiChu = new TextBox();
            txSoLuong = new TextBox();
            cbb = new ComboBox();
            MaHang = new DataGridViewTextBoxColumn();
            TenHang = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            nsx = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(249, 314);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 14;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnLoc
            // 
            btnLoc.Location = new Point(168, 314);
            btnLoc.Name = "btnLoc";
            btnLoc.Size = new Size(75, 23);
            btnLoc.TabIndex = 15;
            btnLoc.Text = "Lọc";
            btnLoc.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(87, 314);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(508, 141);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 10;
            label3.Text = "Ngày sx";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(508, 107);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 11;
            label2.Text = "Tên hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(508, 73);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 12;
            label1.Text = "Mã hàng";
            // 
            // txTenHang
            // 
            txTenHang.Location = new Point(587, 104);
            txTenHang.Name = "txTenHang";
            txTenHang.Size = new Size(195, 23);
            txTenHang.TabIndex = 9;
            // 
            // txNSX
            // 
            txNSX.Location = new Point(587, 141);
            txNSX.Name = "txNSX";
            txNSX.Size = new Size(195, 23);
            txNSX.TabIndex = 8;
            // 
            // txMaHang
            // 
            txMaHang.Location = new Point(587, 70);
            txMaHang.Name = "txMaHang";
            txMaHang.Size = new Size(195, 23);
            txMaHang.TabIndex = 7;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { MaHang, TenHang, TenLoai, nsx, SoLuong, DonGia, GhiChu });
            dgv.Location = new Point(24, 54);
            dgv.Name = "dgv";
            dgv.Size = new Size(466, 241);
            dgv.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(508, 246);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 20;
            label4.Text = "Ghi chú";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(508, 212);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 21;
            label5.Text = "Đơn giá";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(508, 178);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 22;
            label6.Text = "Số lượng";
            // 
            // txDonGia
            // 
            txDonGia.Location = new Point(587, 209);
            txDonGia.Name = "txDonGia";
            txDonGia.Size = new Size(195, 23);
            txDonGia.TabIndex = 19;
            // 
            // txGhiChu
            // 
            txGhiChu.Location = new Point(587, 246);
            txGhiChu.Name = "txGhiChu";
            txGhiChu.Size = new Size(195, 23);
            txGhiChu.TabIndex = 18;
            // 
            // txSoLuong
            // 
            txSoLuong.Location = new Point(587, 175);
            txSoLuong.Name = "txSoLuong";
            txSoLuong.Size = new Size(195, 23);
            txSoLuong.TabIndex = 17;
            // 
            // cbb
            // 
            cbb.FormattingEnabled = true;
            cbb.Location = new Point(119, 16);
            cbb.Name = "cbb";
            cbb.Size = new Size(209, 23);
            cbb.TabIndex = 23;
            // 
            // MaHang
            // 
            MaHang.HeaderText = "Mã hàng";
            MaHang.Name = "MaHang";
            // 
            // TenHang
            // 
            TenHang.HeaderText = "Tên hàng";
            TenHang.Name = "TenHang";
            // 
            // TenLoai
            // 
            TenLoai.HeaderText = "Tên loại";
            TenLoai.Name = "TenLoai";
            // 
            // nsx
            // 
            nsx.HeaderText = "Ngày sản xuất";
            nsx.Name = "nsx";
            // 
            // SoLuong
            // 
            SoLuong.HeaderText = "Số lượng";
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.HeaderText = "Đơn giá";
            DonGia.Name = "DonGia";
            // 
            // GhiChu
            // 
            GhiChu.HeaderText = "Ghi Chú";
            GhiChu.Name = "GhiChu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 350);
            Controls.Add(cbb);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txDonGia);
            Controls.Add(txGhiChu);
            Controls.Add(txSoLuong);
            Controls.Add(btnRefresh);
            Controls.Add(btnLoc);
            Controls.Add(btnSua);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txTenHang);
            Controls.Add(txNSX);
            Controls.Add(txMaHang);
            Controls.Add(dgv);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private Button btnLoc;
        private Button btnSua;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txTenHang;
        private TextBox txNSX;
        private TextBox txMaHang;
        private DataGridView dgv;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txDonGia;
        private TextBox txGhiChu;
        private TextBox txSoLuong;
        private ComboBox cbb;
        private DataGridViewTextBoxColumn MaHang;
        private DataGridViewTextBoxColumn TenHang;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn nsx;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn GhiChu;
    }
}
