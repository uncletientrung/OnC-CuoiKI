using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_2023HK1Cau3
{
    internal class GiaoDien : Form
    {
        ComboBox cbb;
        DataGridView dgv;
        TextBox tx1, tx2, tx3, tx4;
        bus nvBUS= new bus();
        DataTable dt;
        private DataTable dttbCV = new DataTable();
        private DataTable dttbPB = new DataTable();
        private DataTable dttbMDCV = new DataTable();
        private DataTable dttbCT = new DataTable();
        public GiaoDien()
        {   
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1000, 400);
            Label lbTitle= new Label { Text ="THỐNG KẾ TIỀN LƯƠNG THEO ĐƠN VỊ"};
            lbTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lbTitle.Dock = DockStyle.Top;

            Panel pnl = new Panel();
            pnl.Dock = DockStyle.Fill;

            FlowLayoutPanel pnlFlowTop = new FlowLayoutPanel();
            Label lbPB = new Label { Text = "Phòng ban" };
            cbb= new ComboBox();
            pnlFlowTop.Controls.Add(lbPB);
            pnlFlowTop.Controls.Add(cbb);
            pnlFlowTop.Dock = DockStyle.Top;

            dgv = new DataGridView();
            dgv.Columns.Add("manv","Mã NV");
            dgv.Columns.Add("honv","Họ NV");
            dgv.Columns.Add("tennv","Tên NV");
            dgv.Columns.Add("sex","Phái");
            dgv.Columns.Add("luong","Lương chính");
            dgv.Columns.Add("phucap","Phụ cấp");
            dgv.Columns.Add("thuclinh","Thực lĩnh");
            dgv.Dock=DockStyle.Fill;

            TableLayoutPanel pnlTable= new TableLayoutPanel();
            pnlTable.RowCount = 4;
            pnlTable.ColumnCount = 2;
            Label lb1 = new Label { Text = "Tổng số nhân viên" };
            tx1= new TextBox();
            Label lb2 = new Label { Text = "Tổng số nữ" };
            tx2= new TextBox();
            Label lb3 = new Label { Text = "Tổng số nam" };
            tx3= new TextBox();
            Label lb4 = new Label { Text = "Tổng số thực lĩnh" };
            tx4= new TextBox();
            pnlTable.Controls.Add(lb1);
            pnlTable.Controls.Add(tx1);
            pnlTable.Controls.Add(lb2);
            pnlTable.Controls.Add(tx2);
            pnlTable.Controls.Add(lb3);
            pnlTable.Controls.Add(tx3);
            pnlTable.Controls.Add(lb4);
            pnlTable.Controls.Add(tx4);
            pnlTable.Dock = DockStyle.Right;

            FlowLayoutPanel pnlButton = new FlowLayoutPanel();
            Button btnIn = new Button { Text ="IN Bảng lương"};
            Button btnThoat = new Button { Text ="Thoát"};
            pnlButton.Controls.Add(btnIn);
            pnlButton.Controls.Add(btnThoat);
            pnlButton.Dock = DockStyle.Bottom;

            pnl.Controls.Add(pnlTable);     // RIGHT
            pnl.Controls.Add(pnlButton);    // BOTTOM
            pnl.Controls.Add(dgv);          // FILL
            pnl.Controls.Add(pnlFlowTop);   // TOP
            pnl.Controls.Add(lbTitle);      // TOP (add sau)

            this.Controls.Add(pnl);

            LoadData();
            LoadCBB();

            // Event
            btnThoat.Click += (obj, e) =>
            {
                this.Close();
            };
            cbb.SelectedIndexChanged += (obj, e) =>
            {
                DataRow rowPB = dttbPB.AsEnumerable().FirstOrDefault(r =>
                    r["tenpb"].ToString() == cbb.Text.ToString());
                if (rowPB != null)
                {
                    LoadData(rowPB["mapb"].ToString());
                }
            };
            btnIn.Click += (obj, e) =>
            {
                DataGridViewRow rowCureent = dgv.CurrentRow;
                string manv= rowCureent.Cells[0].Value.ToString();
                DataRow rowNV=dt.AsEnumerable().FirstOrDefault(r => r["manv"].ToString() == manv);
                if (rowNV != null)
                {
                    DataRow RowCT = dttbCT.AsEnumerable()
                        .FirstOrDefault(r => r["manv"].ToString() == rowNV["manv"].ToString());
                    int luong = (int)RowCT["hsluong"] * 450000;
                    DataRow RowMDCV = dttbMDCV.AsEnumerable()
                        .FirstOrDefault(r => r["mamd"].ToString() == RowCT["mucdocv"].ToString());
                    int phucap = RowMDCV != null ? (int)RowMDCV["tienthuong"] : 0;
                    int thuclinh = luong + phucap;
                    MessageBox.Show($"Nhân viên {rowNV["ho"]} {rowNV["ten"]} - {rowNV["manv"]}" +
                        $"Giới tính: {rowNV["phai"]}, Ngày sinh: {rowNV["ntns"]}, Ngày BD: {rowNV["ngaybd"]}" +
                        $"Lương: {luong}, Phụ cấp: {phucap}, Thực lĩnh: {thuclinh}");
                }
            };
        }
        public void LoadCBB()
        {
            dttbPB = nvBUS.getListPB();
            foreach(DataRow dr in dttbPB.Rows)
            {
                cbb.Items.Add(dr[1].ToString());
            }
            cbb.SelectedIndex = 0;
        }
        public void LoadData(string mapb="01")
        {
            dgv.Rows.Clear();
            int sonvNam = 0;
            int sonvNu = 0;
            int tongTien = 0;
            dt = nvBUS.getListNV();
            dttbCT= nvBUS.getListCT();
            dttbMDCV = nvBUS.getListMDCV();
            foreach(DataRow dr in dt.Rows)
            {
                if (dr["mapb"].ToString() == mapb)
                {
                    DataRow RowCT = dttbCT.AsEnumerable()
                        .FirstOrDefault(r => r["manv"].ToString() == dr["manv"].ToString());
                    int luong = (int)RowCT["hsluong"] * 450000;
                    DataRow RowMDCV = dttbMDCV.AsEnumerable()
                        .FirstOrDefault(r => r["mamd"].ToString() == RowCT["mucdocv"].ToString());
                    int phucap = RowMDCV != null ? (int)RowMDCV["tienthuong"] : 0;
                    int thuclinh = luong + phucap;
                    tongTien += thuclinh;
                    dgv.Rows.Add(
                        dr["manv"],
                        dr["ho"],
                        dr["ten"],
                        dr["phai"],
                        luong,
                        phucap,
                        thuclinh
                    );
                    if (dr["phai"].ToString() == "Nam") sonvNam++;
                    else sonvNu++;
                }
            }
            tx1.Text = (sonvNu + sonvNam).ToString();
            tx2.Text = sonvNu.ToString();
            tx3.Text = sonvNam.ToString();
            tx4.Text = tongTien.ToString();

            
        }
    }
}
