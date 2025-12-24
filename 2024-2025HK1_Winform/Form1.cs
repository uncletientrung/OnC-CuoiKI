using System.Data;

namespace _2024_2025HK1_Winform
{
    public partial class Form1 : Form
    {
        private HangBUS hangBUS= new HangBUS();
        private DataTable listHang, listLoai;
        public Form1()
        {
            InitializeComponent();
            txMaHang.Enabled = false;
            LoadCBB();
            LoadDGV();
            btnSua.Click += (obj, v) =>
            {
                SuaHang();
            };
            btnLoc.Click += (obj, v) =>
            {
                locDGV();
            };
            btnRefresh.Click += (obj, v) =>
            {
                lamMoi();
            };
            SelectedRow();
        }
        public void LoadDGV(String cbbText = "Tất cả loại")
        {
            listHang = hangBUS.getAllListHang();
            dgv.Rows.Clear();
            foreach(DataRow row in listHang.Rows)
            {
                String tenloai = hangBUS.getNameByIdLoai(int.Parse(row["MaLoai"].ToString()));
                if(tenloai == cbbText || cbbText == "Tất cả loại")
                {
                    dgv.Rows.Add(row[1], row[2],tenloai, row[3], row[4], row[5], row[6]);
                }
            }
            dgv.ClearSelection();
        }
        public void LoadCBB()
        {
            cbb.Items.Add("Tất cả loại");
            listLoai = hangBUS.getAllListLoai();
            foreach(DataRow row in listLoai.Rows)
            {
                cbb.Items.Add(row[1]);
            }
            cbb.SelectedIndex = 0;
        }
        public void locDGV()
        {
            string cbbText = cbb.Text;
            LoadDGV(cbbText);
        }
        public void SuaHang()
        {
            int maH = int.Parse(txMaHang.Text);
            int soluong = int.Parse(txSoLuong.Text);
            int dongia = int.Parse(txDonGia.Text);
            string tenhang = txTenHang.Text;
            string nsx = txNSX.Text;
            string ghichu = txGhiChu.Text;
            Boolean rs = hangBUS.UpdateHang(maH, tenhang, nsx, soluong, dongia, ghichu);
            if(rs)
            {
                string cbbText=cbb.Text;
                LoadDGV(cbbText);
            }
        }
        public void lamMoi()
        {
            LoadDGV();
            txDonGia.Clear();
            txGhiChu.Clear();
            txMaHang.Clear();
            txTenHang.Clear();
            txSoLuong.Clear();
            txNSX.Clear();
            txTenHang.Focus();
        }
        public void SelectedRow()
        {
            dgv.CellClick += (obj, e) =>
            {
                DataGridViewRow row = dgv.CurrentRow;
                if (row != null)
                {
                    txMaHang.Text = row.Cells["MaHang"].Value.ToString();
                    txTenHang.Text = row.Cells["TenHang"].Value.ToString();
                    txNSX.Text = row.Cells["nsx"].Value.ToString();
                    txSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                    txDonGia.Text = row.Cells["DonGia"].Value.ToString();
                    txGhiChu.Text = row.Cells["GhiChu"].Value.ToString();
                }
            };
        }
    }
}
