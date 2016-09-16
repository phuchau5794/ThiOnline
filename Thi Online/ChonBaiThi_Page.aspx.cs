using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BUS;

public partial class ChonBaiThi_Page : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadDetai();
        }
    }

    public void loadDetai()
    {
        DataTable table = new DataTable();
        baithi_BUS bus = new baithi_BUS();
        table = bus.loadDetai_1();
        dropLoaiBT.DataSource = table;
        dropLoaiBT.DataTextField = "TENDOITUONG";
        dropLoaiBT.DataValueField = "MADOITUONG";
        dropLoaiBT.DataBind();
    }
    string madoituong = null;
    protected void btnGo_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("~/ThiTracNghiem_Page.aspx?maDT=" + dropLoaiBT.SelectedValue);
    }
    protected void dropLoaiBT_SelectedIndexChanged(object sender, EventArgs e)
    {
        madoituong = dropLoaiBT.SelectedValue;
    }
}