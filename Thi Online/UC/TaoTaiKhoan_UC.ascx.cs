using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BUS;
using System.Data;

public partial class UC_TaoTaiKhoan_UC : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadQuyenhan();
            loadDonvi();

        }
        txtID.Focus();
    }
    protected void btnAccept_Click(object sender, EventArgs e)
    {
        nhanvien_BUS bus = new nhanvien_BUS();
        nhanvien_DTO dto = new nhanvien_DTO();
        dto.MaNV = txtID.Text;
        dto.Matkhau = txtPass.Text;
        dto.Tennhanvien = txtFullname.Text;
        dto.Quyenhan = Int32.Parse(dropRole.SelectedValue);
        dto.Donvi = dropUnit.SelectedValue;
        if (txtID.Text == "" || txtID.Text == null)
        {
            lbError.Text = "Vui Lòng Nhập ID Đăng Nhập !";
            txtID.Focus();
        }
        else if (txtPass.Text == "" || txtPass.Text == null)
        {
            lbError.Text = "Vui Lòng Nhập Mật Khẩu !";
            txtPass.Focus();
        }
        else if (txtFullname.Text == "" || txtFullname.Text == null)
        {
            lbError.Text = "Vui Lòng Nhập Họ Tên !";
            txtFullname.Focus();
        }
        else
        {
            if (bus.checkDuplicate_1(dto))
            {
                lbError.Text = "ID Đã Tồn Tại. Vui Lòng Nhập ID khác !";
            }
            else
            {
                if (bus.themtaikhoan_1(dto))
                {

                    Response.Write("<script type='text/javascript'>alert('Tạo Tài Khoản Thành Công !')</script>");
                }
                else
                {
                    Response.Write("<script type='text/javascript'>alert('Tạo Tài Khoản Không Thành Công !')</script>");
                }
            }
            
        }
        
    }

    public void loadQuyenhan()
    {
        nhanvien_BUS bus = new nhanvien_BUS();
        DataTable table = new DataTable();
        table = bus.loadQuyenhan_1();
        dropRole.DataSource = table;
        dropRole.DataTextField = "TENQUYENHAN";
        dropRole.DataValueField = "ID_QUYENHAN";
        dropRole.DataBind();
    }

    public void loadDonvi()
    {
        nhanvien_BUS bus = new nhanvien_BUS();
        DataTable table = new DataTable();
        table = bus.loadDonvi_1();
        dropUnit.DataSource = table;
        dropUnit.DataTextField = "TENDONVI";
        dropUnit.DataValueField = "ID_DONVI";
        dropUnit.DataBind();
    }
}