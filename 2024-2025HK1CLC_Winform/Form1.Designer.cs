namespace _2024_2025HK1CLC_Winform
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
            dgv = new DataGridView();
            txName = new TextBox();
            txPhone = new TextBox();
            txEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 12);
            dgv.Name = "dgv";
            dgv.Size = new Size(466, 241);
            dgv.TabIndex = 0;
            // 
            // txName
            // 
            txName.Location = new Point(575, 28);
            txName.Name = "txName";
            txName.Size = new Size(195, 23);
            txName.TabIndex = 1;
            // 
            // txPhone
            // 
            txPhone.Location = new Point(575, 99);
            txPhone.Name = "txPhone";
            txPhone.Size = new Size(195, 23);
            txPhone.TabIndex = 2;
            // 
            // txEmail
            // 
            txEmail.Location = new Point(575, 62);
            txEmail.Name = "txEmail";
            txEmail.Size = new Size(195, 23);
            txEmail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(496, 31);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 4;
            label1.Text = "Client Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(496, 65);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(496, 99);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "Phone";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(75, 272);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(156, 272);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(237, 272);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Xóa";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            btnView.Location = new Point(318, 272);
            btnView.Name = "btnView";
            btnView.Size = new Size(160, 23);
            btnView.TabIndex = 5;
            btnView.Text = "Xem đơn hàng";
            btnView.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(807, 307);
            Controls.Add(btnView);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txEmail);
            Controls.Add(txPhone);
            Controls.Add(txName);
            Controls.Add(dgv);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private TextBox txName;
        private TextBox txPhone;
        private TextBox txEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnView;
    }
}
