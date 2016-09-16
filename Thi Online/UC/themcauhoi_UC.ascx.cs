using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;

public partial class UC_themcauhoi_UC : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadDSphanloai();
            loadDSdoituong();
        }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        cauhoi_DTO dto = new cauhoi_DTO();
        cauhoi_BUS bus = new cauhoi_BUS();
        dto.Id = maCH.Text;
        dto.Doituong = dropDoituong.SelectedValue.ToString();
        dto.Phanloai = dropPhanloai.SelectedValue.ToString();
        dto.Noidung = txtNoidung.Text;
        dto.Dapan1 = da1.Text;
        dto.Dapan2 = da2.Text;
        dto.Dapan3 = da3.Text;
        dto.Dapan4 = da4.Text;
        if (rdbA.Checked == true)
        {
            dto.Dapandung = "A";
        }
        else if (rdbB.Checked == true)
        {
            dto.Dapandung = "B";
        }
        else if (rdbC.Checked == true)
        {
            dto.Dapandung = "C";
        }
        else if (rdbD.Checked == true)
        {
            dto.Dapandung = "D";
        }
        bus.themcauhoi_1(dto);
    }

    public void loadDSphanloai()
    {
        cauhoi_BUS bus = new cauhoi_BUS();
        dropPhanloai.DataSource = bus.dsphanloai_1();
        dropPhanloai.DataTextField = "TENPHANLOAI";
        dropPhanloai.DataValueField = "ID_PHANLOAI";
        dropPhanloai.DataBind();
        dropPhanloai.Items.Insert(0, "--Select--");
        
    }

    public void loadDSdoituong()
    {
        cauhoi_BUS bus = new cauhoi_BUS();
        dropDoituong.DataSource = bus.dsdoituong_1();
        dropDoituong.DataTextField = "TENDOITUONG";
        dropDoituong.DataValueField = "MADOITUONG";
        dropDoituong.DataBind();
        dropDoituong.Items.Insert(0,"--Select--");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        txtNoidung.Text = "";
        maCH.Text = "";
        da1.Text = "";
        da2.Text = "";
        da3.Text = "";
        da4.Text = "";
    }
}