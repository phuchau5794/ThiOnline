<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DangNhap_UC.ascx.cs" Inherits="UC_DangNhap_UC" %>
<link type="text/css" rel="stylesheet" href="CSS/login.css"/>

<div class="one">
    <h1>Website Thi Online</h1>
    <div class="two">
        <table cellpadding="5" cellspacing="5">
        <tr style="height:50px;text-align:center">
            <td style="text-align:center" colspan="2"><b style="font-size:30px;color:#000000;margin-top:20px">Đăng Nhập</b></td>
        </tr>
        <tr>
            <td style="float:right"><b style="color:#000000;">Tên Đăng Nhập : </b></td>
            <td><asp:TextBox CssClass="textbox" ID="txtUser" runat="server"/></td>
        </tr>
        <tr>
            <td style="float:right"><b style="color:#000000">Mật Khẩu : </b></td>
            <td><asp:TextBox CssClass="textbox" ID="txtPass" runat="server" TextMode="Password"/></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button CssClass="button" ID="btnDongY" runat="server" Text="Đăng Nhập" 
                    onclick="btnDongY_Click" />
            </td>
        </tr>
    </table>
    </div>
    <div style="text-align:center;padding-top:10px">
        <asp:Label ID="lbErr1" runat="server" ForeColor="White"/>
    </div>
    
</div>