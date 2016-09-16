using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace DAO
{
    public class baithi_DAO
    {
        

        public void capnhattilebaithi(string tile)
        {
            XmlDocument myXmlDoc = new XmlDocument();
            myXmlDoc.Load("~/Files/TileBaiThi.xml");
            XmlNode node = myXmlDoc.DocumentElement;
            foreach(XmlNode node1 in node.ChildNodes)
            {
                if (node1.Name == "RATE")
                {
                    node1.InnerText = tile;
                }
            }
            myXmlDoc.Save("~/Files/TileBaiThi.xml");
        }

        public DataTable loadBaithi()
        {
            
            SqlConnection conn = connection.Open_Connection();
            DataTable table = new DataTable();
            string sql = "select top 10 * from CAUHOI order by NEWID()";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
            sqlda.Fill(table);
            conn.Close();
            return table;
        }

        

        public DataTable loadBaithitheoDT(string doituong,int tile)
        {
            SqlConnection conn = connection.Open_Connection();
            DataTable table = new DataTable();
            string sql = "select top "+ tile +" * from CAUHOI where MADOITUONG LIKE '%" + doituong + "%' order by NEWID()";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
            sqlda.Fill(table);
            conn.Close();
            return table;
        }

        public bool luubangdiem(bangdiem_DTO dto)
        {
            SqlConnection conn = connection.Open_Connection();
            string sql = String.Format("insert into BANGDIEM(ID_NHANVIEN,TENNHANVIEN,NGAYTHI,TONGDIEM) values('{0}',N'{1}','{2}','{3}')",dto.Id,dto.Tennhanvien,dto.Ngaythi,dto.Tongdiem);
            SqlCommand cmd = new SqlCommand(sql,conn);
            int n = cmd.ExecuteNonQuery();
            if (n == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable xuatbangdiem()
        {
            DataTable table = new DataTable();
            SqlConnection conn = connection.Open_Connection();
            string sql = "select * from BANGDIEM";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql,conn);
            sqlda.Fill(table);
            conn.Close();
            return table;
        }

        public DataTable timkiembangdiem(int dieukien, string timkiem)
        {
            DataTable table = new DataTable();
            SqlConnection conn = connection.Open_Connection();
            
            if (dieukien == 1)
            {
                string sql = "select * from BANGDIEM where TENNHANVIEN LIKE N'%"+timkiem+"%'";
                SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
                sqlda.Fill(table);
            }
            if (dieukien == 2)
            {
                string sql = "select * from BANGDIEM where ID_NHANVIEN LIKE '%" + timkiem + "%'";
                SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
                sqlda.Fill(table);
            }
            if (dieukien == 3)
            {
                string sql = "select * from BANGDIEM where NGAYTHI = '" + DateTime.Parse(timkiem) + "'";
                SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
                sqlda.Fill(table);
            }
            
            return table;
        }

        public DataTable loadDetai()
        {
            SqlConnection conn = connection.Open_Connection();
            DataTable table = new DataTable();
            string sql = "select * from DOITUONG";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql,conn);
            sqlda.Fill(table);
            return table;
        }
    }
}
