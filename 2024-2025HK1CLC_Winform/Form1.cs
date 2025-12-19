using System.ComponentModel;
using System.Data;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _2024_2025HK1CLC_Winform
{
    public partial class Form1 : Form
    {
        private BUS bus = new BUS();
        private DataTable dtClient;
        private DataTable dtOrderItem;
        private BindingList<OrderItem> listOrderItem;
        public Form1()
        {
            InitializeComponent();
            dgv.Columns.Add("id", "Client ID");
            dgv.Columns.Add("name", "Client Name");
            dgv.Columns.Add("email", "Client Email");
            dgv.Columns.Add("phone", "Client Phone");
            this.LoadData();
            btnAdd.Click += (obj, e) =>
            {
                addClient();
            };
            btnUpdate.Click += (obj, e) =>
            {
                updateClient();
            };
            btnRemove.Click += (obj, e) =>
            {
                removeClient();
            };
            dgv.CellClick += (obj, e) =>
            {
                DataGridViewRow rowCurrent = dgv.CurrentRow;
                txName.Text = rowCurrent.Cells[1].Value.ToString();
                txEmail.Text = rowCurrent.Cells[2].Value.ToString();
                txPhone.Text = rowCurrent.Cells[3].Value.ToString();
            };
            btnView.Click += (obj, e) =>
            {
                ChiTietDonHang chiTietDonHangform = new ChiTietDonHang();
                chiTietDonHangform.ShowDialog();
            };
        }

        private void Dgv_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void LoadData()
        {
            dgv.Rows.Clear();
            dtClient = bus.getAllClients();
            foreach(DataRow row in dtClient.Rows)
            {
                dgv.Rows.Add(row[0], row[1], row[2], row[3]);
            }
        }
        public void addClient()
        {
            if(txName.Text.Length > 0 && txEmail.Text.Length >0 && txPhone.Text.Length > 0)
            {
                string name= txName.Text;
                string email= txEmail.Text;
                string phone= txPhone.Text;
                Boolean reuslt= bus.addClient(name, email, phone);
                if (reuslt)
                {
                    txName.Clear();
                    txEmail.Clear();
                    txPhone.Clear();
                    LoadData();
                }
            }
        }
        public void removeClient()
        {
            DataGridViewRow rowCurrent = dgv.CurrentRow;
            int maClient = int.Parse(rowCurrent.Cells[0].Value.ToString());
            Boolean reuslt = bus.removeClient(maClient);
            if (reuslt)
            {
                txName.Clear();
                txEmail.Clear();
                txPhone.Clear();
                LoadData();
            }
        }
        public void updateClient()
        {
            if (txName.Text.Length > 0 && txEmail.Text.Length > 0 && txPhone.Text.Length > 0)
            {
                string name = txName.Text;
                string email = txEmail.Text;
                string phone = txPhone.Text;
                DataGridViewRow rowCurrent = dgv.CurrentRow;
                int maClient = int.Parse(rowCurrent.Cells[0].Value.ToString());
                Boolean reuslt = bus.updateClient(maClient,name, email, phone);
                if (reuslt)
                {
                    txName.Clear();
                    txEmail.Clear();
                    txPhone.Clear();
                    LoadData();
                }
            }
        }


    }
}
