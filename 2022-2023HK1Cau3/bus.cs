using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_2023HK1Cau3
{
    internal class bus
    {
        private database db= new database();
        private DataTable dttbNV=  new DataTable();
        private DataTable dttbCV=  new DataTable();
        private DataTable dttbPB=  new DataTable();
        private DataTable dttbMDCV=  new DataTable();
        private DataTable dttbCT=  new DataTable();
        public bus()
        {
            string queryNV = "Select * FROM nhanvien";
            string queryCV = "Select * FROM chucvu";
            string queryPB = "Select * FROM phongban";
            string queryMDCV = "Select * FROM mucdocongviec";
            string queryCT = "Select * FROM chitiet";
            dttbNV = db.getAll(queryNV);
            dttbCV = db.getAll(queryCV);
            dttbPB = db.getAll(queryPB);
            dttbMDCV = db.getAll(queryMDCV);
            dttbCT = db.getAll(queryCT);
        }
        public DataTable getListNV()
        {
            return dttbNV;
        }
        public DataTable getListCV()
        {
            return dttbCV;
        }
        public DataTable getListPB()
        {
            return dttbPB;
        }
        public DataTable getListMDCV()
        {
            return dttbMDCV;
        }
        public DataTable getListCT()
        {
            return dttbCT;
        }
        

    }
}
