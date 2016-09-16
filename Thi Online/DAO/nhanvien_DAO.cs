using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace DAO
{
    public class nhanvien_DAO
    {

        public void capnhattrangthai(string trangthai,string id)
        {
            SqlConnection conn = connection.Open_Connection();
            SqlCommand cmd;
            if (trangthai == "lock")
            {
                string sql = "update NHANVIEN set TRANGTHAI = 0 WHERE ID_NHANVIEN = '"+id+"'";
                cmd = new SqlCommand(sql,conn);
                cmd.ExecuteNonQuery();
            }
            else if (trangthai == "unlock")
            {
                string sql = "update NHANVIEN set TRANGTHAI = 1 where ID_NHANVIEN = '"+id+"'";
                cmd = new SqlCommand(sql,conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        public bool checkDuplicate(string id)
        {
            SqlConnection conn = connection.Open_Connection();
            string sql = "select * from NHANVIEN where ID_NHANVIEN  = '"+id+"'";
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

        public void capnhatnhanvien(string maNV, string matkhau, string tenNV, int quyen, string donvi)
        {
            string sql = "update NHANVIEN set MATKHAU = '"+Encrypt(matkhau,true)+"',TENNHANVIEN = N'"+tenNV+"',ID_QUYENHAN = '"+quyen+"',ID_DONVI = '"+donvi+"' where ID_NHANVIEN = '"+maNV+"'";
            SqlConnection conn = connection.Open_Connection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public bool xoataikhoan(nhanvien_DTO dto)
        {
            SqlConnection conn = connection.Open_Connection();
            string sql = "delete from NHANVIEN where ID_NHANVIEN = '" + dto.MaNV + "'";
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

        public bool kiemtramatkhau(nhanvien_DTO dto)
        {
            DataTable table = new DataTable();
            SqlConnection conn = connection.Open_Connection();
            string sql = String.Format("select * from NHANVIEN where MATKHAU = '{0}'", Encrypt(dto.Matkhau, true));
            SqlDataAdapter sqlda = new SqlDataAdapter(sql,conn);
            sqlda.Fill(table);
            conn.Close();
            if (table == null || table.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool thaydoimatkhau(nhanvien_DTO dto)
        {
            SqlConnection conn = connection.Open_Connection();
            string sql = String.Format("update NHANVIEN set MATKHAU = '{0}' where ID_NHANVIEN = '{1}'",Encrypt(dto.Matkhau,true),dto.MaNV);
            SqlCommand cmd = new SqlCommand(sql,conn);
            int n = cmd.ExecuteNonQuery();
            conn.Close();
            if (n == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void importNhanvien(string maNV, string matkhau, string tenNV, int quyen, string donvi)
        {
            string sql = "insert into NHANVIEN(ID_NHANVIEN,MATKHAU,TENNHANVIEN,ID_QUYENHAN,ID_DONVI) values('" + maNV + "','" + Encrypt(matkhau, true) + "',N'" + tenNV + "','" + quyen + "','" + donvi + "')";
            SqlConnection conn = connection.Open_Connection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable danhsachNV(string maNV)
        {
            DataTable table = new DataTable();
            string sql = "select * from NHANVIEN where ID_NHANVIEN = '" + maNV + "'";
            SqlConnection conn = connection.Open_Connection();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
            sqlda.Fill(table);
            conn.Close();
            return table;
        }

        public DataTable danhsachImportNV()
        {
            DataTable table = new DataTable();
            string sql = "select * from NHANVIEN";
            SqlConnection conn = connection.Open_Connection();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
            sqlda.Fill(table);
            conn.Close();
            return table;
        }

        public DataTable xuatDSnhanvien()
        {
            DataTable table = new DataTable();
            SqlConnection conn = connection.Open_Connection();
            string sql = "select * from NHANVIEN";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
            sqlda.Fill(table);
            conn.Close();
            return table;
        }

        public DataTable loadQuyenhan()
        {
            SqlConnection conn = connection.Open_Connection();
            DataTable table = new DataTable();
            string sql = "select * from QUYENHAN";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
            sqlda.Fill(table);
            conn.Close();
            return table;
        }

        public DataTable loadDonvi()
        {
            SqlConnection conn = connection.Open_Connection();
            DataTable table = new DataTable();
            string sql = "select * from DONVI";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
            sqlda.Fill(table);
            conn.Close();
            return table;
        }

        public bool themtaikhoan(nhanvien_DTO dto)
        {
            SqlConnection conn = connection.Open_Connection();
            string sql = String.Format("insert into NHANVIEN(ID_NHANVIEN,MATKHAU,TENNHANVIEN,ID_QUYENHAN,ID_DONVI) values('{0}','{1}',N'{2}','{3}','{4}')", dto.MaNV, Encrypt(dto.Matkhau, true), dto.Tennhanvien, dto.Quyenhan, dto.Donvi);
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

        public bool kiemtradangnhap(nhanvien_DTO dto)
        {
            bool check = false;
            SqlConnection conn = connection.Open_Connection();
            string sql = String.Format("select * from NHANVIEN where ID_NHANVIEN = '{0}' and MATKHAU = '{1}'", dto.MaNV, Encrypt(dto.Matkhau, true));
            DataTable table = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
            sqlda.Fill(table);
            if (table.Rows.Count > 0)
            {
                check = true;
            }
            conn.Close();
            return check;
        }

        public string getNameByID(string id)
        {
            SqlConnection conn = connection.Open_Connection();
            string sql = "select TENNHANVIEN from NHANVIEN where ID_NHANVIEN = '" + id + "'";
            DataTable table = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
            sqlda.Fill(table);
            conn.Close();
            return table.Rows[0][0].ToString();
        }
        public string getNameByQUYEN(string id)
        {
            SqlConnection conn = connection.Open_Connection();
            string sql = "select ID_QUYENHAN from NHANVIEN where ID_NHANVIEN = '" + id + "'";
            DataTable table = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
            sqlda.Fill(table);
            conn.Close();
            return table.Rows[0][0].ToString();
        }
        public DataTable DSnhanvien()
        {
            DataTable table = new DataTable();
            SqlConnection conn = connection.Open_Connection();
            string sql = "select ID_NHANVIEN,TENNHANVIEN,TENDONVI,TRANGTHAI from NHANVIEN A inner join DONVI B on A.ID_DONVI = B.ID_DONVI";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql,conn);
            sqlda.Fill(table);
            conn.Close();
            return table;
        }

        public string kiemtraquyenhan(nhanvien_DTO dto)
        {
            SqlConnection conn = connection.Open_Connection();
            string sql = String.Format("select ID_QUYENHAN from NHANVIEN where ID_NHANVIEN = '{0}' and MATKHAU = '{1}'", dto.MaNV, Encrypt(dto.Matkhau, true));
            DataTable table = new DataTable();
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
            sqlda.Fill(table);
            return table.Rows[0][0].ToString();
        }

        public string Encrypt(string toEncrypt, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);
            if (useHashing)
            {
                var hashMD5 = new MD5CryptoServiceProvider();
                keyArray = hashMD5.ComputeHash(Encoding.UTF8.GetBytes("alvissnguyen"));
            }
            else keyArray = Encoding.UTF8.GetBytes("alvissnguyen");
            var tdes = new TripleDESCryptoServiceProvider
            {
                Key = keyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7,
            };
            ICryptoTransform transform = tdes.CreateEncryptor();
            byte[] resultArray = transform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public string Decrypt(string toDecrypt, bool useHashing)
        {
            byte[] keyArray;
            byte[] toDecryptArray = Convert.FromBase64String(toDecrypt);
            if (useHashing)
            {
                var hashMD5 = new MD5CryptoServiceProvider();
                keyArray = hashMD5.ComputeHash(Encoding.UTF8.GetBytes("alvissnguyen"));
            }
            else keyArray = Encoding.UTF8.GetBytes("alvissnguyen");
            var tdes = new TripleDESCryptoServiceProvider
            {
                Key = keyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7,
            };
            ICryptoTransform transform = tdes.CreateDecryptor();
            byte[] resultArray = transform.TransformFinalBlock(toDecryptArray, 0, toDecryptArray.Length);
            return Encoding.UTF8.GetString(resultArray);
        }
    }
}
