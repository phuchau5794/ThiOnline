using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class cauhoi_DAO
    {
        public bool xoacauhoi(string id)
        {
            SqlConnection conn = connection.Open_Connection();
            string sql = "delete from CAUHOI where ID_CAUHOI = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql,conn);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable timkiemcauhoi(string id)
        {
            SqlConnection conn = connection.Open_Connection();
            string sql = "select * from CAUHOI where ID_CAUHOI LIKE '%" + id + "%'";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql,conn);
            DataTable table = new DataTable();
            sqlda.Fill(table);
            return table;
        }

        public bool themcauhoi(cauhoi_DTO dto)
        {
            SqlConnection conn = connection.Open_Connection();
            string sql = String.Format("insert into CAUHOI(ID_CAUHOI,NOIDUNG,A,B,C,D,DAPANDUNG,ID_PHANLOAI,MADOITUONG) values('{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}','{6}','{7}','{8}')", dto.Id,dto.Noidung, dto.Dapan1, dto.Dapan2, dto.Dapan3, dto.Dapan4, dto.Dapandung,dto.Phanloai,dto.Doituong);
            SqlCommand cmd = new SqlCommand(sql, conn);
            int n = cmd.ExecuteNonQuery();
            if (n == 1)
            {
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
            
        }

        public void importCauhoi(string maCH,string phanloai, string maDT, string noidung, string a, string b, string c, string d, string dapan)
        {
            string sql = "insert into CAUHOI(ID_CAUHOI,ID_PHANLOAI,MADOITUONG,NOIDUNG,A,B,C,D,DAPANDUNG) values('" + maCH + "','" + phanloai + "','" + maDT + "',N'" + noidung + "',N'" + a + "',N'" + b + "',N'" + c + "',N'" + d + "','" + dapan + "')";
            SqlConnection conn = connection.Open_Connection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable danhsachCH(string maCH)
        {
            DataTable table = new DataTable();
            SqlConnection conn = connection.Open_Connection();
            string sql = "select * from CAUHOI where ID_CAUHOI = '" + maCH + "'";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
            sqlda.Fill(table);
            conn.Close();
            return table;
        }

        public DataTable danhsachimport()
        {
            DataTable table = new DataTable();
            SqlConnection conn = connection.Open_Connection();
            string sql = "select * from CAUHOI";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
            sqlda.Fill(table);
            conn.Close();
            return table;
        }

        public DataTable dsphanloai()
        {
            DataTable table = new DataTable();
            SqlConnection conn = connection.Open_Connection();
            string sql = "select * from PHANLOAI";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
            sqlda.Fill(table);
            conn.Close();
            return table;
        }

        public DataTable dsdoituong()
        {
            DataTable table = new DataTable();
            SqlConnection conn = connection.Open_Connection();
            string sql = "select * from DOITUONG";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
            sqlda.Fill(table);
            conn.Close();
            return table;
        }
    }
}
