<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="TentangKamiPage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.TentangKamiPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <link href="../CSS/TentangKamiPage_CSS.css" rel="stylesheet" />
    <div class="page">

        <div class="Welcome_TentangKami_Container">
            <div class="Welcome_TentangKami_Column_Container">
                <div class="Welcome_TentangKami_Column1_Container">
                    <asp:Label ID="Welcome_TentangKami_Column1_Text1" runat="server" Text="Satu Lingkungan,"></asp:Label>
                    <asp:Label ID="Welcome_TentangKami_Column1_Text2" runat="server" Text="Demi Kemanusiaan"></asp:Label>
                </div>
                <div class="Welcome_TentangKami_Column2_Container">
                    <asp:Label ID="Welcome_TentangKami_Column2_Text1" runat="server" Text="Bersama kita jaga lingkungan" CssClass="Welcome_TentangKami_Container_Text1"></asp:Label>
                    <asp:Label ID="Welcome_TentangKami_Column2_Text2" runat="server" Text="untuk masa depan yang lebih baik" CssClass="Welcome_TentangKami_Column2_Text2"></asp:Label>
                </div>
            </div>
        </div>

        <div class="CeritaKami_TentangKami_Container">
            <div class="CeritaKami_TentangKami_Text_Container">
                <asp:Label ID="CeritaKami_TentangKami_Header" runat="server" Text="Cerita Kami" CssClass="CeritaKami_TentangKami_Header"></asp:Label>
                <asp:Label ID="CeritaKami_TentangKami_Text" runat="server" Text="" CssClass="CeritaKami_TentangKami_Text">QuickEV dibangun pada tahun 2024 untuk mengatasi
                <br />
                masalah-masalah lingkungan hidup yang terjadi pada saat ini.<br />
                QuickEV diciptakan melalui berbagai
                <br />
                proses yang mengambil nilai-nilai kemanusiaan.</asp:Label>
            </div>
            <div class="Profile_TentangKami_Video">
                <video class="Profile_TentangKami_Video_SRC" src="../../Assets/Images/Profile_Video_resize.mp4" controls="controls" />
            </div>
            <div class="AmbilBagian_Btn">
                <asp:Button ID="AmbilBagianBtn" runat="server" Text="Ambil Peran" CssClass="AmbilBagianBtn" OnClick="AmbilBagianBtn_Click" />
            </div>
        </div>



        <div class="Mission_TentangKami_Container">
            <div class="Mission_TentangKami_VisiMisi">
                <asp:Label ID="Mission_TentangKami_VisiHeader" runat="server" Text="Visi" CssClass="Mission_TentangKami_VisiHeader"></asp:Label>
                <asp:Label ID="Mission_TentangKami_MisiHeader" runat="server" Text="Misi" CssClass="Mission_TentangKami_MisiHeader"></asp:Label>
            </div>
            <div class="Mission_TentangKami_Text">
                <asp:Label ID="Mission_TentangKami_VisiText" runat="server" Text="" CssClass="Mission_TentangKami_VisiText">Menjadi pelopor gerakan sukarela dalam pelestarian lingkungan,
                <br />
                dengan menginspirasi dan memberdayakan individu serta komunitas
                <br />
                untuk bersama-sama menciptakan bumi yang lebih bersih, sehat, dan lestari.
                </asp:Label>
                <asp:Label ID="Mission_TentangKami_MisiText" runat="server" Text="" CssClass="Mission_TentangKami_MisiText">Kami berkomitmen untuk meningkatkan kesadaran lingkungan melalui berbagai
                <br />
                program sukarela yang inovatif dan berkelanjutan. Dengan menghubungkan relawan
                <br />
                dengan proyek-proyek pelestarian alam, kami bertujuan untuk mengurangi dampak
                <br />
                lingkungan negatif, mempromosikan gaya hidup ramah lingkungan, dan membangun
                <br />
                komunitas yang peduli serta bertanggung jawab terhadap kelestarian alam.
                <br />
                Melalui edukasi, kolaborasi, dan aksi nyata, kami berusaha menciptakan perubahan
                <br />
                positif yang berdampak panjang bagi generasi sekarang dan mendatang.
                </asp:Label>
            </div>
        </div>

        <div class="Fitur_TentangKami_Container">
            <asp:Label ID="Fitur_TentangKami_Header" runat="server" Text="Misi untuk Lingkungan" CssClass="Fitur_TentangKami_Header"></asp:Label>

            <div class="Fitur_TentangKami_CariKegiatan_Container">
                <div class="Fitur_TentangKami_CariKegiatan_LeftContent">
                    <img class="CariKegiatan_Pic" src="../../Assets/Images/relawan_cariaktivitas.jpg" width="500px" height="325px" />
                </div>
                <div class="Fitur_TentangKami_CariKegiatan_RightContent">
                    <asp:Label ID="Fitur_TentangKami_CariKegiatan_RightContent_Header" runat="server" Text="Cari Kegiatan" CssClass="Fitur_TentangKami_CariKegiatan_RightContent_Header"></asp:Label>
                    <asp:Label ID="Fitur_TentangKami_CariKegiatan_RightContent_Text" runat="server" Text="Lorem Ipsum dolor si amet" CssClass="Fitur_TentangKami_CariKegiatan_RightContent_Text">Fitur Cari Kegiatan kami memudahkan Anda menemukan berbagai peluang volunteering lingkungan yang sesuai dengan minat dan lokasi Anda. Dengan antarmuka yang intuitif dan user-friendly, 
                    Anda dapat menyaring kegiatan berdasarkan kategori seperti pembersihan pantai, penanaman pohon, daur ulang, edukasi lingkungan, dan banyak lagi. Setiap kegiatan dilengkapi dengan deskripsi lengkap, 
                    waktu, tempat, dan kontak person yang dapat dihubungi, sehingga Anda bisa segera bergabung dan berkontribusi. Temukan kegiatan yang paling sesuai dengan jadwal dan passion Anda, serta jadilah bagian 
                    dari gerakan global untuk menyelamatkan bumi.
                    </asp:Label>
                </div>
            </div>

            <div class="Fitur_TentangKami_CariOrganisasi_Container">
                <div class="Fitur_TentangKami_CariOrganisasi_LeftContent">
                    <asp:Label ID="Fitur_TentangKami_CariOrganisasi_LeftContent_Header" runat="server" Text="Cari Organisasi" CssClass="Fitur_TentangKami_CariOrganisasi_LeftContent_Header"></asp:Label>
                    <asp:Label ID="Fitur_TentangKami_CariOrganisasi_LeftContent_Text" runat="server" Text="Lorem Ipsum dolor si amet" CssClass="Fitur_TentangKami_CariOrganisasi_LeftContent_Text">Fitur Cari Organisasi kami dirancang untuk membantu Anda menemukan dan terhubung dengan berbagai organisasi lingkungan yang membutuhkan dukungan sukarelawan. Dengan pencarian 
                    yang mudah dan terperinci, Anda bisa menemukan organisasi berdasarkan fokus kegiatan mereka, seperti konservasi alam, pengelolaan sampah, pendidikan lingkungan, atau energi terbarukan. 
                    Melalui fitur ini, Anda dapat menemukan organisasi yang paling sesuai dengan nilai dan minat Anda, memungkinkan Anda untuk berkolaborasi dan memberikan dampak nyata bagi kelestarian lingkungan.
                    </asp:Label>
                </div>
                <div class="Fitur_TentangKami_CariOrganisasi_RightContent">
                    <img class="CariOrganisasi_Pic" src="../../Assets/Images/TentangKami_CariOrganisasi.jpg" width="500px" height="325px" />
                </div>
            </div>

            <div class="Fitur_TentangKami_Donasi_Container">
                <div class="Fitur_TentangKami_Donasi_LeftContent">
                    <img class="Donasi_Pic" src="../../Assets/Images/TentangKami_Welcome.jpg" width="500px" height="325px" />
                </div>
                <div class="Fitur_TentangKami_CariKegiatan_RightContent">
                    <asp:Label ID="Fitur_TentangKami_Donasi_RightContent_Header" runat="server" Text="Donasi" CssClass="Fitur_TentangKami_Donasi_RightContent_Header"></asp:Label>
                    <asp:Label ID="Fitur_TentangKami_Donasi_RightContent_Text" runat="server" Text="" CssClass="Fitur_TentangKami_Donasi_RightContent_Text">Fitur Donasi kami memudahkan Anda memberikan dukungan finansial untuk program pelestarian lingkungan. Dengan platform yang aman, Anda dapat memilih proyek atau organisasi yang ingin didukung. 
                    Setiap donasi, berapapun jumlahnya, berdampak besar pada inisiatif seperti reboisasi, konservasi satwa, dan pembersihan lautan. Kami menjamin transparansi penggunaan dana, sehingga Anda dapat 
                    melihat bagaimana kontribusi Anda membantu menciptakan dunia yang lebih hijau dan berkelanjutan.
                    </asp:Label>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
