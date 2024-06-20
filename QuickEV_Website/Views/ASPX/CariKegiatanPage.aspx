<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="CariKegiatanPage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.CariKegiatan" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<link href="../CSS/CariKegiatanPage_CSS.css" rel="stylesheet" />
        <div class="Welcome_CariKegiatan_Container">
            <div class="Welcome_CariKegiatan_Container_Column">
                <asp:Label ID="Welcome_CariKegiatan_Container_Text1" runat="server" Text="Jadilah Bagian dari Kebaikan" CssClass="Welcome_CariKegiatan_Container_Text1"></asp:Label>
                <asp:Label ID="Welcome_CariKegiatan_Container_Text2" runat="server" Text="Cari peran yang kamu inginkan" CssClass="Welcome_CariKegiatan_Container_Text2"></asp:Label>
                <div class="TemukanKegiatan_Container">
                    <div class="Welcome_CariKegiatan_Container_LeftContent">
                        <asp:Label runat="server" Text="TEMUKAN KEGIATAN" CssClass="Welcome_CariKegiatan_Container_Text3"></asp:Label>
                    </div>
                    <div class="Welcome_CariKegiatan_Container_RightContent">
                       <div class="Triangle_CariKegiatan"></div>
                       <img class="Welcome_CariKegiatan_SearchIcon" src="../../Assets/Images/SearchWhite_Icon.png" />
                    </div>
                </div>
            </div>
        </div>

        <div class="AktivitasSearch_Container">
            <div class="TotalAktivitas_Container">
                <asp:Label ID="TotalAktivitas_Text" runat="server" Text="1000"></asp:Label> 
                <asp:Label ID="AktivitasMenunggu" runat="server" Text="Aktivitas Menunggumu"></asp:Label>
            </div>
            <div class="AktivitasSearch_FindAktivitas_Container">

            </div>

        </div>

</asp:Content>
