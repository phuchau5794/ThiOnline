<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ChonBaiThi_Page.aspx.cs" Inherits="ChonBaiThi_Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
    <form runat="server">
        <div>
        <h1 style="font-family:Times New Roman">Chọn Loại Đề Thi</h1>
    </div>
    <br /><br />
    Chọn Loại Đề : <asp:DropDownList ID="dropLoaiBT" runat="server" 
            AutoPostBack="True" onselectedindexchanged="dropLoaiBT_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:Button ID="btnGo" runat="server" Text="Làm Bài" CssClass="button" 
            onclick="btnGo_Click"/>
    </form>
</asp:Content>

