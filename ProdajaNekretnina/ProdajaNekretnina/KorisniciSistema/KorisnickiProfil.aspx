<%@ Page Title="" Language="C#" MasterPageFile="~/MasterStranica.Master" AutoEventWireup="true" CodeBehind="KorisnickiProfil.aspx.cs" Inherits="ProdajaNekretnina.KorisnickiProfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="content">
        <div class="container_12">
            <div class="grid_8">
                <h3 class="top-1 p3">Meni</h3>
                <div class="wrap block-1">
                   
                       <div class="divArtikli">
                           <asp:LinkButton ID="btnNekretnine" runat="server" OnClick="btnNekretnine_Click" ValidationGroup="x">Objavljeni artikli</asp:LinkButton>
                       </div>

                </div>
            </div>
            <div class="grid_4">
                <div class="left-1">
                    <h3 class="top-1 p3">Korisnicki podaci</h3>
                    <div id="form-1" class="form-1 bot-1">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                        <asp:TextBox ID="tbIme" placeholder="Ime:" runat="server" TabIndex="1" ReadOnly="true"></asp:TextBox>

                        <asp:TextBox ID="tbPrezime" placeholder="Prezime:" runat="server" TabIndex="2" ReadOnly="true"></asp:TextBox>

                        <hr />
                        <br />
                        <asp:TextBox ID="tbEmail" placeholder="E-mail:" runat="server" TextMode="Email" TabIndex="3" ValidationGroup="profil"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbEmail" Text="* E-mail je obavezan" ValidationGroup="profil"></asp:RequiredFieldValidator>

                        <asp:TextBox ID="tbPassword" runat="server" placeholder="Lozinka:" TextMode="Password" TabIndex="4" ValidationGroup="profil"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbPassword" Text="* Lozinka je obavezna" ValidationGroup="profil"></asp:RequiredFieldValidator>

                        <asp:TextBox ID="tbRetypePassword" placeholder="Potvrda lozinke:" runat="server" TextMode="Password" TabIndex="5" ValidationGroup="profil"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbRetypePassword" Text="* Potvrda lozinke je obavezna" ValidationGroup="profil"></asp:RequiredFieldValidator>
                        <asp:CompareValidator runat="server" ControlToCompare="tbPassword" ControlToValidate="tbRetypePassword" Text="* Lozinke se moraju poklapati!"  ValidationGroup="profil"/>
                    </div>
                    <div>
                        <asp:LinkButton ID="btnSacuvaj" runat="server" CssClass="button" OnClick="btnSacuvaj_Click" ValidationGroup="profil">Sačuvaj</asp:LinkButton>
                        <div class="clear"></div>
                    </div>
                </div>
            </div>
            <div class="clear"></div>
        </div>
    </section>
</asp:Content>
