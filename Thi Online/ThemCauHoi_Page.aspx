<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ThemCauHoi_Page.aspx.cs" Inherits="ThemCauHoi_Page" %>
<%@ Register Src="~/UC/themcauhoi_UC.ascx" TagName="themCH" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
    <uc:themCH ID="addCH" runat="server"/>
</asp:Content>

