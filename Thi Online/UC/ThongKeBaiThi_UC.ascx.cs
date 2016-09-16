using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using DTO;
using BUS;

public partial class UC_ThongKeBaiThi_UC : System.Web.UI.UserControl
{
    float a;
    float b;
    protected void Page_Load(object sender, EventArgs e)
    {
        lbNgaythi.Text = DateTime.Today.ToString("dd/MM/yyyy");
        lbHoten.Text = Session["login"].ToString();
        if (int.Parse(Session["dung"].ToString()) > 0)
        {
            a = int.Parse(Session["dung"].ToString());
        }
        else
        {
            a = 0;
        }

        b = int.Parse(Session["soCH"].ToString());
        float result = ((a * 100) / b);
        lbRate.Text = result.ToString("00") + "%";
        if (result >= 50)
        {
            lbResult.Text = "Đậu";
        }
        else
        {
            lbResult.Text = "Rớt";
        }
        lbTongdiem.Text = Session["diem"].ToString();
        lbDung.Text = Session["dung"].ToString();
        lbSai.Text = Session["sai"].ToString();
        lbTongCH.Text = Session["soCH"].ToString();

        //Session.Remove("diem");
        //Session.Remove("dung");
        //Session.Remove("sai");

        loadKetqua();
    }

    public void loadKetqua()
    {
        DataTable table = new DataTable();
        table = (DataTable)Session["baithi"];
        gridView.DataSource = table;
        gridView.DataBind();
        foreach (GridViewRow row in gridView.Rows)
        {

            RadioButton A = (RadioButton)row.FindControl("rdbA");
            RadioButton B = (RadioButton)row.FindControl("rdbB");
            RadioButton C = (RadioButton)row.FindControl("rdbC");
            RadioButton D = (RadioButton)row.FindControl("rdbD");
            Label da = (Label)row.FindControl("lbDA");
            Label traloi = (Label)row.FindControl("lbAns");
            string dapan = da.Text;

            if (dapan == "A")
            {

                A.ForeColor = Color.Red;
            }
            if (dapan == "B")
            {

                B.ForeColor = Color.Red;
            }
            if (dapan == "C")
            {

                C.ForeColor = Color.Red;
            }
            if (dapan == "D")
            {

                D.ForeColor = Color.Red;

            }

            if (traloi.Text == A.Text)
            {
                A.Checked = true;
                A.ForeColor = Color.Blue;
            }
            else if (traloi.Text == B.Text)
            {
                B.Checked = true;
                B.ForeColor = Color.Blue;
            }
            else if (traloi.Text == C.Text)
            {
                C.Checked = true;
                C.ForeColor = Color.Blue;
            }
            else if (traloi.Text == D.Text)
            {
                D.Checked = true;
                D.ForeColor = Color.Blue;
            }
        }
    }
    protected void gridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridView.PageIndex = e.NewPageIndex;
        loadKetqua();
    }
    protected void btnView_Click(object sender, EventArgs e)
    {
        gridView.Visible = true;
    }
    protected void btnAccept_Click(object sender, EventArgs e)
    {
        bangdiem_DTO dto = new bangdiem_DTO();
        baithi_BUS bus = new baithi_BUS();

        dto.Id = Session["id"].ToString();
        dto.Tennhanvien = Session["login"].ToString();
        dto.Ngaythi = DateTime.Now;
        dto.Tongdiem = float.Parse(Session["diem"].ToString());

        bool result = bus.luubangdiem(dto);

        if (result == true)
        {
            Response.Write("<script>alert('Lưu Kết Quả Thành Công !')</script>");
        }
        else
        {
            Response.Write("<script>alert('Lưu Kết Quả Thất Bại !')</script>");
        }
    }
}