<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.ProfilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../CSS/ProfilePage_CSS.css" rel="stylesheet" />

    <div class="page">
        <div class="page-container">

            <% if (QuickEV_Website.Controller.UserController.IsUserLoggedIn())
                {
                    if (QuickEV_Website.Controller.UserController.IsUserRelawan())
                    {
            %>
            <div class="relawanContainer">
                <h1>Profile</h1>
                <div class="profile">
                    <%--<div class="items">--%>
                    <div class="imageRelawan">
                        <asp:Image ID="imgLogo2" runat="server"
                            ImageUrl="~/Assets/Images/voluntary_cari_komun.png"
                            CssClass="imgLogo2" />
                    </div>
                    <div class="information">
                        <div class="usernameBox">
                            <asp:Label ID="usernameLblRelawan" runat="server" Text="" CssClass="usernameLbl"></asp:Label>
                        </div>
                        <div class="nameBox">
                            <asp:Label ID="nameLblRelawan" runat="server" Text="" CssClass="nameLbl"></asp:Label>
                        </div>
                        <div class="counter">
                            <div class="counterBox">
                                <img src="../../Assets/Images/aktivitas_cari_komun.png" alt="" />
                                <%--<asp:Label ID="countKegiatanLblRelawan" runat="server" Text="" CssClass="counterLbl"></asp:Label>--%>
                                <asp:HyperLink ID="countKegiatanLblRelawan" Text="" NavigateUrl="~/Views/ASPX/SemuaKegiatanRelawanPage.aspx" runat="server" CssClass="counterLbl"></asp:HyperLink>
                            </div>
                            <div class="counterBox">
                                <img src="../../Assets/Images/komunitas_SignUp_Logo.png" alt="" />
                                <%--<asp:Label ID="countKomunitasLblRelawan" runat="server" Text="" CssClass="counterLbl"></asp:Label>--%>
                                <asp:HyperLink ID="countKomunitasLblRelawan" Text="" NavigateUrl="~/Views/ASPX/SemuaKomunitasRelawanPage.aspx" runat="server" CssClass="counterLbl"></asp:HyperLink>
                            </div>
                        </div>
                    </div>
                    <%--</div>--%>
                    <div class="updateBox">
                        <asp:Button ID="updateBtnRelawan" runat="server" Text="Edit Profile" CssClass="updateBtn" OnClick="updateBtnRelawan_Click" />
                    </div>
                </div>

                <h1>Kegiatan</h1>
                <div class="kegiatan">

                    <asp:Label ID="countZeroLbl" runat="server" Text="Belum ada kegiatan diikuti." Visible="false" CssClass="countZeroLbl"></asp:Label>

                    <div class="repeaterContainer">
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
                    <div class="seeAll">
                        <asp:Button ID="seeAllBtnRelawan" runat="server" Text="Lihat Semua" CssClass="seeAllBtn" OnClick="seeAllBtnRelawan_Click" />
                    </div>

                </div>

                <h1>Komunitas</h1>
                <div class="komunitas">
                    <asp:Label ID="countZeroLbl2" runat="server" Text="Belum ada komunitas diikuti." Visible="false" CssClass="countZeroLbl2"></asp:Label>
                    <div class="repeaterContainer2">
                        <asp:Repeater ID="volunteeringRpt2" runat="server">
                            <ItemTemplate>
                                <div class="box2">
                                    <div class="image2">
                                        <asp:Image ID="imgLogoKomunitas" runat="server"
                                            ImageUrl='<%# "data:image/png;base64," + Convert.ToBase64String((byte[])Eval("LogoKomunitas")) %>'
                                            CssClass="imgLogoKomunitas2" />
                                    </div>
                                    <div class="box-info2">
                                        <div class="box-name2">
                                            <asp:Label ID="nameLbl" runat="server" Text='<%# Eval("NamaKomunitas").ToString().ToUpper() %>' CssClass="nameLbl2"></asp:Label>
                                        </div>
                                        <div class="box-belowname">
                                            <div class="box-domisili2">
                                                <img src="../../Assets/Images/kegiatan_loc_logo.png" />
                                                <asp:Label ID="domisiliLbl" runat="server" Text='<%# Eval("Domisili") %>' CssClass="domisiliLbl2"></asp:Label>
                                            </div>
                                            <div class="box-fokus2">
                                                <img src="../../Assets/Images/focus_cari_komun.png" alt="" />
                                                <asp:Label ID="fokusLbl" runat="server" Text='<%# Eval("Fokus") %>' CssClass="fokusLbl2"></asp:Label>
                                            </div>
                                            <div class="box-activity2">
                                                <img src="../../Assets/Images/voluntary_cari_komun.png" alt="" />
                                                <span><%# Eval("CountRelawan") + " Relawan"%></span>
                                            </div>
                                            <div class="box-activity2">
                                                <img src="../../Assets/Images/aktivitas_cari_komun.png" alt="" />
                                                <span><%# Eval("CountKegiatan") + " Kegiatan"%></span>
                                            </div>
                                        </div>
                                        <div class="detail2">
                                            <a href='<%#"KomunitasDetailPage.aspx?IdKomunitas=" + Eval("IdKomunitas") %>'><span>Lihat Lengkap</span>
                                                <asp:Image ID="arrow" ImageUrl="~/Assets/Images/play_kegiatan.png" runat="server" CssClass="arrow2" />
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:Repeater>
                    </div>
                    <div class="seeAll">
                        <asp:Button ID="seeAllBtnRelawan2" runat="server" Text="Lihat Semua" CssClass="seeAllBtn" OnClick="seeAllBtnRelawan2_Click" />
                    </div>
                </div>

            </div>
            <%                             
                }
                else if (!QuickEV_Website.Controller.UserController.IsUserRelawan())
                {
            %>
            <div class="komunitasContainer">
                <h1>Profile</h1>
                <div class="profile">
                    <%--<div class="items">--%>
                    <div class="image">
                        <asp:Image ID="imgLogo" runat="server"
                            ImageUrl=""
                            CssClass="imgLogo" />
                    </div>
                    <div class="information">
                        <div class="usernameBox">
                            <asp:Label ID="usernameLbl" runat="server" Text="" CssClass="usernameLbl"></asp:Label>
                        </div>
                        <div class="nameBox">
                            <asp:Label ID="nameLbl" runat="server" Text="" CssClass="nameLbl"></asp:Label>
                        </div>
                        <div class="counter">
                            <div class="counterBox">
                                <img src="../../Assets/Images/aktivitas_cari_komun.png" alt="" />
                                <%--<asp:Label ID="countKegiatanLbl" runat="server" Text="" CssClass="counterLbl"></asp:Label>--%>
                                <asp:HyperLink ID="countKegiatanLbl" Text="" NavigateUrl="~/Views/ASPX/KegiatanPage.aspx" runat="server" CssClass="counterLbl"></asp:HyperLink>
                            </div>
                            <div class="counterBox">
                                <img src="../../Assets/Images/voluntary_cari_komun.png" alt="" />
                                <%--<asp:Label ID="countRelawanLbl" runat="server" Text="" CssClass="counterLbl"></asp:Label>--%>
                                <asp:HyperLink ID="countRelawanLbl" Text="" NavigateUrl="~/Views/ASPX/SemuaRelawanKomunitasPage.aspx" runat="server" CssClass="counterLbl"></asp:HyperLink>
                            </div>
                        </div>
                    </div>
                    <%--</div>--%>
                    <div class="updateBox">
                        <asp:Button ID="updateBtn" runat="server" Text="Edit Profile" CssClass="updateBtn" OnClick="updateBtn_Click" />
                    </div>
                </div>

<%--                <h1>Relawan</h1>
                <div class="relawan">
                </div>--%>

            </div>
            <%
                    }
                }
            %>
        </div>
    </div>

</asp:Content>
