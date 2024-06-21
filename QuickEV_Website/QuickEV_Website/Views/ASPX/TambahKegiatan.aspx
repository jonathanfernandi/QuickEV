<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="TambahKegiatan.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.TambahKegiatan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../CSS/TambahKegiatan_CSS.css" rel="stylesheet" />

    <div class="page">
        <div class="container">

            <div class="header">
                <asp:Label ID="headerLbl" runat="server" Text="Buat kegiatan baru" CssClass="headerLbl"></asp:Label>
            </div>
            <div class="subHeader">
                <asp:Label ID="subHeader1Lbl" runat="server" Text="Sambungkan niat baikmu" CssClass="subHeaderLbl"></asp:Label>
            </div>

            <div class="form">

                <div class="formHeader1">
                    <asp:Label ID="formHeader1Lbl" runat="server" Text="Informasi Utama Kegiatan" CssClass="formHeader1Lbl"></asp:Label>
                </div>

                <div class="nameKegiatanBox">
                    <asp:Label ID="nameKegiatanLbl" runat="server" Text="Nama Kegiatan" CssClass="nameKegiatanLbl"></asp:Label>
                    <asp:TextBox ID="nameKegiatanTxt" runat="server" CssClass="nameKegiatanTxt"></asp:TextBox>
                    <asp:Label ID="nameKegiatanErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>

                <div class="descBox">
                    <asp:Label ID="descLbl" runat="server" Text="Deskripsi Kegiatan" CssClass="descLbl"></asp:Label>
                    <asp:TextBox ID="descTxt" runat="server" CssClass="descTxt"></asp:TextBox>
                    <asp:Label ID="descErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>

                <div class="fokusBox">
                    <asp:Label ID="fokusLbl" runat="server" Text="Fokus Kegiatan" CssClass="fokusLbl"></asp:Label>
                    <asp:DropDownList ID="fokusDDL" runat="server" CssClass="fokusDDL">
                        <asp:ListItem> </asp:ListItem>
                        <asp:ListItem>Lingkungan</asp:ListItem>
                        <asp:ListItem>Bencana Alam</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="fokusErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>

                <div class="registBox">
                    <div class="startRegistBox">
                        <asp:Label ID="startRegistLbl" runat="server" Text="Tanggal Buka Pendaftaran" CssClass="startRegistLbl"></asp:Label>
                        <asp:TextBox ID="startRegistTxt" Type="date" TextMode="Date" runat="server" CssClass="startRegistTxt"></asp:TextBox>
                        <asp:Label ID="startRegistErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>

                    <div class="endRegistBox">
                        <asp:Label ID="endRegistLbl" runat="server" Text="Tanggal Tutup Pendaftaran" CssClass="endRegistLbl"></asp:Label>
                        <asp:TextBox ID="endRegistTxt" Type="date" TextMode="Date" runat="server" CssClass="endRegistTxt"></asp:TextBox>
                        <asp:Label ID="endRegistErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
                </div>

                <div class="fotoBox">
                    <asp:Label ID="fotoLbl" runat="server" Text="Ilustrasi/Poster Kegiatan" CssClass="fotoLbl"></asp:Label>
                    <asp:FileUpload ID="fotoFU" runat="server" CssClass="fotoFU" />
                    <asp:Label ID="fotoErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>


                <div class="formHeader2">
                    <asp:Label ID="formHeader2Lbl" runat="server" Text="Informasi Detail Pekerjaan" CssClass="formHeader2Lbl"></asp:Label>
                </div>

                <div class="namaPekerjaanBox">
                    <asp:Label ID="namaPekerjaanLbl" runat="server" Text="Nama Pekerjaan" CssClass="namaPekerjaanLbl"></asp:Label>
                    <asp:TextBox ID="namaPekerjaanTxt" runat="server" CssClass="namaPekerjaanTxt"></asp:TextBox>
                    <asp:Label ID="namaPekerjaanErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label> 
                </div>

                <div class="relawanDibutuhkanBox">
                    <asp:Label ID="relawanDibutuhkanLbl" runat="server" Text="Jumlah Relawan yang Dibutuhkan" CssClass="relawanDibutuhkanLbl"></asp:Label>
                    <asp:TextBox ID="relawanDibutuhkanTxt" runat="server" CssClass="relawanDibutuhkanTxt"></asp:TextBox>
                    <asp:Label ID="relawanDibutuhkanErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label> 
                </div>

                <div class="tugasRelawanBox">
                    <asp:Label ID="tugasRelawanLbl" runat="server" Text="Tugas Relawan" CssClass="tugasRelawanLbl"></asp:Label>
                    <asp:TextBox ID="tugasRelawanTxt" runat="server" CssClass="tugasRelawanTxt"></asp:TextBox>
                    <asp:Label ID="tugasRelawanErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label> 
                </div>

                <div class="kriteriaRelawanBox">
                    <asp:Label ID="kriteriaRelawanLbl" runat="server" Text="Kriteria Relawan" CssClass="kriteriaRelawanLbl"></asp:Label>
                    <asp:TextBox ID="kriteriaRelawanTxt" runat="server" CssClass="kriteriaRelawanTxt"></asp:TextBox>
                    <asp:Label ID="kriteriaRelawanErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label> 
                </div>

                <div class="perlengkapanRelawanBox">
                    <asp:Label ID="perlengkapanRelawanLbl" runat="server" Text="Perlengkapan Relawan" CssClass="perlengkapanRelawanLbl"></asp:Label>
                    <asp:TextBox ID="perlengkapanRelawanTxt" runat="server" CssClass="perlengkapanRelawanTxt"></asp:TextBox>
                    <asp:Label ID="perlengkapanRelawanErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label> 
                </div>

                <div class="domisiliRelawanBox">
                    <asp:Label ID="domisiliRelawanLbl" runat="server" Text="Domisili Relawan" CssClass="domisiliRelawanLbl"></asp:Label>
                    <asp:DropDownList ID="domisiliRelawanDDL" runat="server" CssClass="domisiliRelawanDDL">
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
                    <asp:Label ID="domisiliRelawanErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label> 
                </div>

                <div class="formHeader3">
                    <asp:Label ID="formHeader3Lbl" runat="server" Text="Tempat dan Waktu Kegiatan" CssClass="formHeader3Lbl"></asp:Label>
                </div>

                <div class="lokasiBox">
                    <asp:Label ID="lokasiLbl" runat="server" Text="Lokasi Kegiatan" CssClass="lokasiLbl"></asp:Label>
                    <asp:TextBox ID="lokasiTxt" runat="server" CssClass="lokasiTxt"></asp:TextBox>
                    <asp:Label ID="lokasiErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label> 
                </div>

                <div class="dateBox">
                    <div class="startDateBox">
                        <asp:Label ID="startDateLbl" runat="server" Text="Tanggal Mulai Kegiatan" CssClass="startDateLbl"></asp:Label>
                        <asp:TextBox ID="startDateTxt" Type="date" TextMode="Date" runat="server" CssClass="startDateTxt"></asp:TextBox>
                        <asp:Label ID="startDateErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>

                    <div class="endDateBox">
                        <asp:Label ID="endDateLbl" runat="server" Text="Tanggal Akhir Kegiatan" CssClass="endDateLbl"></asp:Label>
                        <asp:TextBox ID="endDateTxt" Type="date" TextMode="Date" runat="server" CssClass="endDateTxt"></asp:TextBox>
                        <asp:Label ID="endDateErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
                </div>

                <div class="timeBox">
                    <div class="startTimeBox">
                        <asp:Label ID="startTimeLbl" runat="server" Text="Jam Mulai Kegiatan" CssClass="startTimeLbl"></asp:Label>
                        <asp:TextBox ID="startTimeTxt" TextMode="Time" InputType="Time" runat="server" CssClass="startTimeTxt"></asp:TextBox>
                        <asp:Label ID="startTimeErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>

                    <div class="endTimeBox">
                        <asp:Label ID="endTimeLbl" runat="server" Text="Jam Akhir Kegiatan" CssClass="endTimeLbl"></asp:Label>
                        <asp:TextBox ID="endTimeTxt" TextMode="Time" InputType="Time" runat="server" CssClass="endTimeTxt"></asp:TextBox>
                        <asp:Label ID="endTimeErrorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
                </div>

                <div class="tambahBox">
                    <asp:Button ID="tambahBtn" runat="server" Text="Tambah Kegiatan" CssClass="tambahBtn" OnClick="tambahBtn_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
