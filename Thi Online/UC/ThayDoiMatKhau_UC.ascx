<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThayDoiMatKhau_UC.ascx.cs" Inherits="UC_ThayDoiMatKhau_UC" %>

<div style="text-align:center">
    <h1 style="font-family:Times New Roman;">Thay Đổi Mật Khẩu</h1>
</div>
<br />
<br />
<div>
    
    <form runat="server">
    
    <table cellpadding="15" cellspacing="20" style="margin:0 auto 0 auto">
        <tr>
            <td style="text-align:right"><asp:Label ID="lb1" runat="server" Text="Mật Khẩu Cũ : "/></td>
            <td><asp:TextBox ID="txtOld" runat="server" Width="200px" TextMode="Password"/></td>
        </tr>
        <tr>
            <td style="text-align:right"><asp:Label ID="lb2" runat="server" Text="Mật Khẩu Mới : "/></td>
            <td><asp:TextBox ID="txtNew" runat="server" Width="200px" TextMode="Password"/></td>
        </tr>
        <tr>
            <td style="text-align:right"><asp:Label ID="lb3" runat="server" Text="Nhập Lại Mật Khẩu Mới : "/></td>
            <td><asp:TextBox ID="txtConfirm" runat="server" Width="200px" TextMode="Password"/></td>
        </tr>
        <tr>
            <td style="text-align:center">
                <asp:Button CssClass="button" ID="btnChange" 
                    runat="server" Text="Cập Nhật" Width="100px" Font-Bold="True" 
                    Font-Names="Times New Roman" onclick="btnChange_Click"/>
                    
                    </td>
            <td style="text-align:center"><asp:Button CssClass="button" ID="btnCancel" 
                    runat="server" Text="Hủy" Width="100px" Font-Bold="True" 
                    Font-Names="Times New Roman"/></td>
        </tr>
    </table>
    <center>
        <asp:Label ID="lbError" runat="server" ForeColor="Red"/>
    </center>
    </form>
</div>