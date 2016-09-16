<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ImportDSDonVi_UC.ascx.cs" Inherits="UC_ImportDSDonVi_UC" %>
<div style="text-align:center">
    <h1 style="font-family:Times New Roman">Import Đơn Vị Công Tác</h1>
</div>
<div>
<form runat="server">
    <table cellspacing="10" style="margin:0 auto 0 auto">
        <tr>
            <td><asp:FileUpload ID="fileUp" runat="server"/></td>
            <td><asp:Button ID="btnImport" runat="server" Text="Import" 
                    Font-Names="Times New Roman" CssClass="button" onclick="btnImport_Click"/></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:LinkButton ID="lnkDown" runat="server" Text="Tải File Mẫu" 
                    ForeColor="Blue" onclick="lnkDown_Click">Tải File Mẫu</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="gridUnit" runat="server" AutoGenerateColumns="False" 
                    BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
                    CellPadding="4" CellSpacing="2" ForeColor="Black" AllowPaging="True" 
                    onpageindexchanging="gridUnit_PageIndexChanging" PageSize="15">
                    <Columns>
                        <asp:BoundField DataField="ID_DONVI" HeaderText="Mã Đơn Vị" />
                        <asp:BoundField DataField="TENDONVI" HeaderText="Tên Đơn Vị" />
                        <asp:BoundField DataField="DIACHIDONVI" HeaderText="Địa Chỉ" />
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
            </td>
        </tr>
    </table>
    </form>
</div>