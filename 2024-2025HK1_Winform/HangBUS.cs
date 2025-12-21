using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_2025HK1_Winform
{
    internal class HangBUS
    {
        private HangDAO hangDAO;
        private DataTable listHang,listLoai;
        public HangBUS()
        {
            hangDAO = new HangDAO();
            String sql1 = "SELECT * FROM mathang";
            String sql2 = "SELECT * FROM loaihang";
            listHang = hangDAO.getAll(sql1);
            listLoai = hangDAO.getAll(sql2);
        }
        public DataTable getAllListHang()
        {
            return listHang;
        }
        public DataTable getAllListLoai()
        {
            return listLoai;
        }
        public String getNameByIdLoai(int maloai)
        {
            String rs = "";
            DataRow row= listLoai.AsEnumerable().FirstOrDefault(r => int.Parse(r["MaLoai"].ToString()) == maloai);
            if (row != null) rs = row["TenLoai"].ToString();
            return rs;
        }
        public Boolean UpdateHang(int maHang, string tenHang, string nsx, int soluong, int dongia, string ghiChu)
        {
            String sql = $"UPDATE mathang SET TenHang = '{tenHang}', Ngaysx = '{nsx}', SoLuong = {soluong}," +
                $"DonGia = {dongia}, GhiChu = '{ghiChu}' WHERE MaHang = {maHang}";
            Boolean rs = hangDAO.executeNonQuery(sql) != 0;
            if (rs)
            {
                DataRow row = listHang.AsEnumerable().FirstOrDefault(r => int.Parse(r["MaHang"].ToString()) == maHang);
                if(row != null)
                {
                    row["TenHang"] = tenHang;
                    row["Ngaysx"] = nsx;
                    row["SoLuong"] = soluong;
                    row["DonGia"] = dongia;
                    row["GhiChu"] = ghiChu;
                }
            }
            return rs;
        }
    }
}
