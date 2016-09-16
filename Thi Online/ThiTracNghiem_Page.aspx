<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ThiTracNghiem_Page.aspx.cs" Inherits="ThiTracNghiem_Page" %>
<%@ Register Src="~/UC/ThiTracNghiem_UC.ascx" TagName="thiTN" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
    <uc:thiTN ID="tracnghiem" runat="server"/>
</asp:Content>

