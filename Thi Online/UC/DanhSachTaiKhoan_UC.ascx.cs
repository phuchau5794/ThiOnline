using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BUS;
using System.Data;

public partial class UC_DanhSachTaiKhoan_UC : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            loadTaikhoan();
            
        }
        foreach (GridViewRow row in gridAccount.Rows)
        {
            Button khoa = (Button)row.FindControl("btnLock");
            Button mo = (Button)row.FindControl("btnUnlock");
            Label status = (Label)row.FindControl("Label1");
            nhanvien_BUS bus = new nhanvien_BUS();
            DataTable table = new DataTable();
            table = bus.DSnhanvien_1();

            for (int i = 0; i < table.Rows.Count; i++)
            {

                if (status.Text == "True")
                {
                    khoa.Visible = true;
                    mo.Visible = false;
                }
                else if (status.Text == "False")
                {
                    khoa.Visible = false;
                    mo.Visible = true;
                }
            }
        }
    }

    public void loadTaikhoan()
    {
        DataTable table = new DataTable();
        nhanvien_BUS bus = new nhanvien_BUS();
        table = bus.DSnhanvien_1();
        gridAccount.DataSource = table;
        gridAccount.DataBind();
        foreach (GridViewRow row in gridAccount.Rows)
        {
            Button khoa = (Button)row.FindControl("btnLock");
            Button mo = (Button)row.FindControl("btnUnlock");
            Label status = (Label)row.FindControl("Label1");
            table = bus.DSnhanvien_1();

            for (int i = 0; i < table.Rows.Count; i++)
            {

                if (status.Text == "True")
                {
                    khoa.Visible = true;
                    mo.Visible = false;
                }
                else if (status.Text == "False")
                {
                    khoa.Visible = false;
                    mo.Visible = true;
                }
            }
        }

        
    }

    protected void gridAccount_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        nhanvien_DTO dto = new nhanvien_DTO();
        nhanvien_BUS bus = new nhanvien_BUS();
        dto.MaNV = gridAccount.DataKeys[e.RowIndex].Value.ToString();
        if (!dto.MaNV.Equals(Session["id"].ToString()))
        {
            bool delete = bus.xoataikhoan_1(dto);
            if (delete == true)
            {
                loadTaikhoan();
            }
            else
            {
                lbErr.Text = "Xóa Tài Khoản Không Thành Công !!!";
            }
        }
        else
        {
            Response.Write("<script>alert('Bạn Không Được Xóa Tài Khoản Hiện Đang Đăng Nhập !')</script>");
        }
    }
    protected void gridAccount_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridAccount.PageIndex = e.NewPageIndex;
        loadTaikhoan();
    }
    protected void gridAccount_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        nhanvien_BUS bus = new nhanvien_BUS();
        
        if (e.CommandName == "lock")
        {
            bus.capnhattrangthai_1("lock",e.CommandArgument.ToString());
            loadTaikhoan();
        }
        else if (e.CommandName == "unlock")
        {
            bus.capnhattrangthai_1("unlock", e.CommandArgument.ToString());
            loadTaikhoan();
        }
        //loadTaikhoan();
    }
}