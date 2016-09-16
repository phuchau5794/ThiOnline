<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TaoTaiKhoan_UC.ascx.cs" Inherits="UC_TaoTaiKhoan_UC" %>
<div>
    
    <form id="form1" runat="server">
    <center><h1 style="font-family:Times New Roman;font-weight:bold">Thêm Tài Khoản Nhân Viên</h1></center>
    <br />
    <br />
    <br />
    <center>
        <table width="600px" cellpadding="20px" cellspacing="20px">
            <tr>
                <td style="text-align:right"><asp:Label ID="lbID" runat="server" Text="ID : "/></td>
                <td><asp:TextBox ID="txtID" runat="server" Width="300px"/></td>
                <td><asp:Label ID="lb1" runat="server" ForeColor="Red">*</asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:right"><asp:Label ID="lbPass" runat="server" Text="Mật Khẩu : "/></td>
                <td><asp:TextBox ID="txtPass" runat="server" TextMode="Password" Width="300px"/></td>
                <td><asp:Label ID="Label1" runat="server" ForeColor="Red">*</asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:right"><asp:Label ID="lbFullname" runat="server" Text="Họ Tên : "/></td>
                <td><asp:TextBox ID="txtFullname" runat="server" Width="300px"/></td>
                <td><asp:Label ID="Label2" runat="server" ForeColor="Red">*</asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:right"><asp:Label ID="lbRole" runat="server" Text="Quyền Hạn : "/></td>
                <td><asp:DropDownList ID="dropRole" runat="server" BackColor="Gray" Font-Bold="true" ForeColor="White" Width="300px"/></td>
            </tr>
            <tr>
                <td style="text-align:right"><asp:Label ID="lbUnit" runat="server" Text="Đơn Vị Công Tác : "/></td>
                <td><asp:DropDownList ID="dropUnit" runat="server" BackColor="Gray" Font-Bold="true" ForeColor="White" Width="300px"/></td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                    <asp:Button CssClass="button" ID="btnAccept" runat="server" Text="Lưu" Width="100px" 
                        onclick="btnAccept_Click"/>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button CssClass="button" ID="btnBack" runat="server" Text="Trở Lại" Width="100px"/>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <asp:Label ID="lbError" runat="server" ForeColor="Red"/>
    </center>
    </form>
</div>