using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using DTO;
using BUS;

public partial class UC_ImportDSDonVi_UC : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnImport_Click(object sender, EventArgs e)
    {
        
        DataTable data = null;
        DataTable table = null;
        DataTable danhsach = new DataTable();
        donvi_BUS bus = new donvi_BUS();
        donvi_DTO dto = new donvi_DTO();
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
                                ("Select * FROM [Import Don Vi$]", connection);

                        connection.Open();

                        OleDbDataAdapter oleda = new OleDbDataAdapter();

                        oleda.SelectCommand = command;


                        DataSet ds = new DataSet();

                        oleda.Fill(ds);

                        data = ds.Tables[0];
                        connection.Close();

                        for (int i = 0; i < data.Rows.Count; i++)
                        {
                            dto.Id = data.Rows[i]["ID_DONVI"].ToString();
                            dto.Tendonvi = data.Rows[i]["TENDONVI"].ToString();
                            dto.Diachi = data.Rows[i]["DIACHI"].ToString();
                            table = bus.dsDonviTheoID_1(dto); ;

                            if (table.Rows.Count == 0)
                            {
                                bus.importDonvi_1(dto);
                                
                            }
                            else
                            {
                                bus.capnhatDonvi_1(dto);
                                
                            }
                            
                            //if (bus.checkDuplicate_1(dto))
                            //{
                            //    bus.capnhatDonvi_1(dto);
                            //    danhsach = bus.dsDonvi_1();

                            //    gridUnit.DataSource = danhsach;

                            //    gridUnit.DataBind();
                            //}
                            //else
                            //{
                            //    bus.importDonvi_1(dto);
                            //    danhsach = bus.dsDonvi_1();

                            //    gridUnit.DataSource = danhsach;

                            //    gridUnit.DataBind();
                            //}
                        }
                        Response.Write("<script>alert('Import Thành Công')</script>");


                    }
                    danhsach = bus.dsDonvi_1();

                    gridUnit.DataSource = danhsach;

                    gridUnit.DataBind();


                }

                catch (Exception ex)
                {
                    string mes = ex.Message;
                }
            }
        }
    }

    public void loadGridview()
    {
        DataTable table = new DataTable();
        donvi_BUS bus = new donvi_BUS();
        table = bus.dsDonvi_1();
        gridUnit.DataSource = table;
        gridUnit.DataBind();
    }
    protected void gridUnit_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gridUnit.PageIndex = e.NewPageIndex;
        loadGridview();
    }
    protected void lnkDown_Click(object sender, EventArgs e)
    {
        string filename = "Import DVCT.xlsx";
        Response.ContentType = "application/octet-stream";
        Response.AppendHeader("Content-Disposition", "attachment;filename=" + filename);
        Response.TransmitFile(Server.MapPath("~/Files/Import DVCT.xlsx"));
    }
}