<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TaoTaiKhoan_Page.aspx.cs" Inherits="TaoTaiKhoan_Page" %>
<%@ Register Src="~/UC/TaoTaiKhoan_UC.ascx" TagName="themTK" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
    <uc:themTK ID="taoTK" runat="server"/>
</asp:Content>

