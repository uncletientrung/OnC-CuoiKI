namespace _2024_2025HK1CLC_Winform
{
    partial class ChiTietDonHang
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
            label1 = new Label();
            btnUpdate = new Button();
            btnAdd = new Button();
            label3 = new Label();
            a = new Label();
            label4 = new Label();
            txQuantity = new TextBox();
            txPrice = new TextBox();
            txName = new TextBox();
            dgv = new DataGridView();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(608, 12);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "lbMaDonHang";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(168, 272);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(87, 272);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(496, 130);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 10;
            label3.Text = "Price";
            // 
            // a
            // 
            a.AutoSize = true;
            a.Location = new Point(496, 96);
            a.Name = "a";
            a.Size = new Size(53, 15);
            a.TabIndex = 11;
            a.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(496, 62);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 12;
            label4.Text = "Product Name";
            // 
            // txQuantity
            // 
            txQuantity.Location = new Point(587, 93);
            txQuantity.Name = "txQuantity";
            txQuantity.Size = new Size(195, 23);
            txQuantity.TabIndex = 9;
            // 
            // txPrice
            // 
            txPrice.Location = new Point(587, 130);
            txPrice.Name = "txPrice";
            txPrice.Size = new Size(195, 23);
            txPrice.TabIndex = 8;
            // 
            // txName
            // 
            txName.Location = new Point(587, 59);
            txName.Name = "txName";
            txName.Size = new Size(195, 23);
            txName.TabIndex = 7;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(24, 12);
            dgv.Name = "dgv";
            dgv.Size = new Size(466, 241);
            dgv.TabIndex = 6;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(249, 272);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 14;
            btnRemove.Text = "Xóa";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // ChiTietDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(807, 315);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(a);
            Controls.Add(label4);
            Controls.Add(txQuantity);
            Controls.Add(txPrice);
            Controls.Add(txName);
            Controls.Add(dgv);
            Controls.Add(label1);
            Name = "ChiTietDonHang";
            Text = "ChiTietDonHang";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label3;
        private Label a;
        private Label label4;
        private TextBox txQuantity;
        private TextBox txPrice;
        private TextBox txName;
        private DataGridView dgv;
        private Button btnRemove;
    }
}