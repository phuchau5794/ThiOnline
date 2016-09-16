using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BUS;
using DTO;

public partial class UC_DanhSachCH_UC : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            danhsachcauhoi();
        }
    }

    public void danhsachcauhoi()
    {
        DataTable table = new DataTable();
        cauhoi_BUS bus = new cauhoi_BUS();
        table = bus.danhsachimport_1();
        gridCauHoi.DataSource = table;
        gridCauHoi.DataBind();
    }
    protected void gridCauHoi_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridCauHoi.PageIndex = e.NewPageIndex;
        danhsachcauhoi();
    }
    protected void btnSearch_Click(object sender, ImageClickEventArgs e)
    {
        DataTable table = new DataTable();
        cauhoi_BUS bus = new cauhoi_BUS();
        cauhoi_DTO dto = new cauhoi_DTO();
        dto.Id = txtSearch.Text;
        table = bus.timkiemcauhoi_1(dto);
        gridCauHoi.DataSource = table;
        gridCauHoi.DataBind();
    }
    protected void btnRefresh_Click(object sender, ImageClickEventArgs e)
    {
        danhsachcauhoi();
    }

    
    protected void gridCauHoi_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        cauhoi_BUS bus = new cauhoi_BUS();
        string id = gridCauHoi.DataKeys[e.RowIndex].Value.ToString();
        bool result = bus.xoacauhoi_1(id);
        if (result == true)
        {
            Label1.Visible = true;
            Label1.Text = "Xóa Thành Công !";
            danhsachcauhoi();
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "Xóa Thất Bại !";
        }
    }
}