<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="DonasiBarangPage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.DonasiBarangPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../CSS/DonasiBarangPage_CSS.css" rel="stylesheet" />

    <div class="page">
        <div class="page-container">

            <div class="header">
                <asp:Label ID="headerLbl" runat="server" Text="Pilih Barang Untuk Donasi" CssClass="headerLbl"></asp:Label>
            </div>

            <div class="items">
                <div class="box">
                    <a href="DonasiBarangForm.aspx?Item=baju">
                        <img src="../../Assets/Images/tshirt.png" />
                        <span>Baju</span>
                    </a>
                </div>
                <div class="box">
                    <a href="DonasiBarangForm.aspx?Item=obat">
                        <img src="../../Assets/Images/first-aid-kit.png" />
                        <span>Obat</span>
                    </a>
                </div>
                <div class="box">
                    <a href="DonasiBarangForm.aspx?Item=mainan">
                        <img src="../../Assets/Images/box.png" />
                        <span>Mainan</span>
                    </a>
                </div>
                <div class="box">
                    <a href="DonasiBarangForm.aspx?Item=sembako">
                        <img src="../../Assets/Images/supplies.png" />
                        <span>Sembako</span>
                    </a>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
