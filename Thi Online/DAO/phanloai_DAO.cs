using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class phanloai_DAO
    {
        public void themphanloai(string maphanloai, string tenphanloai)
        {
            SqlConnection conn = connection.Open_Connection();
            string sql = String.Format("insert into PHANLOAI(ID_PHANLOAI,TENPHANLOAI) values('{0}','{1}')", maphanloai, tenphanloai);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
