<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="ThankYouPage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.ThankYouPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../CSS/ThankYouPage_CSS.css" rel="stylesheet" />
    <div class="ThankYouPage_Container">
        <div class="ThankYouPage_Text">
            <img class="Checked_logo" src="../../Assets/Images/Checked_logo.png" />
            <asp:Label ID="ThankYou_Text1" runat="server" Text="Terima kasih atas Donasinya!" CssClass="ThankYou_Text1"></asp:Label>
            <asp:Label ID="ThankYou_Text2" runat="server" Text="Partisipasi Anda akan sangat berarti bagi orang lain." CssClass="ThankYou_Text2"></asp:Label>
            <img class="QuickEV_LOGO_ThankYou" src="../../Assets/Images/QuickEV-Logo-Black.png" />
            <div class="GoHome">
                <asp:Button ID="GoHome_Btn" runat="server" Text="Go Home" CssClass="GoHome_Btn" OnClick="GoHome_Btn_Click" />
            </div>
        </div>

    </div>

</asp:Content>
