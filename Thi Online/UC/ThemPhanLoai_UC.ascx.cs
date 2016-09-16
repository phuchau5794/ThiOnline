using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BUS;
using DAO;
using System.Data;
using System.Data.SqlClient;

public partial class UC_ThemPhanLoai_UC : System.Web.UI.UserControl
{
    string prevPage = String.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            prevPage = Request.UrlReferrer.ToString();
        }
    }
    protected void btnAccept_Click(object sender, EventArgs e)
    {
        phanloai_BUS bus = new phanloai_BUS();
        phanloai_DTO dto = new phanloai_DTO();
        dto.Maphanloai = txtMaPL.Text;
        dto.Tenphanloai = txtTenPL.Text;
        if (txtMaPL.Text == "" || txtMaPL.Text == null)
        {
            lbError.Text = "Vui Lòng Nhập Mã Phân Loại !";
            txtMaPL.Focus();
        }
        else if (txtTenPL.Text == "" || txtTenPL.Text == null)
        {
            lbError.Text = "Vui Lòng Nhập Tên Phân Loại !";
            txtTenPL.Focus();
        }
        else
        {
            bus.themphanloai_1(dto);
        }
    }
    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect(prevPage);
    }
}