using System.Data.SqlTypes;

namespace _2022_2023HK1Part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void TinhTien()
        {
            float tienGui = int.Parse(txTienGui.Text.ToString());
            float tienLai = int.Parse(txLaiSuat.Text.ToString());
            float year = int.Parse(txYear.Text.ToString());
            richTextBox1.AppendText($"Năm\tTiền thu được gốc và lãi\n");
            for (int i = 0; i<year; i++)
            {
                float result = tienGui * tienLai / 100;
                richTextBox1.AppendText($"{i + 1}\t{(tienGui + result).ToString("0.00")}\n");
                tienGui = tienGui + result;
            }

        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            TinhTien();
        }
    }
}
