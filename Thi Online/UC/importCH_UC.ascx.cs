using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using DTO;
using BUS;

public partial class UC_importCH_UC : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnImport_Click(object sender, EventArgs e)
    {
        DataTable data = null;
        DataTable table = null;
        DataTable danhsach = new DataTable();
        cauhoi_BUS bus = new cauhoi_BUS();
        cauhoi_DTO dto = new cauhoi_DTO();
        string ExcelContentType = "application/vnd.ms-excel";
        string Excel2010ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
        if (fileUp.HasFile)
        {

            if (fileUp.PostedFile.ContentType == ExcelContentType || fileUp.PostedFile.ContentType == Excel2010ContentType)
            {
                try
                {
                    string path = string.Concat(Server.MapPath("~/Files/"), fileUp.FileName);
                    fileUp.SaveAs(path);
                    string excelConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", path);
                    using (OleDbConnection connection =
                                 new OleDbConnection(excelConnectionString))
                    {
                        OleDbCommand command = new OleDbCommand
                                ("Select * FROM [IMPORT QUESTION$]", connection);

                        connection.Open();

                        OleDbDataAdapter oleda = new OleDbDataAdapter();

                        oleda.SelectCommand = command;


                        DataSet ds = new DataSet();

                        oleda.Fill(ds);

                        data = ds.Tables[0];
                        connection.Close();

                        for (int i = 0; i < data.Rows.Count; i++)
                        {
                            dto.Id = data.Rows[i]["ID_CAUHOI"].ToString();
                            string id_phanloai = "";
                            if (data.Rows[i]["PHANLOAI"].ToString().Equals("Phần Cứng") || data.Rows[i]["PHANLOAI"].ToString().Equals("phần cứng") || data.Rows[i]["PHANLOAI"].ToString().Equals("PHẦN CỨNG"))
                            {
                                id_phanloai = "PC";
                            }
                            else if (data.Rows[i]["PHANLOAI"].ToString().Equals("Phần Mềm") || data.Rows[i]["PHANLOAI"].ToString().Equals("phần mềm") || data.Rows[i]["PHANLOAI"].ToString().Equals("PHẦN MỀM"))
                            {
                                id_phanloai = "PM";
                            }
                            dto.Phanloai = id_phanloai;
                            dto.Doituong = data.Rows[i]["MADOITUONG"].ToString();
                            dto.Noidung = data.Rows[i]["NOIDUNG"].ToString();
                            dto.Dapan1 = data.Rows[i]["A"].ToString();
                            dto.Dapan2 = data.Rows[i]["B"].ToString();
                            dto.Dapan3 = data.Rows[i]["C"].ToString();
                            dto.Dapan4 = data.Rows[i]["D"].ToString();
                            dto.Dapandung = data.Rows[i]["DAPANDUNG"].ToString();

                            table = bus.danhsachCH_1(dto);

                            if (table == null || table.Rows.Count == 0)
                            {
                                bus.importCauhoi_1(dto);
                            }
                            else
                            {
                                lb2.Text = data.Rows.Count.ToString();
                            }
                        }



                    }
                    danhsach = bus.danhsachimport_1();

                    gridImport.DataSource = danhsach;

                    gridImport.DataBind();


                }

                catch (Exception ex)
                {
                    lb1.Text = ex.Message;
                }
            }
        }
    }
    protected void lnkDownload_Click(object sender, EventArgs e)
    {
        string filename = "Import CH.xlsx";
        Response.ContentType = "application/octet-stream";
        Response.AppendHeader("Content-Disposition", "attachment;filename=" + filename);
        Response.TransmitFile(Server.MapPath("~/Files/Import CH.xlsx"));
    }
}