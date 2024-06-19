<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="SignUpPage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.SignUpPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../CSS/SignUpPage_CSS.css" rel="stylesheet" />

    <div class="page">
        <div class="container">
            <div class="logo">
                <asp:Image ID="logoImg" runat="server" ImageUrl="~/Assets/Images/QuickEV-Logo-Black.png" />
            </div>

            <div class="header">
                <asp:Label ID="headerLbl" runat="server" Text="Bergabung bersama kami" CssClass="headerLbl"></asp:Label>
            </div>

            <div class="relawanBox">
                <button class="relawanBtn" runat="server">
                    <img src="../../Assets/Images/relawan_SignUp_Logo.png" />
                    <a href="RelawanSignUpPage.aspx">Daftar sebagai relawan</a>
                </button>
            </div>

            <div class="komunitasBox">
                <button class="komunitasBtn" runat="server">
                    <img src="../../Assets/Images/komunitas_SignUp_Logo.png" />
                    <a href="KomunitasSignUpPage.aspx">Daftar sebagai komunitas</a>
                </button>
            </div>

            <%--<div class="backBox">
                <button class="backBtn" runat="server"><img src="../../Assets/Images/back_SignUp.png" NavigateUrl="~/Views/ASPX/SignInPage.aspx" />Back</button>
            </div>--%>

            <div class="navigationBox">
                <asp:Label ID="sudahLbl" runat="server" Text="Sudah punya akun?" CssClass="sudahLbl"></asp:Label>
                <asp:HyperLink ID="masukHyl" runat="server" Text="Masuk di sini" CssClass="masukHyl" NavigateUrl="~/Views/ASPX/SignInPage.aspx"></asp:HyperLink>
            </div>
        </div>
    </div>


</asp:Content>
