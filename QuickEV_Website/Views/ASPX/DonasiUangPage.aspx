<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="DonasiUangPage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.DonasiUangPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../CSS/DonasiUangPage_CSS.css" rel="stylesheet" />
    <div class="DonatePage_Container">
        <div class="DonatePage_LeftContent">
            <asp:Label ID="DonatePage_Text1" runat="server" Text="" CssClass="DonatePage_Text1">Donasi untuk Dukung <br />Misi Kami</asp:Label>
            <asp:Label ID="DonatePage_Text2" runat="server" Text="" CssClass="DonatePage_Text2">Setiap donasi, seberapa banyak donasi, semua memberikan dampak <br />pada misi kami untuk membantu dunia menjadi lebih baik.</asp:Label>
            <asp:Label ID="DonatePage_Text3" runat="server" Text="" CssClass="DonatePage_Text3">Dengan dukungan Anda, kita dapat menciptakan perubahan untuk<br /> masa depan yang lebih cerah bagi berbagai pihak.</asp:Label>
        </div>
        <div class="DonatePage_RightContent">
            <div class="DonateForm_Container">
                <div class="Donate_Ammount1">
                    <asp:Button ID="Ammount_5000" runat="server" Text="IDR 5.000" CssClass="Ammount_5000" OnClick="Ammount_5000_Click" />
                    <asp:Button ID="Ammount_10000" runat="server" Text="IDR 10.000" CssClass="Ammount_10000" OnClick="Ammount_10000_Click"/>
                    <asp:Button ID="Ammount_20000" runat="server" Text="IDR 20.000" CssClass="Ammount_20000" OnClick="Ammount_20000_Click"/>
                </div>
                <div class="Donate_Ammount2">
                    <asp:Button ID="Ammount_50000" runat="server" Text="IDR 50.000" CssClass="Ammount_50000" OnClick="Ammount_50000_Click"/>
                    <asp:Button ID="Ammount_100000" runat="server" Text="IDR 100.000" CssClass="Ammount_100000" OnClick="Ammount_100000_Click1"/>
                </div>
                <div class="Donate_AmmountTxtBox">
                    <asp:TextBox ID="Donate_AmmountTxtBox" runat="server" Text="" placeholder="Masukin Nominal" CssClass="Donate_AmmountBox"></asp:TextBox>
                </div>

                <div class="Donate_Name">
                    <asp:Label ID="DonateName_Txt" runat="server" Text="Nama" CssClass="DonateName_Txt"></asp:Label>
                    <asp:TextBox ID="DonateName_TxtBox" runat="server" CssClass="DonateName_TxtBox" placeholder="Masukkan nama Anda.."></asp:TextBox>
                </div>
                <div class="Donate_Email">
                    <asp:Label ID="DonateEmail_Txt" runat="server" Text="Email" CssClass="DonateEmail_Txt"></asp:Label>
                    <asp:TextBox ID="DonateEmail_TxtBox" runat="server" CssClass="DonateEmail_TxtBox" placeholder="@gmail.com"></asp:TextBox>
                </div>
                <div class="Donate_Card">
                    <div class="Card_Details">
                        <asp:Label ID="Card_Details_Text" runat="server" Text="Card details" CssClass="Card_Details_Text"></asp:Label>
                        <asp:TextBox ID="Card_Details_TxtBox" runat="server" CssClass="Card_Details_TxtBox" placeholder="0000 0000 0000"></asp:TextBox>
                    </div>
                    <div class="Card_Expiry">
                        <asp:Label ID="Card_Expiry_Text" runat="server" Text="Expiry" CssClass="Card_Expiry_Text"></asp:Label>
                        <asp:TextBox ID="Card_Expiry_TxtBox" runat="server" CssClass="Card_Expiry_TxtBox" placeholder="00/00"></asp:TextBox>
                    </div>
                    <div class="Card_CVV">
                        <asp:Label ID="Card_CVV_Text" runat="server" Text="CVV" CssClass="Card_CVV_Text"></asp:Label>
                        <asp:TextBox ID="Card_CVV_TxtBox" runat="server" CssClass="Card_CVV_TxtBox" placeholder="000"></asp:TextBox>
                    </div>
                </div>
                <div class="DonateSubmit_Btn">
                    <asp:Button ID="Donate_Btn" runat="server" Text="Beri Donasi" CssClass="Donate_Btn" OnClick="Donate_Btn_Click" />
                </div>

            </div>
        </div>
        <img class="Background_Pic" src="../../Assets/Images/poor-child-landfill-looks-forward-with-hope (2).jpg" />
    </div>

</asp:Content>
