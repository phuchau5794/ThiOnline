<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ImportDonVi_Page.aspx.cs" Inherits="ImportDonVi_Page" %>
<%@ Register Src="~/UC/ImportDSDonVi_UC.ascx" TagName="importDV" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
    <uc:importDV ID="import" runat="server"/>
</asp:Content>

