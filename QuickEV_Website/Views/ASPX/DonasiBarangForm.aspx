<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="DonasiBarangForm.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.DonasiBarangForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../CSS/DonasiBarangForm_CSS.css" rel="stylesheet" />

    <div class="page">
        <div class="page-container">

            <div class="words">
                <asp:Label ID="headerLbl" runat="server" Text="Donasi Anda Hari Ini, Dampak Nyata untuk Masa Depan" CssClass="headerLbl"></asp:Label>
                <asp:Label ID="subheaderLbl" runat="server" Text="Setiap Sumbangan Membawa Harapan Baru bagi Mereka" CssClass="subheaderLbl"></asp:Label>
            </div>

            <div class="form">

                <div class="info">
                    <asp:Label ID="step1" runat="server" Text="Step 1: Isi formulir" CssClass="step"></asp:Label>
                </div>

                <div class="box">
                    <asp:Label ID="nameLbl" runat="server" Text="Nama Donatur" CssClass="lbl"></asp:Label>
                    <asp:TextBox ID="nameTxt" runat="server" CssClass="txt"></asp:TextBox>
<%--                    <asp:RequiredFieldValidator ID="nameValidator" runat="server"
                        ControlToValidate="nameTxt" ErrorMessage="Nama Donatur harus diisi."
                        ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>--%>
                </div>
                <div class="box">
                    <asp:Label ID="emailLbl" runat="server" Text="Email" CssClass="lbl"></asp:Label>
                    <asp:TextBox ID="emailTxt" runat="server" CssClass="txt"></asp:TextBox>
<%--                    <asp:RequiredFieldValidator ID="emailValidator" runat="server"
                        ControlToValidate="emailTxt" ErrorMessage="Email harus diisi."
                        ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>--%>
                </div>
                <div class="box">
                    <asp:Label ID="telpLbl" runat="server" Text="No. Telepon Aktif" CssClass="lbl"></asp:Label>
                    <asp:TextBox ID="telpTxt" runat="server" CssClass="txt"></asp:TextBox>
<%--                    <asp:RequiredFieldValidator ID="telpValidator" runat="server"
                        ControlToValidate="telpTxt" ErrorMessage="No. Telepon harus diisi."
                        ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>--%>
                </div>

                <div class="box">
                    <asp:Label ID="jenisLbl" runat="server" Text="Jenis Barang" CssClass="lbl"></asp:Label>
                    <asp:DropDownList ID="jenisDDL" runat="server" CssClass="txt">
                        <asp:ListItem> </asp:ListItem>
                        <asp:ListItem>Baju</asp:ListItem>
                        <asp:ListItem>Obat</asp:ListItem>
                        <asp:ListItem>Mainan</asp:ListItem>
                        <asp:ListItem>Sembako</asp:ListItem>
                    </asp:DropDownList>
<%--                    <asp:RequiredFieldValidator ID="jenisValidator" runat="server"
                        ControlToValidate="jenisDDL" ErrorMessage="Jenis Barang harus dipilih."
                        ForeColor="Red" Display="Dynamic" InitialValue=""></asp:RequiredFieldValidator>--%>
                </div>

                <div class="box">
                    <asp:Label ID="kondisiLbl" runat="server" Text="Kondisi Barang" CssClass="lbl"></asp:Label>
                    <asp:DropDownList ID="kondisiDDL" runat="server" CssClass="txt">
                        <asp:ListItem> </asp:ListItem>
                        <asp:ListItem>Baru</asp:ListItem>
                        <asp:ListItem>Bekas dan Layak Pakai</asp:ListItem>
                    </asp:DropDownList>
<%--                    <asp:RequiredFieldValidator ID="kondisiValidator" runat="server"
                        ControlToValidate="kondisiDDL" ErrorMessage="Kondisi Barang harus dipilih."
                        ForeColor="Red" Display="Dynamic" InitialValue=""></asp:RequiredFieldValidator>--%>
                </div>

                <div class="info">
                    <asp:Label ID="step2" runat="server" Text="Step 2: Kirim barang ke alamat di bawah ini" CssClass="step"></asp:Label>
                    <div class="loc">
                        <asp:Image ID="locImg" ImageUrl="~/Assets/Images/kegiatan_loc_logo.png" runat="server" CssClass="locImg"/>
                        <asp:Label ID="locLbl" runat="server" Text="Jl. Raya Kb. Jeruk No.27, RT.1/RW.9, Kemanggisan, Kec. Palmerah, Kota Jakarta Barat, Daerah Khusus Ibukota Jakarta 11530" CssClass="loc"></asp:Label>
                    </div>
                </div>

                <div class="donate">
                    <asp:Button ID="donateBtn" runat="server" Text="Donasi" CssClass="donateBtn" OnClick="donateBtn_Click" />
                </div>

            </div>

        </div>
    </div>

</asp:Content>
