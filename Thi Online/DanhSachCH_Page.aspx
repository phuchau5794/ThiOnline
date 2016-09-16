<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DanhSachCH_Page.aspx.cs" Inherits="DanhSachCH_Page" %>
<%@ Register Src="~/UC/DanhSachCH_UC.ascx" TagName="dsCH" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
    <uc:dsCH ID="danhsach" runat="server"/>
</asp:Content>

