<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="DonasiPage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.DonasiPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../CSS/DonasiPage_CSS.css" rel="stylesheet" />

    <div class="page">
        <div class="container-page">
            <div class="form">

<%--                <div class="logo">
                    <asp:Image ID="logoImg" runat="server" ImageUrl="~/Assets/Images/QuickEV-Logo-Black.png" />
                </div>--%>

                <div class="header">
                    <asp:Label ID="headerLbl" runat="server" CssClass="headerLbl">
                            Uluran Tanganmu,<br>Kebahagiaan Bagi Mereka.
                    </asp:Label>
                </div>

                <div class="box">
                    <a href="DonasiBarangPage.aspx">
                        <img src="../../Assets/Images/heart_donasi.png" />
                        <span>Donasi Barang</span>
                    </a>
                </div>

                <div class="box">
                    <a href="DonasiUangPage.aspx">
                        <img src="../../Assets/Images/money_donasi.png" />
                        <span>Donasi Uang</span>
                    </a>
                </div>

            </div>
        </div>
    </div>


</asp:Content>
