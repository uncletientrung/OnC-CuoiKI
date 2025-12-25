using System.Linq.Expressions;

namespace ThuatToan
{
    public partial class Form1 : Form
    {
        private Label lb1, lb2;
        private TextBox tx1, tx2;
        Button btnFibonaci, btnDaoNguoc, btnSapXep, btnGiaThua;
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(500, 200);
            Panel pnl =  new Panel();

            TableLayoutPanel table = new TableLayoutPanel();
            table.RowCount = 2;
            table.ColumnCount = 2;

            lb1 = new Label { Text = "Nhập mảng" };
            tx1 = new TextBox();
            tx1.Size = new Size(300, tx1.Height);
            lb2 = new Label { Text = "Kết quả" };
            tx2 = new TextBox();
            tx2.Size = new Size(300, tx2.Height);
            table.Controls.Add(lb1);
            table.Controls.Add(tx1);
            table.Controls.Add(lb2);
            table.Controls.Add(tx2);
            table.Dock = DockStyle.Fill;

            FlowLayoutPanel flow = new FlowLayoutPanel();
            btnFibonaci = new Button { Text = "Fibonaci" };
            btnDaoNguoc = new Button { Text = "Đảo ngược" };
            btnSapXep = new Button { Text = "Sắp xếp tăng dần" };
            btnGiaThua = new Button { Text = "Đệ quy" };
            flow.Controls.Add(btnFibonaci);
            flow.Controls.Add(btnDaoNguoc);
            flow.Controls.Add(btnSapXep);
            flow.Controls.Add(btnGiaThua);
            flow.Dock = DockStyle.Bottom;

            pnl.Controls.Add(table);
            pnl.Controls.Add(flow);
            pnl.Dock = DockStyle.Fill;
            this.Controls.Add(pnl);

            btnFibonaci.Click += (obj, e) =>
            {
                Fibonaci();
            };
            btnDaoNguoc.Click += (obj, e) =>
            {
                DaoNguoc();
            };
            btnSapXep.Click += (obj, e) =>
            {
                Sort();
            };
            btnGiaThua.Click += (obj, e) =>
            {
                Dequy();
            };
        }
        public void PrintKQ(int[] arr)
        {
            tx2.Clear();
            foreach(int i in arr)
            {
                tx2.Text += i.ToString() + " "; 
            }
        }
        public void Fibonaci()
        {
            int soluong = int.Parse(tx1.Text.ToString());
            if (soluong <= 0) return;
            int[] result = new int[soluong];
            result[0] = 0;
            if(soluong >1) result[1] = 1;
            for (int i =2; i< soluong; i++)
            {
                result[i] = result[i-2] + result[i-1];
            }
            PrintKQ(result);
        }
        public void DaoNguoc()
        {
            string Text = tx1.Text.ToString();
            int[] arrSo =Text.Split(' ').Select(so => int.Parse(so)).ToArray();
            int[] rs = new int[arrSo.Length];
            for(int i = 0; i< arrSo.Length; i++)
            {
                rs[arrSo.Length - i -1] = arrSo[i];
            }
            PrintKQ(rs);
            // Cách 2
            //rs = arrSo.Reverse().ToArray();
        }
        public void Sort()
        {
            int[] arr = tx1.Text.ToString().Split(' ').Select(so => int.Parse(so)).ToArray();
            for(int i = 0;  i < arr.Length; i++)
            {
                for(int j =i +1; j< arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            PrintKQ(arr);
            // Cách 2
            //Array.Sort(arr);
        }
        public int GiaThua(int so)
        {
            if (so == 0 || so == 1) return 1;
            return so * GiaThua(so - 1);
        }
        public void Dequy()
        {
            int[] arr = tx1.Text.ToString().Split(' ').Select(so => int.Parse(so)).ToArray();
            if (arr.Length != 2) return;
            int x = arr[0];
            int n = arr[1];
            double rs = 0;
            for(int i =0; i< n; i++)
            {
                rs += (double)(Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1)) / GiaThua(2 * i + 1);
            }
            tx2.Clear();
            tx2.Text = rs + "";
        }
        
    }
}
