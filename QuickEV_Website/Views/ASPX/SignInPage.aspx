<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="SignInPage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.SignInPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../CSS/SignInPage_CSS.css" rel="stylesheet" />

    <div class="page">
        <div class="container">
            <div class="logo">
                <asp:Image ID="logoImg" runat="server" ImageUrl="~/Assets/Images/QuickEV-Logo-Black.png" />
            </div>

            <div class="header">
                <asp:Label ID="headerLbl" runat="server" Text="Masuk ke dalam akunmu" CssClass="headerLbl"></asp:Label>
            </div>

            <div class="emailBox">
                <asp:Label ID="emailLbl" runat="server" Text="Email" CssClass="emailLbl"></asp:Label>
                <asp:TextBox ID="emailTxt" runat="server" CssClass="emailTxt"></asp:TextBox>
            </div>

            <div class="passwordBox">
                <asp:Label ID="passwordLbl" runat="server" Text="Password" CssClass="passwordLbl"></asp:Label>
                <asp:TextBox ID="passwordTxt" runat="server" TextMode="Password" CssClass="passwordTxt"></asp:TextBox>
            </div>

            <div class="signInBox">
                <asp:Button ID="signInBtn" runat="server" Text="Sign In" CssClass="signInBtn" />
            </div>

            <div class="navigationBox">
                <asp:Label ID="belumLbl" runat="server" Text="Belum terdaftar?" CssClass="belumLbl"></asp:Label>
                <asp:HyperLink ID="daftarHyl" runat="server" Text="Daftar di sini" CssClass="daftarHyl" NavigateUrl="~/Views/ASPX/SignUpPage.aspx"></asp:HyperLink>
            </div>
        </div>
    </div>


</asp:Content>
