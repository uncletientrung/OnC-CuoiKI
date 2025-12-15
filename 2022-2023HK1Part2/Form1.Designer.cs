namespace _2022_2023HK1Part2
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
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            btnClose = new Button();
            btnXoa = new Button();
            btnTinh = new Button();
            txYear = new TextBox();
            txLaiSuat = new TextBox();
            txTienGui = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnTinh);
            panel1.Controls.Add(txYear);
            panel1.Controls.Add(txLaiSuat);
            panel1.Controls.Add(txTienGui);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(8, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 398);
            panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(19, 209);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(220, 143);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(181, 165);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(100, 165);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTinh
            // 
            btnTinh.Location = new Point(19, 165);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(75, 23);
            btnTinh.TabIndex = 3;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // txYear
            // 
            txYear.Location = new Point(100, 116);
            txYear.Name = "txYear";
            txYear.Size = new Size(127, 23);
            txYear.TabIndex = 2;
            // 
            // txLaiSuat
            // 
            txLaiSuat.Location = new Point(100, 81);
            txLaiSuat.Name = "txLaiSuat";
            txLaiSuat.Size = new Size(127, 23);
            txLaiSuat.TabIndex = 2;
            // 
            // txTienGui
            // 
            txTienGui.Location = new Point(100, 52);
            txTienGui.Name = "txTienGui";
            txTienGui.Size = new Size(127, 23);
            txTienGui.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 117);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 1;
            label4.Text = "Năm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 82);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 1;
            label3.Text = "Lãi xuất năm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 52);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Tiền gửi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 22);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Tính lãi xuất";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox richTextBox1;
        private Button btnClose;
        private Button btnXoa;
        private Button btnTinh;
        private TextBox txYear;
        private TextBox txLaiSuat;
        private TextBox txTienGui;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
