using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BUS;

public partial class UC_ThayDoiMatKhau_UC : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnChange_Click(object sender, EventArgs e)
    {
        nhanvien_DTO dto = new nhanvien_DTO();
        nhanvien_BUS bus = new nhanvien_BUS();
        string username = Session["id"].ToString();
        dto.Matkhau = txtOld.Text;
        bool check = bus.kiemtramatkhau_1(dto);

        if (check == true)
        {
            dto.Matkhau = txtNew.Text;
            dto.MaNV = username;
            if (bus.thaydoimatkhau_1(dto) == true)
            {
                lbError.Text = "Cập Nhật Mật Khẩu Thành Công !";
            }
            else
            {
                
                lbError.Text = "Cập Nhật Mật Khẩu Không Thành Công !";
            }
        }
        else
        {
            lbError.Text = "Mật Khẩu Cũ Không Chính Xác !";
        }
        
    }
}