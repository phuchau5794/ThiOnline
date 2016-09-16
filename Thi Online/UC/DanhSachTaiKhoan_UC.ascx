<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSachTaiKhoan_UC.ascx.cs" Inherits="UC_DanhSachTaiKhoan_UC" %>
<div style="text-align:center">
    <h1 style="font-family:Times New Roman">Danh Sách Tài Khoản</h1>
</div>
<div>
<center>
<form runat="server">
    <asp:GridView ID="gridAccount" runat="server" AutoGenerateColumns="False" 
        BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
        CellPadding="4" CellSpacing="2" ForeColor="Black" Width="700px" 
        onrowdeleting="gridAccount_RowDeleting" 
        EmptyDataText="Không Có Dữ Liệu !" DataKeyNames="ID_NHANVIEN" 
        AllowPaging="True" onpageindexchanging="gridAccount_PageIndexChanging" 
        onrowcommand="gridAccount_RowCommand">
        <Columns>
            <asp:BoundField DataField="ID_NHANVIEN" HeaderText="ID" >
            <ControlStyle Width="200px" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="TENNHANVIEN" HeaderText="Tên Nhân Viên" />
            <asp:BoundField DataField="TENDONVI" HeaderText="Đơn Vị Công Tác" />
            <asp:CommandField ButtonType="Image" DeleteImageUrl="~/IMAGES/delete.png" 
                HeaderText="Chức Năng" ShowDeleteButton="True">
            <ItemStyle HorizontalAlign="Center" />
            </asp:CommandField>
            <asp:TemplateField HeaderText="Trạng Thái">
                <ItemTemplate>
                    <asp:Button ID="btnLock" runat="server" 
                        CommandArgument='<%# Eval("ID_NHANVIEN") %>' CommandName="lock" 
                        CssClass="button" Text="Khóa" Width="50px" />
                    <asp:Button ID="btnUnlock" runat="server" 
                        CommandArgument='<%# Eval("ID_NHANVIEN") %>' CommandName="unlock" 
                        CssClass="button" Text="Mở" Width="50px" />
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("TRANGTHAI") %>' 
                        Visible="False"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" Width="100px" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="Gray" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
        
    </asp:GridView>
    <br />
    <asp:Label ID="lbErr" runat="server" ForeColor="Red"></asp:Label>
    </form>
    </center>
</div>