<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThiTracNghiem_UC.ascx.cs" Inherits="UC_ThiTracNghiem_UC" %>
<script type = "text/javascript">
    window.onload = function () {
        document.onkeydown = function (e) {
            return (e.which || e.keyCode) != 116;
        };
    }
</script>
<div>
    <form runat="server">
        <div>
    <asp:ScriptManager ID="SM1" runat="server"></asp:ScriptManager>
    <asp:Timer ID="timer1" runat="server" Interval="10" ontick="timer1_Tick"></asp:Timer>
</div>
<div style="background-color:#CFCFCF;width:100%;height:50px">
    <table style="width:100%" cellspacing="10px">
        <tr>
            <td style="width:33%;text-align:left"><asp:Label ID="lb1" runat="server" Text="Tên Nhân Viên: "/>
                <asp:Label ID="lbName" runat="server"/>
            </td>
            <td style="width:33%;text-align:left">
                <asp:Label ID="lb2" runat="server" Text="Tổng Số Câu Hỏi : "/>
                <asp:Label ID="lbCH" runat="server"/>
            </td> 
            <td style="width:*%;text-align:left">
                <asp:UpdatePanel ID="updateTime" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:Label ID="lbTime" runat="server" Font-Names="Arial"></asp:Label>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="timer1" EventName="tick"/>
                    </Triggers>
                </asp:UpdatePanel>
            </td>
        </tr>

    </table>
</div>
<div style="overflow-y: auto;width:100%;height:400px">
    <asp:GridView ID="gridExam" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="White" BorderStyle="None" BorderWidth="1px" 
        CellPadding="10" ShowHeader="False" CellSpacing="20" GridLines="None" DataKeyNames="ID_CAUHOI"
         EnableViewState="true" ViewStateMode="Enabled">
        <Columns>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <table>
                        <tr>
                           <td style="text-align:left">
                                Câu <%#Container.DataItemIndex+1 %> : <asp:Label ID="Label1" runat="server" Text='<%# Eval("NOIDUNG") %>'></asp:Label>
                           </td> 
                        </tr>
                        <tr>
                            <td style="text-align:left">
                                <asp:RadioButton ID="rdbA" runat="server" Text='<%# Eval("A") %>' 
                                    GroupName="dapan" />
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:left">
                                <asp:RadioButton ID="rdbB" runat="server" Text='<%# Eval("B") %>' 
                                    GroupName="dapan" />
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:left">
                                <asp:RadioButton ID="rdbC" runat="server" Text='<%# Eval("C") %>' 
                                    GroupName="dapan" />
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align:left">
                                <asp:RadioButton ID="rdbD" runat="server" Text='<%# Eval("D") %>' 
                                    GroupName="dapan" />
                            </td>
                        </tr>
                    </table>
                    <br />
                    <asp:Label ID="lbDA" runat="server" Text='<%# Eval("DAPANDUNG") %>' Visible="false"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
        
    </asp:GridView>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        Visible="False">
        <Columns>
            <asp:BoundField DataField="NOIDUNG" HeaderText="NOIDUNG" />
            <asp:BoundField DataField="A" HeaderText="A" />
            <asp:BoundField DataField="B" HeaderText="B" />
            <asp:BoundField DataField="C" HeaderText="C" />
            <asp:BoundField DataField="D" HeaderText="D" />
            <asp:BoundField DataField="DAPANDUNG" HeaderText="DAPANDUNG" />
        </Columns>
    </asp:GridView>

    <asp:Button CssClass="button" ID="btnEnd" runat="server" Text="Nộp Bài" onclick="btnEnd_Click"/>
</div>
    </form>
</div>