<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="KomunitasDetailPage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.KomunitasDetailPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../CSS/KomunitasDetailPage_CSS.css" rel="stylesheet" />

    <div class="page">
        <div class="page-container">

            <div class="box">

                <div class="upper">
                    <div class="image">
                        <asp:Image ID="imgLogo" runat="server"
                            ImageUrl=""
                            CssClass="imgLogo" />
                    </div>
                    <div class="words">
                        <div class="komunitasName">
                            <asp:Label ID="komunitasNameLbl" runat="server" Text="" CssClass="komunitasNameLbl"></asp:Label>
                        </div>

                        <div class="box-fokus">
                            <asp:Label ID="fokusLbl" runat="server" Text="" CssClass="fokusLbl"></asp:Label>
                        </div>

                        <div class="aktivitas">
                            <div class="box-activity">
                                <img src="../../Assets/Images/voluntary_cari_komun.png" alt="" />
                                <asp:Label ID="countRelawanLbl" runat="server" Text="" CssClass="activityLbl"></asp:Label>
                            </div>
                            <div class="box-activity">
                                <img src="../../Assets/Images/aktivitas_cari_komun.png" alt="" />
                                <asp:Label ID="countKegiatanLbl" runat="server" Text="" CssClass="activityLbl"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="desc">
                    <asp:Label ID="descLbl" runat="server" Text="" CssClass="descLbl"></asp:Label>
                </div>

                <div class="contact">
                    <div class="box-contact">
                        <div class="logo">
                            <img src="../../Assets/Images/kegiatan_loc_logo.png" alt="" />
                        </div>
                        <div class="box-contact-text">
                            <asp:Label ID="alamatTitleLbl" runat="server" Text="Alamat" CssClass="contactHeadLbl"></asp:Label>
                            <asp:Label ID="alamatLbl" runat="server" Text="" CssClass="contactLbl"></asp:Label>
                        </div>
                    </div>
                    <div class="box-contact">
                        <div class="logo">
                            <img src="../../Assets/Images/telephone_cari_komun.png" alt="" />
                        </div>
                        <div class="box-contact-text">
                            <asp:Label ID="teleTitleLbl" runat="server" Text="Nomor Telepon" CssClass="contactHeadLbl"></asp:Label>
                            <asp:Label ID="teleLbl" runat="server" Text="" CssClass="contactLbl"></asp:Label>
                        </div>
                    </div>
                </div>

                <div class="gabung">
                    <asp:Button ID="gabungBtn" Text="Gabung Komunitas" CssClass="gabungBtn" runat="server" OnClick="gabungBtn_Click"></asp:Button>
                </div>

            </div>

        </div>
    </div>

</asp:Content>
