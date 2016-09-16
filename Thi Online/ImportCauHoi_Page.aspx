<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ImportCauHoi_Page.aspx.cs" Inherits="ImportCauHoi_Page" %>
<%@ Register Src="~/UC/importCH_UC.ascx" TagName="import" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
<%if (!Session["login"].Equals(null))
  { %>
    <uc:import ID="importCH" runat="server"/>
    <%} %>
</asp:Content>

