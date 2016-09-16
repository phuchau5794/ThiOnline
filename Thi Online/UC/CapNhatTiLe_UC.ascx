<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CapNhatTiLe_UC.ascx.cs" Inherits="UC_CapNhatTiLe_UC" %>
<div style="text-align:center">
    <h1 style="font-family:Times New Roman">Cập Nhật Tỉ Lệ Bài Thi</h1>
</div>
<div>
    <form runat="server">
    <table style="margin: 0 auto 0 auto" cellspacing="10">
        <tr>
            <td>Tổng Số Câu Hỏi Hiện Tại : </td>
            <td><asp:Label ID="recentRate" runat="server"/></td>
        </tr>
        <tr>
            <td>Cập Nhật Số Câu Hỏi : </td>
            <td><asp:TextBox ID="changeRate" runat="server"/></td>
        </tr>
        <tr>
            <td>Thời Gian Làm Bài Hiện Tại : </td>
            <td><asp:Label ID="recentTime" runat="server"/></td>
        </tr>
        <tr>
            <td>Cập Nhật Thời Gian Làm Bài : </td>
            <td><asp:TextBox ID="changeTime" runat="server"/></td>
        </tr>
        <tr>
            <td colspan="2" style="text-align:center"><asp:Button CssClass="button" 
                    ID="btnChange" runat="server" Text="Cập Nhật" onclick="btnChange_Click"/></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lbError" runat="server"/>
            </td>
        </tr>
    </table>
    </form>
</div>