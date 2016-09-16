using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using System.Data;

public partial class UC_BangDiem_UC : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            xuatbangdiem();
        }
    }

    public void xuatbangdiem()
    {
        baithi_BUS bus = new baithi_BUS();
        DataTable table = new DataTable();
        table = bus.xuatbangdiem_1();
        gridScore.DataSource = table;
        gridScore.DataBind();
    }
    protected void btnSearch_Click(object sender, ImageClickEventArgs e)
    {
        baithi_BUS bus = new baithi_BUS();
        DataTable table = new DataTable();
        int dieukien = int.Parse(dropFilter.SelectedValue);
        table = bus.timkiembangdiem_1(dieukien,txtSearch.Text.ToString());
        gridScore.DataSource = table;
        gridScore.DataBind();
    }
    protected void btnRefresh_Click(object sender, ImageClickEventArgs e)
    {
        xuatbangdiem();
    }
    protected void gridScore_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridScore.PageIndex = e.NewPageIndex;
        xuatbangdiem();
    }
}