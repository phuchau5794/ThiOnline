<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ImportNhanVien_Page.aspx.cs" Inherits="ImportNhanVien_Page" %>
<%@ Register Src="~/UC/ImportNhanVien_UC.ascx" TagName="importNV" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
    <uc:importNV ID="import" runat="server"/>
</asp:Content>

