<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="KegiatanDetailPage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.KegiatanDetailPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../CSS/KegiatanDetailPage_CSS.css" rel="stylesheet" />

    <div class="page">
        <div class="container">

            <div class="box1">

                <div class="box-info">

                    <div class="box-title">
                        <asp:Label ID="titleLbl" runat="server" Text="" CssClass="titleLbl"></asp:Label>
                    </div>
                    <div class="box-fokus">
                        <asp:Label ID="fokusLbl" runat="server" Text="" CssClass="fokusLbl"></asp:Label>
                    </div>
                    <div class="row">
                        <img src="../../Assets/Images/calendar_logo.png" alt="" />
                        <div class="row-labels">
                            <asp:Label ID="jadwalEventTitleLbl" runat="server" Text="Jadwal Event" CssClass="box-info-row-label1"></asp:Label>
                            <asp:Label ID="jadwalEventLbl" runat="server" Text="" CssClass="box-info-row-label2"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <img src="../../Assets/Images/clock_kegiatan.png" alt="" />
                        <div class="row-labels">
                            <asp:Label ID="waktuEventTitleLbl" runat="server" Text="Waktu Event" CssClass="box-info-row-label1"></asp:Label>
                            <asp:Label ID="waktuEventLbl" runat="server" Text="" CssClass="box-info-row-label2"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <img src="../../Assets/Images/kegiatan_loc_logo.png" alt="" />
                        <div class="row-labels">
                            <asp:Label ID="lokasiTitleLbl" runat="server" Text="Lokasi" CssClass="box-info-row-label1"></asp:Label>
                            <asp:Label ID="lokasiLbl" runat="server" Text="" CssClass="box-info-row-label2"></asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <img src="../../Assets/Images/registration_kegiatan.png" alt="" />
                        <div class="row-labels">
                            <asp:Label ID="tanggalRegistrasiTitleLbl" runat="server" Text="Tanggal Registrasi" CssClass="box-info-row-label1"></asp:Label>
                            <asp:Label ID="tanggalRegistrasiLbl" runat="server" Text="" CssClass="box-info-row-label2"></asp:Label>
                        </div>
                    </div>

                    <div class="box-edit-button">
                        <a href="KegiatanEditPage.aspx?IdKegiatan=<%= Request.QueryString["IdKegiatan"] %>">
                            <span>Edit Kegiatan</span>
                            <asp:Image ID="editImg" ImageUrl="~/Assets/Images/edit_kegiatan.png" runat="server" CssClass="editImg" />
                        </a>
                    </div>

                </div>

            </div>

            <div class="box2">
                <div class="box-detail">

                    <div class="image">
                        <asp:Image ID="imgFotoKegiatan" runat="server"
                            ImageUrl=""
                            CssClass="imgFotoKegiatan" />
                    </div>

                    <div class="detail-header">
                        <div class="komunitas">
                            <div class="komunitas-logo">
                                <asp:Image ID="imgLogo" runat="server"
                                    ImageUrl=""
                                    CssClass="imgLogo" />
                            </div>
                            <div class="komunitasName">
                                <asp:Label ID="komunitasNameLbl" runat="server" Text="" CssClass="komunitasNameLbl"></asp:Label>
                            </div>
                        </div>
                        <div class="relawan">
                            <asp:Label ID="relawanTerkumpulTitleLbl" runat="server" Text="Relawan Terkumpul" CssClass="relawanTerkumpulTitleLbl"></asp:Label>
                            <asp:Label ID="relawanTerkumpulLbl" runat="server" Text="" CssClass="relawanTerkumpulLbl"></asp:Label>
                        </div>
                    </div>

                    <div class="desc-kegiatan">
                        <asp:Label ID="descKegiatanTitleLbl" runat="server" Text="DESKRIPSI KEGIATAN" CssClass="descKegiatanTitleLbl"></asp:Label>
                        <asp:Label ID="descKegiatanLbl" runat="server" Text="" CssClass="descKegiatanLbl"></asp:Label>
                    </div>

                    <div class="detail-kegiatan">
                        <asp:Label ID="detailKegiatanLbl" runat="server" Text="DETAIL KEGIATAN" CssClass="detailKegiatanLbl"></asp:Label>
                        <div class="row-detail">
                            <asp:Label ID="namaPekerjaanTitleLbl" runat="server" Text="Nama Pekerjaan" CssClass="title"></asp:Label>
                            <asp:Label ID="namaPekerjaanLbl" runat="server" Text="" CssClass="detail-labels"></asp:Label>
                        </div>
                        <div class="row-detail">
                            <asp:Label ID="tugasRelawanTitleLbl" runat="server" Text="Tugas Relawan" CssClass="title"></asp:Label>
                            <asp:Label ID="tugasRelawanLbl" runat="server" Text="" CssClass="detail-labels"></asp:Label>
                        </div>
                        <div class="row-detail">
                            <asp:Label ID="kriteriaRelawanTitleLbl" runat="server" Text="Kriteria Relawan" CssClass="title"></asp:Label>
                            <asp:Label ID="kriteriaRelawanLbl" runat="server" Text="" CssClass="detail-labels"></asp:Label>
                        </div>
                        <div class="row-detail">
                            <asp:Label ID="perlengkapanRelawanTitleLbl" runat="server" Text="Perlengkapan Relawan" CssClass="title"></asp:Label>
                            <asp:Label ID="perlengkapanRelawanLbl" runat="server" Text="" CssClass="detail-labels"></asp:Label>
                        </div>
                        <div class="row-detail">
                            <asp:Label ID="domisiliRelawanTitleLbl" runat="server" Text="Domisili Relawan" CssClass="title"></asp:Label>
                            <asp:Label ID="domisiliRelawanLbl" runat="server" Text="" CssClass="detail-labels"></asp:Label>
                        </div>

                    </div>
                </div>

            </div>
        </div>
    </div>


</asp:Content>
