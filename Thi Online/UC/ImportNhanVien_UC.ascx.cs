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

public partial class UC_ImportNhanVien_UC : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnImport_Click(object sender, EventArgs e)
    {
        DataTable data = null;
        DataTable table = null;
        DataTable danhsach = new DataTable();
        nhanvien_BUS bus = new nhanvien_BUS();
        nhanvien_DTO dto = new nhanvien_DTO();
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
                                ("Select * FROM [Import Nhan Vien$]", connection);

                        connection.Open();

                        OleDbDataAdapter oleda = new OleDbDataAdapter();

                        oleda.SelectCommand = command;


                        DataSet ds = new DataSet();

                        oleda.Fill(ds);

                        data = ds.Tables[0];
                        connection.Close();

                        for (int i = 0; i < data.Rows.Count; i++)
                        {
                            dto.MaNV = data.Rows[i]["ID_NHANVIEN"].ToString();
                            int id_quyenhan = 0;
                            if (data.Rows[i]["QUYENHAN"].ToString().Equals("Admin") || data.Rows[i]["QUYENHAN"].ToString().Equals("admin") || data.Rows[i]["QUYENHAN"].ToString().Equals("ADMIN"))
                            {
                                id_quyenhan = 1;
                            }
                            else if (data.Rows[i]["QUYENHAN"].ToString().Equals("User") || data.Rows[i]["QUYENHAN"].ToString().Equals("user") || data.Rows[i]["QUYENHAN"].ToString().Equals("USER"))
                            {
                                id_quyenhan = 2;
                            }
                            dto.Quyenhan = id_quyenhan;
                            dto.Matkhau = data.Rows[i]["MATKHAU"].ToString();
                            dto.Tennhanvien = data.Rows[i]["TENNHANVIEN"].ToString();
                            dto.Donvi = data.Rows[i]["ID_DONVI"].ToString();

                            table = bus.danhsachNhanvien_1(dto);

                            if (table == null || table.Rows.Count == 0)
                            {
                                bus.importNhanvien_1(dto);
                            }
                            else
                            {
                                bus.capnhatnhanvien_1(dto);
                            }
                        }
                        lbError.Text = "Import Thành Công !";


                    }
                    danhsach = bus.DSnhanvien_1();

                    gridDSNV.DataSource = danhsach;

                    gridDSNV.DataBind();


                }

                catch (Exception ex)
                {
                    lbError.Text = ex.Message;
                }
            }
        }
    }
    protected void lnkDown_Click(object sender, EventArgs e)
    {
        string filename = "Import Nhan Vien.xlsx";
        Response.ContentType = "application/octet-stream";
        Response.AppendHeader("Content-Disposition", "attachment;filename=" + filename);
        Response.TransmitFile(Server.MapPath("~/Files/Import Nhan Vien.xlsx"));
    }
}