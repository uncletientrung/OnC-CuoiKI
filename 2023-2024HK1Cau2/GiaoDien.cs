using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_2024HK1Cau2
{
    internal class GiaoDien : Form
    {
        TextBox tx1, tx2, tx3, tx4, tx5;
        public GiaoDien()
        {
            this.Text = "Frm tiền điện";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            TableLayoutPanel pnlTable = new TableLayoutPanel();
            pnlTable.RowCount = 5;
            pnlTable.ColumnCount = 2;
            pnlTable.Dock= DockStyle.Fill;

            Label lb1= new Label();
            lb1.Text = "Chỉ số cũ";
            lb1.TextAlign=ContentAlignment.MiddleLeft;
            tx1 = new TextBox();
            tx1.Dock = DockStyle.Fill;

            Label lb2= new Label();
            lb2.Text = "Chỉ số mới";
            lb2.TextAlign=ContentAlignment.MiddleLeft;
            tx2 = new TextBox();
            tx2.Dock = DockStyle.Fill;

            Label lb3= new Label();
            lb3.Text = "Số tiền tiêu thụ";
            lb3.TextAlign=ContentAlignment.MiddleLeft;
            tx3 = new TextBox();
            tx3.Dock = DockStyle.Fill;

            Label lb4= new Label();
            lb4.Text = "Thành tiền";
            lb4.TextAlign=ContentAlignment.MiddleLeft;
            tx4 = new TextBox();
            tx4.Dock = DockStyle.Fill;

            Label lb5= new Label();
            lb5.Text = "Tiền sau thuế";
            lb5.TextAlign=ContentAlignment.MiddleLeft;
            tx5 = new TextBox();
            tx5.Dock = DockStyle.Fill;

            Button btnTinh= new Button { Text = "Tính"};
            Button btnTiepTuc= new Button { Text = "Tiếp tục"};
            Button btnThoat= new Button { Text = "Thoát"};

            pnlTable.Controls.Add(lb1 );
            pnlTable.Controls.Add(tx1 );
            pnlTable.Controls.Add(lb2 );
            pnlTable.Controls.Add(tx2 );
            pnlTable.Controls.Add(lb3 );
            pnlTable.Controls.Add(tx3 );
            pnlTable.Controls.Add(lb4 );
            pnlTable.Controls.Add(tx4 );
            pnlTable.Controls.Add(lb5 );
            pnlTable.Controls.Add(tx5 );

            TableLayoutPanel pnlButton = new TableLayoutPanel();
            pnlButton.RowCount = 1;
            pnlButton.ColumnCount = 5;
            pnlButton.Dock = DockStyle.Bottom;
            pnlButton.Height = 60;
            Label lblhide1 = new Label { Text = "" };
            Label lblhide2 = new Label { Text = "" };
            pnlButton.Controls.Add(btnTinh, 1, 0);
            pnlButton.Controls.Add(btnTiepTuc, 2, 0);
            pnlButton.Controls.Add(btnThoat, 3, 0);
            pnlButton.Controls.Add(lblhide1, 0, 0);
            pnlButton.Controls.Add(lblhide2, 4, 0);

            tx3.Enabled = false;
            tx4.Enabled = false;
            tx5.Enabled = false;

            btnTinh.Click += (obj, e) =>
            {
                TinhTien();
            };
            btnTiepTuc.Click += (obj, e) =>
            {
                Continue();
            };
            btnThoat.Click += (obj, e) =>
            {
                this.Close();
            };

            this.Controls.Add(pnlTable);
            this.Controls.Add(pnlButton);
        }
        public void TinhTien()
        {
            int soCu = int.Parse(tx1.Text.ToString());
            int soMoi = int.Parse(tx2.Text.ToString());
            int soTieuThu =  soMoi - soCu;
            int thanhTien = 0;
            tx3.Text= soTieuThu.ToString();
            if(soTieuThu >=0 && soTieuThu <= 50) {
                thanhTien = soTieuThu * 1806;
            }else if(soTieuThu <= 100)
            {
                soTieuThu = soTieuThu - 50;
                thanhTien = 50 * 1806 + soTieuThu * 1866;
            }else if(soTieuThu <= 200)
            {
                soTieuThu = soTieuThu - 100;
                thanhTien = 50 * 1806 + 50 * 1866 + soTieuThu * 2167;
            }
            tx4.Text = thanhTien.ToString();
            tx5.Text = (thanhTien + thanhTien * 10 / 100).ToString();
        }
        public void Continue()
        {
            tx1.Clear(); tx2.Clear(); tx3.Clear(); tx4.Clear(); tx5.Clear();
        }
    }
}
