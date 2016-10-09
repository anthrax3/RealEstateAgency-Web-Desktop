<%@ Page Title="" Language="C#" MasterPageFile="~/MasterStranica.Master" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="ProdajaNekretnina.Registracija" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <section id="content">
    <div class="container_12">	
      <div class="grid_4">
        <div class="left-1">
            <h2 class="top-1 p3">Izvršite registraciju:</h2>
            <div id="form-1" class="form-1 bot-1">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    <asp:TextBox ID="tbIme" placeholder="Ime:" runat="server" TabIndex="1"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbIme" Text="* Ime je obavezno"></asp:RequiredFieldValidator><br /><br />
				
					<asp:TextBox ID="tbPrezime" placeholder="Prezime:"  runat="server" TabIndex="2"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbPrezime" Text="* Prezime je obavezno" ></asp:RequiredFieldValidator><br /><br />

				    <asp:TextBox ID="tbEmail" placeholder="E-mail:"  runat="server" TextMode="Email" TabIndex="3"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbEmail" Text="* E-mail je obavezan" ></asp:RequiredFieldValidator><br /><br />

					<asp:TextBox ID="tbPassword" runat="server" placeholder="Lozinka:"  TextMode="Password" TabIndex="4"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbPassword" Text="* Lozinka je obavezna" ></asp:RequiredFieldValidator><br /><br />

					<asp:TextBox ID="tbRetypePassword" placeholder="Potvrda lozinke:"  runat="server" TextMode="Password" TabIndex="5"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbRetypePassword" Text="* Potvrda lozinke je obavezna" ></asp:RequiredFieldValidator><br /><br />
                       <asp:CompareValidator runat="server" ControlToCompare="tbPassword" ControlToValidate="tbRetypePassword" Text="* Lozinke se moraju poklapati!" />
				</div>	
				<div>
                <asp:LinkButton ID="btnRegistracija" runat="server" CssClass="button" OnClick="btnRegistracija_Click">Sačuvaj</asp:LinkButton>
                <div class="clear"></div>
            </div>
        </div>
      </div>
      <div class="clear"></div>
    </div>  
</section> 
</asp:Content>
