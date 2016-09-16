using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class donvi_DAO
    {
        public void importDonvi(string id,string tendonvi,string diachi)
        {
            SqlConnection conn = connection.Open_Connection();
            string sql = "insert into DONVI values('"+id+"',N'"+tendonvi+"',N'"+diachi+"')";
            
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable dsDonviTheoID(string id)
        {
            DataTable table = new DataTable();
            string sql = "select * from DONVI where ID_DONVI = '" + id + "'";
            SqlConnection conn = connection.Open_Connection();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql,conn);
            sqlda.Fill(table);
            conn.Close();
            return table;
        }

        public DataTable dsImportDonvi()
        {
            DataTable table = new DataTable();
            string sql = "select * from DONVI";
            SqlConnection conn = connection.Open_Connection();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql,conn);
            sqlda.Fill(table);
            conn.Close();
            return table;
        }

        public void capnhatDonvi(string id, string tendonvi,string diachi)
        {
            SqlConnection conn = connection.Open_Connection();
            //string sql = "if exists(select * from DONVI where ID_DONVI = '" + id + "')" +
            //             "begin" +
            //             "update DONVI set TENDONVI = N'" + tendonvi + "', DIACHIDONVI = N'" + diachi + "' where ID_DONVI = '" + id + "'" +
            //             "end" 
            //    ;
            string sql = "update DONVI set TENDONVI = N'" + tendonvi + "', DIACHIDONVI = N'" + diachi + "' where ID_DONVI = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public bool checkDuplicate(string id)
        {
            SqlConnection conn = connection.Open_Connection();
            string sql = "select * from DONVI where ID_DONVI = '" + id + "'";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql,conn);
            DataTable table = new DataTable();
            sqlda.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
