<%@ Control Language="C#" AutoEventWireup="true" CodeFile="importCH_UC.ascx.cs" Inherits="UC_importCH_UC" %>
<div>
    <form id="Form1" runat="server">
        <center><asp:Label ID="lbHead" runat="server" Font-Size="X-Large">Import Câu Hỏi</asp:Label></center>
    <table>
        <tr>
            <td><asp:FileUpload ID="fileUp" runat="server" Width="500px"/></td>
            <td><asp:Button  ID="btnImport" runat="server" Text="Import" Font-Bold="true" 
                    onclick="btnImport_Click"/></td>
        </tr>
        <tr>
            <td colspan="2" style="text-align:left"><asp:LinkButton ID="lnkDownload" 
                    runat="server" Text="Tải File Mẫu" 
                    Font-Underline="True" ForeColor="Blue" onclick="lnkDownload_Click">Tải File Mẫu</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td colspan="2"><asp:Label ID="lb1" runat="server"/></td>
        </tr>
        <tr>
            <td colspan="2"><asp:Label ID="lb2" runat="server"/></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:DataGrid ID="gridImport" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" 
                    CellPadding="3" CellSpacing="1" Font-Bold="False" Font-Italic="False" 
                    Font-Overline="False" Font-Strikeout="False" Font-Underline="False" 
                    GridLines="None" HorizontalAlign="Center">
                    <Columns>
                        <asp:BoundColumn DataField="NOIDUNG" HeaderText="Nội Dung"></asp:BoundColumn>
                        <asp:BoundColumn DataField="A" HeaderText="A"></asp:BoundColumn>
                        <asp:BoundColumn DataField="B" HeaderText="B"></asp:BoundColumn>
                        <asp:BoundColumn DataField="C" HeaderText="C"></asp:BoundColumn>
                        <asp:BoundColumn DataField="D" HeaderText="D"></asp:BoundColumn>
                    </Columns>
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                    <ItemStyle BackColor="#DEDFDE" ForeColor="Black" />
                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedItemStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    
                </asp:DataGrid>
            </td>
        </tr>
    </table>
    </form>
    
</div>