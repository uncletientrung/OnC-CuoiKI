using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_2025HK2_Winform
{
    internal class BUS
    {
        private BookDAO bDAO;
        private DataTable listBook, listBorrow;
        public BUS()
        {
            bDAO = new BookDAO();
            String sqlBook = "SELECT * FROM books";
            String sqlBorrow= "SELECT * FROM muonsach";
            listBook = bDAO.getAll(sqlBook);
            listBorrow = bDAO.getAll(sqlBorrow);
        }
        public DataTable getBook()
        {
            return listBook;
        }
        public Boolean Insert(string title, string author, string year)
        {
            if (title == "" || author == "" || year == "") return false;
            int YearPublished =  int.Parse(year);
            int maNEW = 1;
            if(listBook.Rows.Count > 0)
            {
                maNEW = listBook.AsEnumerable().Max(row => int.Parse(row["BookId"].ToString())) + 1;
            }
            String sql = $"INSERT INTO books(BookId, Title, Author, YearPublished) VALUES " +
                $"({maNEW}, '{title}', '{author}', {YearPublished} )";
            Boolean rs = bDAO.executeNonQuery(sql) !=0;
            if (rs)
            {
                listBook.Rows.Add(maNEW, title, author, YearPublished);
            }
            return rs;
        }
        public Boolean Update(int mabook, string title, string author, string year)
        {
            if (title == "" || author == "" || year == "") return false;
            int YearPublished =  int.Parse(year);
            String sql = $"UPDATE books SET Title ='{title}', Author ='{author}', " +
                $"YearPublished ={YearPublished} WHERE BookId = {mabook}";
            Boolean rs = bDAO.executeNonQuery(sql) !=0;
            if (rs)
            {
                DataRow dr= listBook.AsEnumerable().FirstOrDefault(r => int.Parse(r["BookId"].ToString()) == mabook);
                if (dr != null)
                {
                    dr["Title"]= title;
                    dr["Author"] = author;
                    dr["YearPublished"] = YearPublished;
                }
            }
            return rs;
        }
        public Boolean Remove(int mabook)
        {
            Boolean rs = listBorrow.AsEnumerable().FirstOrDefault(r => int.Parse(r["BookId"].ToString()) == mabook) == null;
            if (rs)
            {
                String sql = $"DELETE FROM books WHERE BookId = {mabook}";
                bDAO.executeNonQuery(sql);
                DataRow dr= listBook.AsEnumerable().FirstOrDefault(r => int.Parse(r["BookId"].ToString()) == mabook);
                if (dr != null)
                {
                    listBook.Rows.Remove(dr);
                }
            }
            return rs;
        }
    }
}
