<%@ Page Title="" Language="C#" MasterPageFile="~/MasterStranica.Master" AutoEventWireup="true" CodeBehind="Prijava.aspx.cs" Inherits="ProdajaNekretnina.KorisniciSistema.Prijava" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <section id="content">
    <div class="container_12">	
      <div class="grid_4">
        <div class="left-1">
            <h2 class="top-1 p3">Izvršite prijavu</h2>
            <div id="form-1" class="form-1 bot-1">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                <div>
                    <label>Email</label><br />
                    <asp:TextBox ID="tbKorisnicko" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Morate unijeti korisničko ime!" ControlToValidate="tbKorisnicko" Display="None"></asp:RequiredFieldValidator><br />
                    <label>Lozinka</label><br />
                    <asp:TextBox ID="tbLozinka" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Morate unijeti lozinku!" ControlToValidate="tbLozinka" Display="None" ></asp:RequiredFieldValidator>
                </div>
                <asp:Label ID="Label3" runat="server" Text="Ukoliko niste registrirani,uradite to " CssClass="labelLogin"></asp:Label>
                <a href="../Registracija.aspx" class="labelLogin">OVDJE</a>
                <asp:LinkButton ID="btnPrijava" runat="server" CssClass="button" OnClick="btnPrijava_Click">Prijava</asp:LinkButton>
                <div class="clear"></div>
            </div>
            <h2 class="p3">Find our office</h2>
            <img src="/images/page1-img4.png" alt=""/>
            <div class="lists">
                <ul class="list-1">
                    <li><a href="#">Asia</a></li>
                    <li><a href="#">Australia</a></li>
                    <li><a href="#">Africa</a></li>
                </ul>
                <ul class="list-1 last">
                    <li><a href="#">North America</a></li>
                    <li><a href="#">Europe</a></li>
                    <li><a href="#">Latin America</a></li>
                </ul>
            </div>
        </div>
      </div>
      <div class="clear"></div>
    </div>  
</section> 
</asp:Content>
