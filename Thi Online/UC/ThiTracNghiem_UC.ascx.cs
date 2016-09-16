using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using DTO;
using BUS;
using DAO;
using System.Xml;

public partial class UC_ThiTracNghiem_UC : System.Web.UI.UserControl
{
    int socaudung;
    int socausai;
    double tongdiem;
    int socauhoi;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!SM1.IsInAsyncPostBack)
        {
            int time = int.Parse(loadTime());
            Session["timeout"] = DateTime.Now.AddMinutes(time).ToString();
        }
        if (Session["dung"] == null)
        {
            Session["dung"] = 0;
        }


        if (Session["diem"] == null)
        {
            Session["diem"] = 0;
        }


        if (Session["sai"] == null)
        {
            Session["sai"] = 0;
        }

        if (!IsPostBack)
        {
            lbName.Text = Session["login"].ToString();
            loadBaithi();
        }
        baithi_BUS bus = new baithi_BUS();
        GridView1.DataSource = bus.loadBaithi_1();
        GridView1.DataBind();
    }

    public string loadTime()
    {
        string path = Server.MapPath("~/Files/ThoiGianLamBai.xml");
        string time = null;
        XmlDocument xmlDoc = new XmlDocument();

        try
        {
            xmlDoc.Load(path);
            XmlElement root = xmlDoc.DocumentElement;
            XmlNode TIME = root.SelectSingleNode("TIME");

            time = TIME.ChildNodes[0].Value;

        }
        catch (Exception ex)
        {
            string str = ex.Message;
        }

        return time;
    }

    public void loadBaithi()
    {
        baithi_BUS bus = new baithi_BUS();
        //DataTable table = bus.loadBaithi_1();
        string madoituong = Request.QueryString["maDT"].ToString();
        DataTable table = bus.loadBaithitheoDT_1(madoituong,int.Parse(loadXml()));
        lbCH.Text = loadXml();
        foreach (GridViewRow row in gridExam.Rows)
        {
            Label stt = (Label)row.FindControl("lbCH");
            for (int i = 0; i < gridExam.Rows.Count; i++)
            {
                stt.Text = i.ToString();
            }
        }
        gridExam.DataSource = table;
        gridExam.DataBind();

    }

    public string dapandung(string maCH)
    {
        SqlConnection conn = connection.Open_Connection();
        string sql = "select DAPANDUNG from CAUHOI where ID_CAUHOI = '" + maCH + "'";
        DataTable table = new DataTable();
        SqlDataAdapter sqlda = new SqlDataAdapter(sql, conn);
        sqlda.Fill(table);
        return table.Rows[0]["DAPANDUNG"].ToString();
    }

    public void tinhdiem()
    {
        baithi_BUS bus = new baithi_BUS();
        DataTable table = bus.loadBaithi_1();

        

        double rate = double.Parse(loadXml());

        double unitScore = 10.0 / rate;
        
        foreach (GridViewRow row in gridExam.Rows)
        {
            Label noidung = (Label)row.FindControl("Label1");
            RadioButton A = (RadioButton)row.FindControl("rdbA");
            RadioButton B = (RadioButton)row.FindControl("rdbB");
            RadioButton C = (RadioButton)row.FindControl("rdbC");
            RadioButton D = (RadioButton)row.FindControl("rdbD");
            Label DA = (Label)row.FindControl("lbDA");
            string DAdung = DA.Text;
            //Session["diem"] = 0;
            //Session["dung"] = 0;
            //Session["sai"] = 0;
            if (A.Checked && DAdung.Equals("A"))
            {

                socaudung = socaudung + 1;
                tongdiem += unitScore;

            }
            else if (B.Checked && DAdung.Equals("B"))
            {

                socaudung = socaudung + 1;
                tongdiem += unitScore;
            }
            else if (C.Checked && DAdung.Equals("C"))
            {

                socaudung = socaudung + 1;
                tongdiem += unitScore;
            }
            else if (D.Checked && DAdung.Equals("D"))
            {

                socaudung = socaudung + 1;
                tongdiem += unitScore;
            }
            else
            {
                socausai += 1;
            }
        }
        socauhoi = int.Parse(loadXml());
    }
    protected void btnEnd_Click(object sender, EventArgs e)
    {
        tinhdiem();
        Session["diem"] = tongdiem;
        Session["dung"] = socaudung;
        Session["sai"] = socausai;
        Session["soCH"] = socauhoi;
        luubaithi();
        cautraloi();
        Response.Redirect("~/ThongKeBaiThi_Page.aspx?diem=" + tongdiem + "&sai=" + socausai + "&dung=" + socaudung + "&tongCH=" + socauhoi);
    }

    public void cautraloi()
    {
        foreach (GridViewRow row in gridExam.Rows)
        {
            Label noidung = (Label)row.FindControl("Label1");
            RadioButton A = (RadioButton)row.FindControl("rdbA");
            RadioButton B = (RadioButton)row.FindControl("rdbB");
            RadioButton C = (RadioButton)row.FindControl("rdbC");
            RadioButton D = (RadioButton)row.FindControl("rdbD");
            Label DA = (Label)row.FindControl("lbDA");
            if (A.Checked)
            {
                Session["Answer"] = A.Text;
            }
            else if (B.Checked)
            {
                Session["Answer"] = B.Text;
            }
            else if (C.Checked)
            {
                Session["Answer"] = C.Text;
            }
            else if (D.Checked)
            {
                Session["Answer"] = D.Text;
            }
        }
    }

    public void luubaithi()
    {
        DataTable table = new DataTable();
        DataRow dr;
        table.Columns.Add("NOIDUNG", typeof(String));
        table.Columns.Add("A", typeof(String));
        table.Columns.Add("B", typeof(String));
        table.Columns.Add("C", typeof(String));
        table.Columns.Add("D", typeof(String));
        table.Columns.Add("DAPANDUNG", typeof(String));
        table.Columns.Add("TRALOI", typeof(String));

        foreach (GridViewRow row in gridExam.Rows)
        {
            Label noidung = (Label)row.FindControl("Label1");
            RadioButton A = (RadioButton)row.FindControl("rdbA");
            RadioButton B = (RadioButton)row.FindControl("rdbB");
            RadioButton C = (RadioButton)row.FindControl("rdbC");
            RadioButton D = (RadioButton)row.FindControl("rdbD");
            Label DA = (Label)row.FindControl("lbDA");
            string select = null;
            if (A.Checked)
            {
                select = A.Text;
            }
            else if (B.Checked)
            {
                select = B.Text;
            }
            else if (C.Checked)
            {
                select = C.Text;
            }
            else if (D.Checked)
            {
                select = D.Text;
            }

            dr = table.NewRow();
            dr[0] = noidung.Text;
            dr[1] = A.Text;
            dr[2] = B.Text;
            dr[3] = C.Text;
            dr[4] = D.Text;
            dr[5] = DA.Text;
            dr[6] = select;

            table.Rows.Add(dr);
        }

        Session["baithi"] = table;
    }

    protected void timer1_Tick(object sender, EventArgs e)
    {
        if (0 > DateTime.Compare(DateTime.Now, DateTime.Parse(Session["timeout"].ToString())))
        {
            lbTime.Text = string.Format("Thời gian còn : 00:{0}:{1}",
            ((Int32)DateTime.Parse(Session["timeout"].ToString()).Subtract(DateTime.Now).TotalMinutes).ToString(),
            ((Int32)DateTime.Parse(Session["timeout"].ToString()).Subtract(DateTime.Now).Seconds).ToString());
        }
        else
        {
            timer1.Enabled = true;
            btnEnd.Focus();
            //btnEnd. = true;
            tinhdiem();
            Session["diem"] = tongdiem;
            Session["dung"] = socaudung;
            Session["sai"] = socausai;
            Session["soCH"] = socauhoi;
            luubaithi();
            cautraloi();
            Response.Redirect("~/ThongKeBaiThi_Page.aspx?diem=" + tongdiem + "&sai=" + socausai + "&dung=" + socaudung + "&tongCH=" + socauhoi);
           // Response.Redirect("~/ThongKeBaiThi_Page.aspx?");
        }
    }

    
    public string loadXml()
    {
        string path = Server.MapPath("~/Files/TiLeDeThi.xml");
        string rate = null;
        XmlDocument xmlDoc = new XmlDocument();
        

        try
        {
            xmlDoc.Load(path);
            XmlElement root = xmlDoc.DocumentElement;
            XmlNode RATE = root.SelectSingleNode("RATE");

            rate = RATE.ChildNodes[0].Value;
            
        }
        catch(Exception ex)
        {
            string str = ex.Message;
        }

        return rate;
    }
}