<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ThayDoiMatKhau_Page.aspx.cs" Inherits="ThayDoiMatKhau_Page" %>
<%@ Register Src="~/UC/ThayDoiMatKhau_UC.ascx" TagName="change" TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content1" Runat="Server">
<br />
<br />
    <uc:change ID="changePass" runat="server"/>
</asp:Content>

