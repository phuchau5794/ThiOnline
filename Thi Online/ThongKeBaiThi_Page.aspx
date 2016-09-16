<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ThongKeBaiThi_Page.aspx.cs" Inherits="ThongKeBaiThi_Page" %>
<%@ Register Src="~/UC/ThongKeBaiThi_UC.ascx" TagName="thongke" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
    <uc:thongke ID="ketqua" runat="server"/>
</asp:Content>

