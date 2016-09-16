<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ThemPhanLoai_Page.aspx.cs" Inherits="ThemPhanLoai_Page" %>
<%@ Register Src="~/UC/ThemPhanLoai_UC.ascx" TagName="phanloai" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
    <uc:phanloai ID="themphan" runat="server"/>
</asp:Content>

