<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ImportNhanVien_UC.ascx.cs" Inherits="UC_ImportNhanVien_UC" %>
<div>
<form id="Form1" runat="server">
    <center><h1>Import Danh Sách Nhân Viên</h1></center>
    <table>
        <tr>
            <td>
                <asp:FileUpload ID="fileUp" runat="server" Width="500px" Font-Names="Times New Roman" Font-Bold="true"/>
            </td>
            <td>
                <asp:Button  ID="btnImport" runat="server" Text="Import" Font-Bold="true" 
                    Font-Names="Times New Roman" onclick="btnImport_Click"/>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lbError" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align:left">
                <asp:LinkButton ID="lnkDown" runat="server" Text="Tải File Mẫu" 
                    onclick="lnkDown_Click" Font-Underline="True" ForeColor="Blue"/></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:GridView ID="gridDSNV" runat="server" AutoGenerateColumns="False" 
                    BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
                    CellPadding="4" CellSpacing="2" ForeColor="Black" AllowPaging="True">
                    <Columns>
                        <asp:BoundField DataField="ID_NHANVIEN" HeaderText="ID">
                        <HeaderStyle Width="100px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="TENNHANVIEN" HeaderText="Tên Nhân Viên">
                        <HeaderStyle Width="250px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="TENDONVI" HeaderText="Đơn Vị Công Tác">
                        <HeaderStyle Width="300px" />
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
            </td>
        </tr>
    </table>
    </form>
</div>