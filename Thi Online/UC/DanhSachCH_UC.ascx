<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSachCH_UC.ascx.cs" Inherits="UC_DanhSachCH_UC" %>
<div>
    <form id="Form1" runat="server">
        <center><asp:Label ID="lb1" runat="server" Text="Danh Sách Câu Hỏi" Font-Bold="true" Font-Size="XX-Large"></asp:Label></center>
        <br />
        <br />
        <table>
            <tr>
                <td><asp:Label ID="lb2" runat="server" Text="Tìm Kiếm : "></asp:Label></td>
                <td><asp:TextBox ID="txtSearch" runat="server"/></td>
                <td><asp:ImageButton ID="btnSearch" runat="server" ImageUrl="~/IMAGES/search.png" onclick="btnSearch_Click" /></td>
                <td><asp:ImageButton ID="btnRefresh" runat="server" ImageUrl="~/IMAGES/refresh.png" 
                        onclick="btnRefresh_Click"/></td>
            </tr>
        </table>
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Gridview ID="gridCauHoi" runat="server" AutoGenerateColumns="False" 
            BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
            CellPadding="4" Font-Bold="False" Font-Italic="False" Font-Overline="False" 
            Font-Strikeout="False" Font-Underline="False"
            CellSpacing="2" ForeColor="Black" AllowPaging="True" 
            onpageindexchanging="gridCauHoi_PageIndexChanging" 
            PageSize="8" DataKeyNames="ID_CAUHOI" 
            onrowdeleting="gridCauHoi_RowDeleting">
            <Columns>
                <asp:TemplateField HeaderText="Mã Câu Hỏi">
                    <ItemTemplate>
                        <div style="width:100px;overflow:hidden;white-space:nowrap;text-overflow:ellipsis">
                            <%# Eval("ID_CAUHOI") %>
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nội Dung Câu Hỏi">
                    <ItemTemplate>
                        <div style="width:250px;overflow:hidden;white-space:nowrap;text-overflow:ellipsis">
                            <%# Eval("NOIDUNG") %>
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="A">
                    <ItemTemplate>
                        <div style="width:150px;overflow:hidden;white-space:nowrap;text-overflow:ellipsis">
                            <%# Eval("A") %>
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="B">
                    <ItemTemplate>
                        <div style="width:150px;overflow:hidden;white-space:nowrap;text-overflow:ellipsis">
                            <%# Eval("B") %>
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="C">
                    <ItemTemplate>
                        <div style="width:150px;overflow:hidden;white-space:nowrap;text-overflow:ellipsis">
                            <%# Eval("C") %>
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="D">
                    <ItemTemplate>
                        <div style="width:150px;overflow:hidden;white-space:nowrap;text-overflow:ellipsis">
                            <%# Eval("D") %>
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Chức Năng" Visible="False">
                    <ItemTemplate>
                        <asp:ImageButton ID="ImageButton1" runat="server" 
                            CommandArgument='<%# Eval("ID_CAUHOI") %>' ImageUrl="~/IMAGES/delete.png"/>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ButtonType="Image" DeleteImageUrl="~/IMAGES/delete.png" 
                    DeleteText="" ShowCancelButton="False" ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerSettings Position="TopAndBottom" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" Height="20px" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
            
            
        </asp:Gridview>
    </form>
</div>