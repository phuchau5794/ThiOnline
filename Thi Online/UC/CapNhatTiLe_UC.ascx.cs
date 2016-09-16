using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;
using System.Text;
using DTO;
using BUS;

public partial class UC_CapNhatTiLe_UC : System.Web.UI.UserControl
{
    string rate;
    string time;
    protected void Page_Load(object sender, EventArgs e)
    {
        recentRate.Text = loadXml();
        recentTime.Text = loadTime();
        rate = loadXml();
        time = loadTime();
    }
    protected void btnChange_Click(object sender, EventArgs e)
    {
        
        
        if (changeRate.Text == null || changeRate.Text == "")
        {
            if (changeTime.Text == null || changeTime.Text == "")
            {
                capnhattilebaithi(recentRate.Text, recentTime.Text);
              //  capnhatthoigian(recentTime.Text);
            }
            else
            {
                capnhattilebaithi(recentRate.Text, changeTime.Text);
              //  capnhatthoigian(changeTime.Text);
            }
        }
        else 
            if (changeTime.Text == null || changeTime.Text == "")
            {
               // capnhatthoigian(recentTime.Text);
                capnhattilebaithi(changeRate.Text, recentTime.Text);
              }
              else
             {
                 capnhattilebaithi(changeRate.Text, changeTime.Text);
           // capnhatthoigian(changeTime.Text);
              }
        
        Response.Redirect("~/TrangChu_Page.aspx");
    }

    public void capnhattilebaithi(string tile, string thoigian)
    {
        string path = Server.MapPath("~/Files/TiLeDeThi.xml");
        XmlDocument myXmlDoc = new XmlDocument();
        myXmlDoc.Load(path);
        XmlNode node = myXmlDoc.DocumentElement;
        foreach (XmlNode node1 in node.ChildNodes)
        {
            if (node1.Name == "RATE")
            {
                node1.InnerText = tile;
            }
            if (node1.Name == "TIME")
            {
                node1.InnerText = thoigian;
            }
        }
        string file = Server.MapPath("~/Files/TiLeDeThi.xml");
        myXmlDoc.Save(file);
    }

    public void capnhatthoigian(string thoigian)
    {
        string path = Server.MapPath("~/Files/ThoiGianLamBai.xml");
        XmlDocument myXmlDoc = new XmlDocument();
        myXmlDoc.Load(path);
        XmlNode node = myXmlDoc.DocumentElement;
        foreach (XmlNode node1 in node.ChildNodes)
        {
            if (node1.Name == "TIME")
            {
                node1.InnerText = thoigian;
            }
        }
        string file = Server.MapPath("~/Files/ThoiGianLamBai.xml");
        myXmlDoc.Save(file);
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
        catch (Exception ex)
        {
            string str = ex.Message;
        }

        return rate;
    }

    public string loadTime()
    {
        string path = Server.MapPath("~/Files/TiLeDeThi.xml");
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
}