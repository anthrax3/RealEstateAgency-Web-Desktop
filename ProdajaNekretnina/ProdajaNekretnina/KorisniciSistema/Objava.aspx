<%@ Page Title="" Language="C#" MasterPageFile="~/MasterStranica.Master" AutoEventWireup="true" CodeBehind="Objava.aspx.cs" Inherits="ProdajaNekretnina.KorisniciSistema.Objava" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section id="content">
        <div class="container_12">
            <h3 class="top-1 p3" runat="server" id="naslovNekretnine">Unesite podatke nekretnine</h3>
            <div id="divDetalji">
                <div class="form-1 bot-1" style="float: left">
                    <div class="select-1">
                        <label>Naslov</label>
                        <asp:TextBox ID="tbNaslov" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbNaslov" Text="* Naslov je obavezan" ></asp:RequiredFieldValidator>
                 </div>
                     <asp:ScriptManager ID="ScriptManager1" runat="server" LoadScriptsBeforeUI="true"
            EnablePartialRendering="true">
    </asp:ScriptManager> 
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" RenderMode="Inline">
<ContentTemplate>

                    <div class="select-2">
                        <label>Kanton</label>
                        <asp:DropDownList ID="ddlKantoni" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlKantoni_SelectedIndexChanged"></asp:DropDownList>
                        <asp:RequiredFieldValidator InitialValue="0" ID="Req_ID"  runat="server" ControlToValidate="ddlKantoni"
                                 ErrorMessage="Morate odabrati kanton!"></asp:RequiredFieldValidator><br />
                    </div>
                    <div class="select-2 last">
                        <label runat="server" id="labelGrad">Grad</label>
                        <asp:DropDownList ID="ddlGrad" runat="server" AutoPostBack="false"></asp:DropDownList>
                         <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator5"  runat="server" ControlToValidate="ddlGrad"
                                 ErrorMessage="Morate odabrati grad!"></asp:RequiredFieldValidator><br />
                    </div>
    </ContentTemplate>
                        </asp:UpdatePanel>
                    <div class="select-1">
                        <label>Sobe</label>
                        <asp:DropDownList ID="ddlSobe" runat="server" AutoPostBack="false"></asp:DropDownList>
                        <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator6"  runat="server" ControlToValidate="ddlSobe"
                                 ErrorMessage="Morate odabrati sobe!"></asp:RequiredFieldValidator><br />
                    </div>
                    <div class="select-1">
                        <label runat="server" id="label1">Sprat</label>
                        <asp:DropDownList ID="ddlSprat" runat="server" AutoPostBack="false"></asp:DropDownList>
                        <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator7"  runat="server" ControlToValidate="ddlSprat"
                                 ErrorMessage="Morate odabrati sprat!"></asp:RequiredFieldValidator><br />
                    </div>
                    <div class="select-1">
                        <label runat="server" id="label2">Grijanje</label>
                        <asp:DropDownList ID="ddlGrijanje" runat="server" AutoPostBack="false"></asp:DropDownList>
                        <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator8"  runat="server" ControlToValidate="ddlGrijanje"
                                 ErrorMessage="Morate odabrati grijanje!"></asp:RequiredFieldValidator><br />
                    </div>

                </div>
            </div>
            <div class="divDetalji1">

                <asp:CheckBox ID="cbVoda" runat="server" Text="  Voda" /><br />
                <asp:CheckBox ID="cbStruja" runat="server" Text="  Struja"  /><br />
                <asp:CheckBox ID="cbKanalizacija" runat="server" Text="  Kanalizacija"  /><br />
                <asp:CheckBox ID="cbTelefon" runat="server" Text="  Telefon"  /><br />
                <asp:CheckBox ID="cbInternet" runat="server" Text="  Internet" /><br />
                <asp:CheckBox ID="cbUknjizeno" runat="server" Text="  Uknjiženo"  /><br />
                <asp:CheckBox ID="cbNovogradnja" runat="server" Text="  Novogradnja"  /><br />
                <asp:CheckBox ID="cbAdaptiran" runat="server" Text="  Nedavno adaptiran"  /><br />
                <asp:CheckBox ID="cbNamjesten" runat="server" Text="  Namješten"  /><br />
                <asp:CheckBox ID="cbParking" runat="server" Text="  Parking" /><br />
                <asp:CheckBox ID="cbGaraza" runat="server" Text="  Garaža"  /><br />
                <asp:CheckBox ID="cbLift" runat="server" Text="  Lift"  /><br />
                

                <div id="right">
                    <br /><br />
                    <h2>Odaberite slike nekretnine:</h2>
                    <asp:FileUpload ID="FileUpload1" runat="server" /><br /><br />
                    <asp:FileUpload ID="FileUpload2" runat="server" /><br /><br />
                    <asp:FileUpload ID="FileUpload3" runat="server" /><br /><br />
                    <asp:FileUpload ID="FileUpload4" runat="server" /><br /><br />
                </div>

            </div>

            <div id="lijeviDIV">
                <div id="form-1" class="form-1 bot-1">
                    <div class="select-1">
                        <label>Vrsta oglasa</label>
                        <asp:DropDownList ID="ddlVrste" runat="server" AutoPostBack="false" ></asp:DropDownList>
                          <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator9"  runat="server" ControlToValidate="ddlVrste"
                                 ErrorMessage="Morate odabrati vrstu oglasa!"></asp:RequiredFieldValidator><br />
                    </div>
                    <div class="select-1">
                        <label>Tip doma</label>
                        <asp:DropDownList ID="ddlKategorije" runat="server" AutoPostBack="false" ></asp:DropDownList>
                        <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator10"  runat="server" ControlToValidate="ddlKategorije"
                                 ErrorMessage="Morate odabrati tip nekretnine!"></asp:RequiredFieldValidator><br />
                    </div>
                    <div class="select-1">
                        <label>Stanje</label>
                        <asp:DropDownList ID="ddlStanje" runat="server" AutoPostBack="false" ></asp:DropDownList>
                        <asp:RequiredFieldValidator InitialValue="0" ID="RequiredFieldValidator11"  runat="server" ControlToValidate="ddlStanje"
                                 ErrorMessage="Morate odabrati stanje!"></asp:RequiredFieldValidator><br />
                    </div>
                    <div class="select-1">
                        <label>Broj kvadrata</label>
                        <asp:TextBox ID="tbKvadrati" runat="server" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbKvadrati" Text="* Broj kvadrata je obavezan" ></asp:RequiredFieldValidator>
                    </div>
                    <div class="select-1">
                        <label>Godina izgradnje</label>
                        <asp:TextBox ID="tbGodina" runat="server" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="tbGodina" Text="* Morate odabrati godinu izgradnje" ></asp:RequiredFieldValidator>                        
                    </div>
                    <div class="select-1">
                        <label>Adresa</label>
                        <asp:TextBox ID="tbAdresa" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbAdresa" Text="* Adresa je obavezna" ></asp:RequiredFieldValidator>                        
                    </div>
                    <div class="select-1">
                        <label>Cijena</label>
                        <asp:TextBox ID="tbCijena" runat="server" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbCijena" Text="* Cijena je obavezna" ></asp:RequiredFieldValidator>                        
                    </div>
                <br />
                <asp:LinkButton ID="btnSacuvaj" runat="server" CssClass="button" OnClick="btnSacuvaj_Click">Sacuvaj</asp:LinkButton>
                </div>
            </div>
        </div>


        <div class="clear"></div>
    </section>
</asp:Content>
