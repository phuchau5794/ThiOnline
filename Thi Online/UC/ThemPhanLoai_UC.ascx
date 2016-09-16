<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThemPhanLoai_UC.ascx.cs" Inherits="UC_ThemPhanLoai_UC" %>
<div>
    <form id="Form1" runat="server">
    <h1 style="font-family:Times New Roman;font-weight:bold;text-align:center">Thêm Phân Loại Câu Hỏi</h1>
    <center>
        
        <table cellpadding="10" cellspacing="10">
            <tr>
                <td>Mã Phân Loại : </td>
                <td><asp:TextBox ID="txtMaPL" runat="server"/></td>
                <td><asp:Label ID="lb1" runat="server" Text="*" ForeColor="Red"/></td>
            </tr>
            <tr>
                <td>Tên Phân Loại : </td>
                <td><asp:TextBox ID="txtTenPL" runat="server"/></td>
                <td><asp:Label ID="Label1" runat="server" Text="*" ForeColor="Red"/></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button CssClass="button" Width="100px" ID="btnAccept" runat="server" Text="Lưu" 
                        onclick="btnAccept_Click"/>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button CssClass="button" Width="100px" ID="btnBack" runat="server" Text="Quay Lại" 
                        onclick="btnBack_Click" OnClientClick="Javascript:history.go(-1);"/>
                </td>
            </tr>
        </table>
        <asp:Label ID="lbError" runat="server"/>
    </center>
    </form>
</div>