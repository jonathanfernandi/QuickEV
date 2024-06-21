<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="CariKegiatanPage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.CariKegiatan" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/CariKegiatanPage_CSS.css" rel="stylesheet" />


    <div class="container-page">

        <div class="Welcome_CariKegiatan_Container">
            <div class="Welcome_CariKegiatan_Container_Column">
                <asp:Label ID="Welcome_CariKegiatan_Container_Text1" runat="server" Text="Jadilah Bagian dari Kebaikan" CssClass="Welcome_CariKegiatan_Container_Text1"></asp:Label>
                <asp:Label ID="Welcome_CariKegiatan_Container_Text2" runat="server" Text="Cari peran yang kamu inginkan" CssClass="Welcome_CariKegiatan_Container_Text2"></asp:Label>
<%--                <div class="TemukanKegiatan_Container">
                    <asp:Label ID="Welcome_CariKegiatan_Container_Text3" runat="server" Text="TEMUKAN KEGIATAN" CssClass="Welcome_CariKegiatan_Container_Text3"></asp:Label>
                </div>--%>
            </div>
        </div>
    </div>

    <div class="page">
        <div class="bigHeader">
            <asp:Label ID="counterLbl" runat="server" Text="" CssClass="counterLbl" Visible="true"></asp:Label>
            <asp:Label ID="bigHeaderLbl" runat="server" Text="Aktivitas Menunggumu" CssClass="bigHeaderLbl" Visible="true"></asp:Label>
            <asp:Image ID="countZeroImg" ImageUrl="~/Assets/Images/no-task_kegiatan.png" runat="server" Visible="false" CssClass="countZeroImg" />
            <asp:Label ID="countZeroLbl" runat="server" Text="Belum ada kegiatan" Visible="false" CssClass="countZeroLbl"></asp:Label>
        </div>

        <div class="repeater">
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
