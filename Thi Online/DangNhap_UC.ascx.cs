using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;
using DAO;
using DTO;
using BUS;

public partial class UC_DangNhap_UC : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtUser.Focus();
    }


    protected void btnDongY_Click(object sender, EventArgs e)
    {
        nhanvien_BUS bus = new nhanvien_BUS();
        nhanvien_DTO dto = new nhanvien_DTO();
        dto.MaNV = txtUser.Text;
        dto.Matkhau = txtPass.Text;
        if (txtUser.Text == "" && txtPass.Text == "")
        {
            lbErr1.Text = "Tên Đăng Nhập Và Mật Khẩu Không Được Để Trống !";
        }
        else if (txtUser.Text == "")
        {
            lbErr1.Text = "Vui Lòng Nhập Tên Đăng Nhập !";
            txtUser.Focus();
        }
        else if (txtPass.Text == "")
        {
            lbErr1.Text = "Quên Chưa Nhập Mật Khẩu Kìa !";
            txtPass.Focus();
        }
        else
        {
            if (bus.kiemtradangnhap_1(dto))
            {
                Session["id"] = txtUser.Text;
                Session["login"] = bus.getNameByID(dto);
                Session["quyenhan"] = bus.getNameByROLE_1(dto);
                Response.Redirect("~/TrangChu_Page.aspx");

            }
            else
            {
                lbErr1.Text = "Lỗi Đăng Nhập ! Vui Lòng Nhập Chính Xác Thông Tin Tài Khoản.";
            }
        }

        
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