<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="EditRelawanProfilePage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.EditRelawanProfilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../CSS/EditRelawanProfilePage_CSS.css" rel="stylesheet" />

    <div class="page">
        <div class="container-page">

            <div class="header">
                <asp:Label ID="headerLbl" runat="server" Text="Edit Profile" CssClass="headerLbl"></asp:Label>
            </div>

            <div class="form">

                <div class="usernameBox">
                    <asp:Label ID="usernameLbl" runat="server" Text="Username" CssClass="usernameLbl"></asp:Label>
                    <asp:TextBox ID="usernameTxt" runat="server" CssClass="usernameTxt"></asp:TextBox>
                    <asp:Label ID="usernameErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>

                <div class="nameBox">
                    <asp:Label ID="nameLbl" runat="server" Text="Name" CssClass="nameLbl"></asp:Label>
                    <asp:TextBox ID="nameTxt" runat="server" CssClass="nameTxt"></asp:TextBox>
                    <asp:Label ID="nameErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>


                <div class="provinsiBox">
                    <asp:Label ID="provinsiLbl" runat="server" Text="Provinsi Domisili" CssClass="provinsiLbl"></asp:Label>
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

                <div class="passwordBox">
                    <asp:Label ID="passwordLbl" runat="server" Text="Password" CssClass="passwordLbl"></asp:Label>
                    <asp:TextBox ID="passwordTxt" runat="server" TextMode="Password" CssClass="passwordTxt"></asp:TextBox>
                    <asp:Label ID="passwordErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>

                <div class="updateBox">
                    <asp:Button ID="updateBtn" runat="server" Text="Konfirmasi Edit" CssClass="updateBtn" />
                </div>
            </div>

        </div>
    </div>

</asp:Content>
