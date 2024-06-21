<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="SemuaKegiatanRelawanPage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.SemuaKegiatanRelawanPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <link href="../CSS/SemuaKegiatanRelawanPage_CSS.css" rel="stylesheet" />

    <div class="page">
        <div class="bigHeader">
            <asp:Label ID="bigHeaderLbl" runat="server" Text="Semua Kegiatan Yang Kamu Ikuti" CssClass="bigHeaderLbl" Visible="true"></asp:Label>
        </div>

        <div class="container">
            <asp:Repeater ID="volunteeringRpt" runat="server">
                <ItemTemplate>
                    <div class="box">
                        <asp:Image ID="imgFotoKegiatan" runat="server"
                            ImageUrl='<%# "data:image/png;base64," + Convert.ToBase64String((byte[])Eval("FotoKegiatan")) %>'
                            CssClass="imgFotoKegiatan" />
                        <div class="box-info">
                            <div class="box-title">
                                <asp:Label ID="titleLbl" runat="server" Text='<%# Eval("NamaKegiatan").ToString().ToUpper() %>' CssClass="titleLbl"></asp:Label>
                            </div>
                            <div class="box-komunitasName">
                                <asp:Label ID="komunitasNameLbl" runat="server" Text='<%# Eval("NamaKomunitas") %>' CssClass="komunitasNameLbl"></asp:Label>
                            </div>
                            <div class="row">
                                <img src="../../Assets/Images/calendar_logo.png" alt="" />
                                <%--<span><%# Eval("StartEventDate", "{dd MMMM yyyy}") %> - <%# Eval("EndEventDate", "{dd MMMM yyyy}") %></span>--%>
                                <span><%# QuickEV_Website.Views.ASPX.KegiatanPage.GetDateRange(Eval("StartEventDate"), Eval("EndEventDate")) %></span>
                            </div>
                            <div class="row">
                                <img src="../../Assets/Images/kegiatan_loc_logo.png" alt="" />
                                <span><%# Eval("Domisili") %></span>
                            </div>
                            <div class="detail">
                                <a href='<%#"KegiatanDetail2Page.aspx?IdKegiatan=" + Eval("IdKegiatan") %>'><span>Lihat Lengkap</span>
                                    <asp:Image ID="arrow" ImageUrl="~/Assets/Images/play_kegiatan.png" runat="server" CssClass="arrow" />
                                </a>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>
    </div>

</asp:Content>
