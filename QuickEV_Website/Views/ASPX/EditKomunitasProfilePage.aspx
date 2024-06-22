﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="EditKomunitasProfilePage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.EditKomunitasProfilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../CSS/EditKomunitasProfilePage_CSS.css" rel="stylesheet" />

    <div class="page">
        <div class="container-page">
            <div class="header">
                <asp:Label ID="headerLbl" runat="server" Text="Edit Profile" CssClass="headerLbl"></asp:Label>
            </div>
            <div class="form">

                <div class="subHeader1">
                    <asp:Label ID="profilLbl" runat="server" Text="Profil Komunitas" CssClass="profilLbl"></asp:Label>
                </div>

                <div class="logoBox">
                    <asp:Image ID="logoImage" runat="server" CssClass="logoImage"/>
                    <asp:FileUpload ID="logoFU" runat="server" CssClass="logoFU" />
                    <asp:Label ID="logoErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>

                <div class="usernameBox">
                    <asp:Label ID="usernamelbl" runat="server" Text="Username Komunitas" CssClass="usernameLbl"></asp:Label>
                    <asp:TextBox ID="usernameTxt" runat="server" CssClass="usernameTxt"></asp:TextBox>
                    <asp:Label ID="usernameErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>

                <div class="nameBox">
                    <asp:Label ID="nameLbl" runat="server" Text="Nama Komunitas" CssClass="nameLbl"></asp:Label>
                    <asp:TextBox ID="nameTxt" runat="server" CssClass="nameTxt"></asp:TextBox>
                    <asp:Label ID="nameErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>

                <div class="descBox">
                    <asp:Label ID="descLbl" runat="server" Text="Deskripsi Komunitas" CssClass="descLbl"></asp:Label>
                    <asp:TextBox ID="descTxt" runat="server" CssClass="descTxt" TextMode="MultiLine" Rows="10" Columns="50" MaxLength="1500"></asp:TextBox>
                    <asp:Label ID="descErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>

                <div class="subHeader2">
                    <asp:Label ID="lokasiLbl" runat="server" Text="Lokasi Komunitas" CssClass="lokasiLbl"></asp:Label>
                </div>

                <div class="alamatBox">
                    <asp:Label ID="alamatLbl" runat="server" Text="Alamat Komunitas" CssClass="alamatLbl"></asp:Label>
                    <asp:TextBox ID="alamatTxt" runat="server" CssClass="alamatTxt"></asp:TextBox>
                    <asp:Label ID="alamatErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>

                <div class="provinsiBox">
                    <asp:Label ID="provinsiLbl" runat="server" Text="Provinsi Domisili Komunitas" CssClass="provinsiLbl"></asp:Label>
                    <asp:DropDownList ID="provinsiDDL" runat="server" CssClass="provinsiDDL">
                        <asp:ListItem> </asp:ListItem>
                        <asp:ListItem>Nanggroe Aceh Darussalam</asp:ListItem>
                        <asp:ListItem>Sumatera Utara</asp:ListItem>
                        <asp:ListItem>Sumatera Selatan</asp:ListItem>
                        <asp:ListItem>Sumatera Barat</asp:ListItem>
                        <asp:ListItem>Bengkulu</asp:ListItem>
                        <asp:ListItem>Riau</asp:ListItem>
                        <asp:ListItem>Kepulauan Riau</asp:ListItem>
                        <asp:ListItem>Jambi</asp:ListItem>
                        <asp:ListItem>Lampung</asp:ListItem>
                        <asp:ListItem>Bangka Belitung</asp:ListItem>
                        <asp:ListItem>Kalimantan Barat</asp:ListItem>
                        <asp:ListItem>Kalimantan Timur</asp:ListItem>
                        <asp:ListItem>Kalimantan Selatan</asp:ListItem>
                        <asp:ListItem>Kalimantan Tengah</asp:ListItem>
                        <asp:ListItem>Kalimantan Utara</asp:ListItem>
                        <asp:ListItem>Banten</asp:ListItem>
                        <asp:ListItem>DKI Jakarta</asp:ListItem>
                        <asp:ListItem>Jawa Barat</asp:ListItem>
                        <asp:ListItem>Jawa Tengah</asp:ListItem>
                        <asp:ListItem>Daerah Istimewa Yogyakarta</asp:ListItem>
                        <asp:ListItem>Jawa Timur</asp:ListItem>
                        <asp:ListItem>Bali</asp:ListItem>
                        <asp:ListItem>Nusa Tenggara Timur</asp:ListItem>
                        <asp:ListItem>Nusa Tenggara Barat</asp:ListItem>
                        <asp:ListItem>Gorontalo</asp:ListItem>
                        <asp:ListItem>Sulawesi Barat</asp:ListItem>
                        <asp:ListItem>Sulawesi Tengah</asp:ListItem>
                        <asp:ListItem>Sulawesi Utara</asp:ListItem>
                        <asp:ListItem>Sulawesi Tenggara</asp:ListItem>
                        <asp:ListItem>Sulawesi Selatan</asp:ListItem>
                        <asp:ListItem>Maluku Utara</asp:ListItem>
                        <asp:ListItem>Maluku</asp:ListItem>
                        <asp:ListItem>Papua Barat</asp:ListItem>
                        <asp:ListItem>Papua</asp:ListItem>
                        <asp:ListItem>Papua Tengah</asp:ListItem>
                        <asp:ListItem>Papua Pegunungan</asp:ListItem>
                        <asp:ListItem>Papua Selatan</asp:ListItem>
                        <asp:ListItem>Papua Barat Daya</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="provinsiErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>

                <div class="subHeader3">
                    <asp:Label ID="kontakLbl" runat="server" Text="Kontak Komunitas" CssClass="kontakLbl"></asp:Label>
                </div>

                <div class="telpBox">
                    <asp:Label ID="telpLbl" runat="server" Text="No. Telepon Komunitas" CssClass="telpLbl"></asp:Label>
                    <asp:TextBox ID="telpTxt" runat="server" CssClass="telpTxt"></asp:TextBox>
                    <asp:Label ID="telpErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>

                <div class="subHeader4">
                    <asp:Label ID="userInfoLbl" runat="server" Text="Konfirmasi Password" CssClass="userInfoLbl"></asp:Label>
                </div>


                <div class="passwordBox">
                    <asp:Label ID="passwordLbl" runat="server" Text="Password" CssClass="passwordLbl"></asp:Label>
                    <asp:TextBox ID="passwordTxt" runat="server" TextMode="Password" CssClass="passwordTxt"></asp:TextBox>
                    <asp:Label ID="passwordErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>

                <div class="updateBox">
                    <asp:Button ID="updateBtn" runat="server" Text="Konfirmasi Edit" CssClass="updateBtn" OnClick="updateBtn_Click" />
                </div>
            </div>

        </div>
    </div>

</asp:Content>
