<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DanhSachTaiKhoan_Page.aspx.cs" Inherits="DanhSachTaiKhoan_Page" %>
<%@ Register Src="~/UC/DanhSachTaiKhoan_UC.ascx" TagName="dsnv" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
    <uc:dsnv ID="danhsach" runat="server"/>
</asp:Content>

