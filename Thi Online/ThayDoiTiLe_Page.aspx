<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ThayDoiTiLe_Page.aspx.cs" Inherits="ThayDoiTiLe_Page" %>
<%@ Register Src="~/UC/CapNhatTiLe_UC.ascx" TagName="capnhatTL" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
    <uc:capnhatTL ID="changeRate" runat="server"/>
</asp:Content>

