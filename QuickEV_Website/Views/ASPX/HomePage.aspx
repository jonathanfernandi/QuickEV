<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../CSS/HomePage_CSS.css" rel="stylesheet" />

    <!-- SPLASH SCREEN -->

    <div class="page">

        <div class="splashscreen" runat="server">
            <div class="content">
                <h1>Kebaikanmu, Kekuatan Indonesia</h1>
                <asp:Button ID="splashbutton" runat="server" Text="CARI KEGIATAN" CssClass="splashbutton" OnClick="splashbutton_Click" />
            </div>
        </div>


        <!-- BAGIAN DARI KAMI -->

        <div class="bagiankami">

            <div class="container-page">


                <div class="big_container">
                    <h2>Bersama sesama menjadi relawan dalam aksi sosial di masyarakat</h2>
                    <p>Menyebarkan kebahagiaan dengan menjadi relawan masyarakat. Berikan rasa semangat untuk menjadi bagian dari kami.</p>
                </div>


                <div class="four_container">

                    <div class="title">
                        <h1>Jadilah Bagian dari Kami</h1>
                    </div>

                    <div class="x_small_container">

                        <div class="small_container">
                            <div class="icon_container">
                                <img src="../../Assets/Images/image 9.png" alt="relawan icon" class="icon" />
                            </div>
                            <h2>Jadi Relawan</h2>
                            <p>Pertama kali menjadi relawan? Ayo menjadi bagian dari kami dengan mengikuti aktivitas yang kami adakan!</p>
                            <asp:Button ID="relawanBtn" runat="server" Text="CARI KEGIATAN" CssClass="small_container_button" OnClick="relawanBtn_Click" />
                        </div>

                        <div class="small_container">
                            <div class="icon_container">
                                <img src="../../Assets/Images/image 10.png" alt="komunitas icon" class="icon" />
                            </div>
                            <h2>Cari Komunitas</h2>
                            <p>Bersosialisasi dan belajar bersama teman baru, menjadi bagian dari komunitas masyarakat!</p>
                            <asp:Button ID="organisasiBtn" runat="server" Text="CARI KOMUNITAS" CssClass="small_container_button" OnClick="organisasiBtn_Click" />
                        </div>

                        <div class="small_container">
                            <div class="icon_container">
                                <img src="../../Assets/Images/image 11.png" alt="donasi icon" class="icon" />
                            </div>
                            <h2>Bantu Donasi</h2>
                            <p>Berikan kebutuhan masyarakat membutuhkan melalui donasi yang kami adakan. Mari kita berdonasi!</p>
                            <asp:Button ID="donasiBtn" runat="server" Text="DONASI" CssClass="small_container_button" />
                        </div>

                    </div>
                </div>
            </div>
        </div>

        <!-- PROGRAM QUICKEV -->

        <div class="program">

            <div class="program_container">

                <div class="program-h1">
                    <h1>Program QuickEV</h1>
                </div>

                <div class="five_content">

                    <div class="content_program">
                        <img src="../../Assets/Images/membangun.jpg" alt="gambar program" class="logo_content" />
                        <h2>Muda Membangun</h2>
                        <p>Bersama Membangun Semangat Belajar</p>
                    </div>

                    <div class="content_program">
                        <img src="../../Assets/Images/membantu.jpg" alt="gambar program" class="logo_content" />
                        <h2>Muda Membantu</h2>
                        <p>Ayo Bantu Sesama Membutuhkan</p>
                    </div>

                    <div class="content_program">
                        <img src="../../Assets/Images/menjaga.jpeg" alt="gambar program" class="logo_content" />
                        <h2>Muda Menjaga</h2>
                        <p>Mari Jaga Kebersihan Lingkungan</p>
                    </div>

                    <div class="content_program">
                        <img src="../../Assets/Images/berbagi.jpg" alt="gambar program" class="logo_content" />
                        <h2>Muda Berbagi</h2>
                        <p>Bersama Berbagi Pengetahuan Umum</p>
                    </div>

                </div>

            </div>
        </div>



        <!-- TESTIMONI -->

        <div class="testimoni">

            <div class="testimoni_title">
                <h2>Testimoni</h2>
            </div>

            <div class="whole_card">

                <div class="card">
                    <div class="logo_card">
                        <img src="../../Assets/Images/KUN.png" alt="testimoni icon" class="logo" />
                    </div>
                    <h2>KUN Humanity System</h2>
                    <p>Saya sangat terkesan dengan pengalaman saya menggunakan platform volunteer untuk korban bencana alam ini. Dengan fitur-fitur yang user-friendly, saya dapat dengan mudah menemukan proyek-proyek yang sesuai dengan minat dan keahlian saya.</p>
                </div>

                <div class="card">
                    <div class="logo_card">
                        <img src="../../Assets/Images/ACT.jpg" alt="testimoni icon" class="logo" />
                    </div>
                    <h2>Aksi Cepat Tanggap (ACT)</h2>
                    <p>Melalui platform ini kami mampu menyatukan dan membantu sesama kami yang mengalami bencana. Selain mudah digunakan, QuickEV juga berkontribusi besar dalam suksesnya event yang kami adakan melalui kontrbusi berupa jasa.</p>
                </div>

                <div class="card">
                    <div class="logo_card">
                        <img src="../../Assets/Images/MDMC.png" alt="testimoni icon" class="logo" />
                    </div>
                    <h2>MDMC</h2>
                    <p>Dengan fitur-fitur yang informatif dan mudah digunakan, saya dapat langsung terlibat dalam proyek-proyek yang dibutuhkan. Pengalaman ini membuat saya merasa terhubung secara langsung dengan mereka yang membutuhkan bantuan, memberikan makna yang mendalam bagi kontribusi saya.</p>
                </div>

            </div>
        </div>
    </div>


</asp:Content>
