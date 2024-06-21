<%@ Page Title="" Language="C#" MasterPageFile="~/Views/ASPX/sitemasternavbar.Master" AutoEventWireup="true" CodeBehind="SemuaRelawanKomunitasPage.aspx.cs" Inherits="QuickEV_Website.Views.ASPX.SemuaRelawanKomunitasPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../CSS/SemuaRelawanKomunitasPage_CSS.css" rel="stylesheet" />

    <div class="page">

        <div class="bigHeader">
            <asp:Label ID="bigHeaderLbl" runat="server" Text="Semua Relawan di Dalam Komunitasmu" CssClass="bigHeaderLbl" Visible="true"></asp:Label>
        </div>

        <div class="repeater">
            <asp:Repeater ID="volunteeringRpt" runat="server">
                <ItemTemplate>
                    <div class="box">
                        <div class="box-name">
                            <asp:Label ID="nameLbl" runat="server" Text='<%# Eval("NamaRelawan").ToString().ToUpper() %>' CssClass="nameLbl"></asp:Label>
                        </div>
                        <div class="box-image">
                            <div class="box-inside">
                                <img src="../../Assets/Images/email.png" alt="" />
                                <asp:Label ID="emailLbl" runat="server" Text='<%# Eval("Email") %>' CssClass="lbl"></asp:Label>
                            </div>
                            <div class="box-inside">
                                <img src="../../Assets/Images/kegiatan_loc_logo.png" />
                                <asp:Label ID="domisiliLbl" runat="server" Text='<%# Eval("Domisili") %>' CssClass="lbl"></asp:Label>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>
    </div>

</asp:Content>
