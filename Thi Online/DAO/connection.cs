using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAO
{
    public class connection
    {
        public static SqlConnection Open_Connection()
        {
            string sqlConnectionString = "server=.;database=THIONLINE;Integrated Security = true";
            //string sqlConnectionString = "server=192.168.59.3\\SQL;database=THIONLINE;uid=read;pwd=qwertyuiop";
            SqlConnection conn = new SqlConnection(sqlConnectionString);
            conn.Open();
            return conn;
        }
    }
}
