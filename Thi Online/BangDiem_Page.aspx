<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BangDiem_Page.aspx.cs" Inherits="BangDiem_Page" %>
<%@ Register Src="~/UC/BangDiem_UC.ascx" TagName="bangdiem" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
    <uc:bangdiem ID="score" runat="server"/>
</asp:Content>

