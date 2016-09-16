<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThongKeBaiThi_UC.ascx.cs" Inherits="UC_ThongKeBaiThi_UC" %>
<form id="Form1" runat="server">
<div>
    <h1 style="text-align:center">Thống Kê Bài Thi</h1>
    <div>
        <center>
        <table width="800px" border="1" cellpadding="10">
            <tr>
                <td style="text-align:left;width:400px">Họ Tên : 
                    <asp:Label ID="lbHoten" runat="server"/>
                </td>
                <td style="text-align:left;width:400px">Ngày Thi : 
                    <asp:Label ID="lbNgaythi" runat="server"/>
                </td>
            </tr>
            <tr>
                <td style="text-align:left;width:400px">Tổng số câu hỏi : 
                    <asp:Label ID="lbTongCH" runat="server"/>
                </td>
                <td style="text-align:left;width:400px">Số Câu Đúng : 
                    <asp:Label ID="lbDung" runat="server"/>
                </td>
            </tr>
            <tr>
                <td style="text-align:left;width:400px">Tổng điểm :
                    <asp:Label ID="lbTongdiem" runat="server"/>
                </td>
                <td style="text-align:left;width:400px">Số Câu Sai :
                    <asp:Label ID="lbSai" runat="server"/>
                </td>
            </tr>
            <tr>
                <td style="text-align:left;width:400px">Tỉ Lệ :
                    <asp:Label ID="lbRate" runat="server"/>
                </td>
                <td style="text-align:left;width:400px">Kết Quả :
                    <asp:Label ID="lbResult" runat="server"/>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <asp:Button CssClass="button" ID="btnAccept" runat="server" Text="Xác Nhận" 
                onclick="btnAccept_Click"/>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button CssClass="button" ID="btnView" runat="server" Text="Hiển Thị" onclick="btnView_Click"/>
        <br />
        <br />
        <br />
        <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" 
                AllowPaging="True" PageSize="1" 
                onpageindexchanging="gridView_PageIndexChanging" Visible="False" 
                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                CellPadding="4" ForeColor="Black" GridLines="Horizontal" 
                ShowHeader="False" EnableTheming="False" Width="600px">
            <Columns>
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <table>
                        <tr>
                           <td style="text-align:left">
                                Câu Hỏi : <asp:Label ID="Label1" runat="server" Text='<%# Eval("NOIDUNG") %>'></asp:Label>
                           </td> 
                        </tr>
                        <tr>
                            <td style="text-align:left">
                                <asp:RadioButton ID="rdbA" runat="server" Text='<%# Eval("A") %>' 
                                    GroupName="dapan" AutoPostBack="True"/>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:left">
                                <asp:RadioButton ID="rdbB" runat="server" Text='<%# Eval("B") %>' 
                                    GroupName="dapan" AutoPostBack="True" />
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:left">
                                <asp:RadioButton ID="rdbC" runat="server" Text='<%# Eval("C") %>' 
                                    GroupName="dapan" AutoPostBack="True" />
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:left">
                                <asp:RadioButton ID="rdbD" runat="server" Text='<%# Eval("D") %>' 
                                    GroupName="dapan" AutoPostBack="True" />
                            </td>
                        </tr>
                    </table>
                    <asp:Label ID="lbDA" runat="server" Text='<%# Eval("DAPANDUNG") %>' Visible="false"></asp:Label>
                    <asp:Label ID="lbAns" runat="server" Text='<%# Eval("TRALOI") %>' Visible="false"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerSettings FirstPageText="First" 
                LastPageText="Last" NextPageText="Next" PreviousPageText="Previous" 
                Mode="NextPrevious" NextPageImageUrl="~/IMAGES/next.png" 
                PreviousPageImageUrl="~/IMAGES/previous.png" />
            
        
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
            
        
        </asp:GridView>
        </center>
    </div>
</div>
</form>