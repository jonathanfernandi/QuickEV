<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="ContactUsPage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.ContactUsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="../CSS/ContactUsPage_CSS.css" rel="stylesheet" />
    <div class="ContactUs_Content">
        <div class="ContactUs_LeftContent">
            <asp:Label ID="ContactUs_Header" runat="server" Text="Kami ingin mendengar pendapat Anda" CssClass="ContactUs_Header"></asp:Label>
            <asp:Label ID="ContactUs_Header2" runat="server" Text="Diskusi lebih lanjut bersama kami." CssClass="ContactUs_Header2"></asp:Label>
            <div class="TextBox_Container">
                <div class="NamaLengkap_Container">
                    <asp:Label ID="NamaLengkap_Text" runat="server" Text="Nama Lengkap" CssClass="NamaLengkap_Text"></asp:Label>
                    <asp:TextBox ID="NamaLengkap_TxtBox" runat="server" Text="" placeholder="Nama Anda" CssClass="NamaLengkap_TxtBox"></asp:TextBox>
                </div>
                <div class="Email_Container">
                    <asp:Label ID="Email_Text" runat="server" Text="Email" CssClass="Email_Text"></asp:Label>
                    <asp:TextBox ID="Email_TxtBox" runat="server" Text="" placeholder="@gmail.com" CssClass="Email_TxtBox"></asp:TextBox>
                </div>
                <div class="PesanAnda_Container">
                    <asp:Label ID="PesanAnda_Text" runat="server" Text="Pesan Anda" CssClass="PesanAnda_Text"></asp:Label>
                    <asp:TextBox ID="PesanAnda_TxtBox" runat="server" Text="" TextMode="MultiLine" placeholder="Tinggalkan pesan Anda disini..." CssClass="PesanAnda_TxtBox"></asp:TextBox>
                    <%--<textarea class="PesanAnda_TxtBox" placeholder="Tinggalkan pesan Anda disini..." rows="20" cols="50"> </textarea>--%>
                </div>
            </div>
            <div class="Submit_Btn">
                <asp:Button ID="KirimPesan_Btn" runat="server" Text="Kirim Pesan" CssClass="KirimPesan_Btn" OnClick="KirimPesan_Btn_Click" />
            </div>
        </div>
        <div class="ContactUs_RightContent">
            <img class="ContactUs_Pic" src="../../Assets/Images/ContactUs_KirimPesanPic.png" />
        </div>
    </div>
</asp:Content>
