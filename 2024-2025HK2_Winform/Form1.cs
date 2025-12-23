using System.Data;

namespace _2024_2025HK2_Winform
{
    public partial class Form1 : Form
    {
        TextBox txTile, txAuthor, txnxb;
        Button btnThem, btnSua, btnXoa;
        private DataTable listBook;
        private DataGridView dgv;
        private BUS bus = new BUS();
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(800, 400);
            dgv = new DataGridView();
            dgv.Columns.Add("BookId", "Mã sách");
            dgv.Columns.Add("Title", "Tiêu đề");
            dgv.Columns.Add("Author", "Tác giả");
            dgv.Columns.Add("Year", "Năm xuất bản");
            dgv.Dock = DockStyle.Fill;

            TableLayoutPanel table = new TableLayoutPanel();
            table.RowCount = 3;
            table.ColumnCount = 2;
            Label lbTitle = new Label { Text = "Tieu de" };
            Label lbAuthor = new Label { Text = "Tac gia" };
            Label lbnxb = new Label { Text = "Nam xuat ban" };
            txTile = new TextBox();
            txAuthor = new TextBox();
            txnxb = new TextBox();
            table.Controls.Add(lbTitle); table.Controls.Add(txTile);
            table.Controls.Add(lbAuthor); table.Controls.Add(txAuthor);
            table.Controls.Add(lbnxb); table.Controls.Add(txnxb);
            table.Dock = DockStyle.Right;

            FlowLayoutPanel flow = new FlowLayoutPanel();
            btnThem =new Button { Text = "Them"};
            btnSua =new Button { Text = "Sua"};
            btnXoa =new Button { Text = "Xoa"};
            flow.Controls.Add(btnThem);
            flow.Controls.Add(btnSua);
            flow.Controls.Add(btnXoa);
            flow.Dock = DockStyle.Bottom;

            this.Controls.Add(dgv);
            this.Controls.Add(table);
            this.Controls.Add(flow);

            LoadData();
            btnThem.Click += (obj, e) =>
            {
                this.AddBook();
            };
            btnSua.Click += (obj, e) =>
            {
                this.Update();
            };
            btnXoa.Click += (obj, e) =>
            {
                this.Remove();
            };

        }

        public void LoadData()
        {
            listBook = bus.getBook();
            dgv.Rows.Clear();
            foreach(DataRow dr in listBook.Rows)
            {
                dgv.Rows.Add(dr["BookId"], dr["Title"], dr["Author"], dr["YearPublished"]);
            }
            dgv.ClearSelection();
        }
        public void AddBook()
        {
            string title= txTile.Text;
            string author= txAuthor.Text;
            string nxb= txnxb.Text;
            Boolean rs = bus.Insert(title, author, nxb);
            if (rs)
            {
                MessageBox.Show("Thêm thành công");
                LoadData();
            }
        }
        public void Update()
        {
            DataGridViewRow dgvRow = dgv.CurrentRow;
            int maBook = int.Parse(dgvRow.Cells[0].Value.ToString());
            string title= txTile.Text;
            string author= txAuthor.Text;
            string nxb= txnxb.Text;
            Boolean rs = bus.Update(maBook,title, author, nxb);
            if (rs)
            {
                MessageBox.Show("Sửa thành công");
                LoadData();
            }
        }
        public void Remove()
        {
            DataGridViewRow dgvRow = dgv.CurrentRow;
            int maBook = int.Parse(dgvRow.Cells[0].Value.ToString());
            Boolean rs = bus.Remove(maBook);
            if (rs)
            {
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }
    }

}
