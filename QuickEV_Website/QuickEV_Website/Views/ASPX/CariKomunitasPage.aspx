<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="CariKomunitasPage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.CariKomunitasPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../CSS/CariKomunitasPage_CSS.css" rel="stylesheet" />

    <div class="page">
        <div class="container-page">

            <div class="bigHeader">
                <asp:Label ID="counterLbl" runat="server" Text="" CssClass="counterLbl" Visible="true"></asp:Label>
                <asp:Label ID="bigHeaderLbl" runat="server" Text="Komunitas Menantimu" CssClass="bigHeaderLbl" Visible="true"></asp:Label>
                <asp:Image ID="countZeroImg" ImageUrl="~/Assets/Images/no-task_kegiatan.png" runat="server" Visible="false" CssClass="countZeroImg" />
                <asp:Label ID="countZeroLbl" runat="server" Text="Belum ada komunitas" Visible="false" CssClass="countZeroLbl"></asp:Label>
            </div>

            <div class="repeater">
                <asp:Repeater ID="volunteeringRpt" runat="server">
                    <ItemTemplate>
                        <div class="box">
                            <div class="image">
                                <asp:Image ID="imgLogoKomunitas" runat="server"
                                    ImageUrl='<%# "data:image/png;base64," + Convert.ToBase64String((byte[])Eval("LogoKomunitas")) %>'
                                    CssClass="imgLogoKomunitas" />
                            </div>
                            <div class="box-info">
                                <div class="box-name">
                                    <asp:Label ID="nameLbl" runat="server" Text='<%# Eval("NamaKomunitas").ToString().ToUpper() %>' CssClass="nameLbl"></asp:Label>
                                </div>
                                <div class="box-domisili">
                                    <img src="../../Assets/Images/kegiatan_loc_logo.png" />
                                    <asp:Label ID="domisiliLbl" runat="server" Text='<%# Eval("Domisili") %>' CssClass="domisiliLbl"></asp:Label>
                                </div>
                                <div class="box-fokus">
                                    <img src="../../Assets/Images/focus_cari_komun.png" alt="" />
                                    <asp:Label ID="fokusLbl" runat="server" Text='<%# Eval("Fokus") %>' CssClass="fokusLbl"></asp:Label>
                                </div>
                                <div class="box-activity">
                                    <img src="../../Assets/Images/voluntary_cari_komun.png" alt="" />
                                    <span><%# Eval("CountRelawan") + " Relawan"%></span>
                                </div>
                                <div class="box-activity">
                                    <img src="../../Assets/Images/aktivitas_cari_komun.png" alt="" />
                                    <span><%# Eval("CountKegiatan") + " Kegiatan"%></span>
                                </div>
                                <div class="detail">
                                    <a href='<%#"KomunitasDetailPage.aspx?IdKomunitas=" + Eval("IdKomunitas") %>'><span>Lihat Lengkap</span>
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
