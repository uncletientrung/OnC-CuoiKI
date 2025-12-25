namespace ThuatToan
{
    public partial class Form1 : Form
    {
        private Label lb1, lb2;
        private TextBox tx1, tx2;
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(900, 500);
            Panel pnl =  new Panel();

            TableLayoutPanel table = new TableLayoutPanel();
            table.RowCount = 2;
            table.ColumnCount = 2;

            lb1 = new Label { Text = "Nhập mảng" };
            tx1
        }
        
    }
}
