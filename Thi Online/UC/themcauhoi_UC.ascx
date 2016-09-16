<%@ Control Language="C#" AutoEventWireup="true" CodeFile="themcauhoi_UC.ascx.cs" Inherits="UC_themcauhoi_UC" %>
<head id="Head1" runat="server">        
    <link href="../CSS/style.css" type="text/css" rel="Stylesheet"/>
</head>
<div>
    <form id="Form1" runat="server">
    <h2>Thêm Câu Hỏi</h2>
    <table id="themCH" cellpadding="5" cellspacing="5">
        <tr>
            <td style="text-align:right">Mã Câu Hỏi:</td>
            <td><asp:TextBox ID="maCH" runat="server"/></td>
        </tr>
        <tr>
            <td style="text-align:right">Phân Loại Câu Hỏi :</td>
            <td>
                <asp:DropDownList ID="dropPhanloai" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="text-align:right">Chọn Đối Tượng:</td>
            <td>
                <asp:DropDownList ID="dropDoituong" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="text-align:right"><asp:Label ID="Label1" runat="server" Text="Nội Dung :"/><br /></td>
            <td colspan="3"><asp:TextBox CssClass="textarea" Columns="102" Rows="5" runat="server" TextMode="MultiLine" ID="txtNoidung"/></td>
        </tr>
        <tr>
            <td style="text-align:right">A :</td>
            <td colspan="3"><asp:TextBox ID="da1" runat="server" Columns="100"/></td>
        </tr>
        <tr>
            <td style="text-align:right">B :</td>
            <td colspan="3"><asp:TextBox ID="da2" runat="server" Columns="100"/></td>
        </tr>
        <tr>
            <td style="text-align:right">C :</td>
            <td colspan="3"><asp:TextBox ID="da3" runat="server" Columns="100"/></td>
        </tr>
        <tr>
            <td style="text-align:right">D :</td>
            <td colspan="3"><asp:TextBox ID="da4" runat="server" Columns="100"/></td>
        </tr>
        <tr>
            <td>Đáp Án Đúng :</td>
            <td colspan="3"><asp:RadioButton runat="server" ID="rdbA" Text="A" GroupName="rdb"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton runat="server" ID="rdbB" Text="B" GroupName="rdb"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton runat="server" ID="rdbC" Text="C" GroupName="rdb"/>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton runat="server" ID="rdbD" Text="D" GroupName="rdb"/></td>
        </tr>
        <tr>
            <td colspan="4" style="text-align:center">
                <asp:Button CssClass="button" runat="server" ID="btnOK" Text="Thêm" 
                    onclick="btnOK_Click" />
                <asp:Button CssClass="button" runat="server" ID="btnCancel" Text="Xóa" 
                    onclick="btnCancel_Click" />
            </td>
        </tr>
    </table>
    </form>
</div>