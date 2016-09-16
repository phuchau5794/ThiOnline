<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BangDiem_UC.ascx.cs" Inherits="UC_BangDiem_UC" %>
<div style="text-align:center">
    <h1 style="font-family:Times New Roman">Bảng Điểm</h1>
</div>
<br />
<br />
<form id="Form1" runat="server">
<center>
<table>
    <tr>
        <td><asp:Label ID="lb1" runat="server" Text="Tìm Kiếm : "/></td>
        <td><asp:TextBox ID="txtSearch" runat="server"/></td>
        <td><asp:DropDownList ID="dropFilter" runat="server">
            <asp:ListItem Value="1">Tên Nhân Viên</asp:ListItem>
            <asp:ListItem Value="2">ID Nhân Viên</asp:ListItem>
            <asp:ListItem Value="3">Ngày Thi</asp:ListItem>
        </asp:DropDownList></td>
        <td><asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/IMAGES/search.png" 
                onclick="btnSearch_Click"/></td>
        <td><asp:ImageButton ID="btnRefresh" runat="server" ImageUrl="~/IMAGES/refresh.png" 
                onclick="btnRefresh_Click"/></td>
    </tr>
</table>
</center>
<br />
<br />
<div>

    <center>
    <asp:GridView ID="gridScore" runat="server" AutoGenerateColumns="False" 
        BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
        CellPadding="4" CellSpacing="2" ForeColor="Black" AllowPaging="True" 
            onpageindexchanging="gridScore_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="ID_NHANVIEN" HeaderText="ID" />
            <asp:BoundField DataField="TENNHANVIEN" HeaderText="Tên Nhân Viên">
            <HeaderStyle Width="250px" />
            </asp:BoundField>
            <asp:BoundField DataField="NGAYTHI" DataFormatString="{0:dd/MM/yyyy}" 
                HeaderText="Ngày Thi">
            <HeaderStyle Width="100px" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="TONGDIEM" HeaderText="Tổng Điểm">
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    </center>
    
</div>
</form>