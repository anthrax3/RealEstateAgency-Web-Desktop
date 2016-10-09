<%@ Page Title="" Language="C#" MasterPageFile="~/MasterStranica.Master" AutoEventWireup="true" CodeBehind="DetaljiNekretnine.aspx.cs" Inherits="ProdajaNekretnina.DetaljiNekretnine" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="content">
        <div class="container_12">

            <h3 class="top-1 p3" runat="server" id="naslovNekretnine">Naziv</h3>


            <div id="divDetalji">
                <div class="form-1 bot-1" style="float: left">
                    <div class="select-2">
                        <label>Kanton</label>
                        <asp:DropDownList ID="ddlKantoni" runat="server" AutoPostBack="true" Enabled="false"></asp:DropDownList>
                    </div>
                    <div class="select-2 last">
                        <label runat="server" id="labelGrad">Grad</label>
                        <asp:DropDownList ID="ddlGrad" runat="server" AutoPostBack="true" Enabled="false"></asp:DropDownList>
                    </div>
                    <div class="select-1">
                        <label>Sobe</label>
                        <asp:DropDownList ID="ddlSobe" runat="server" AutoPostBack="true" Enabled="false"></asp:DropDownList>
                    </div>
                    <div class="select-1">
                        <label runat="server" id="label1">Sprat</label>
                        <asp:DropDownList ID="ddlSprat" runat="server" AutoPostBack="true" Enabled="false"></asp:DropDownList>
                    </div>
                    <div class="select-1">
                        <label runat="server" id="label2">Grijanje</label>
                        <asp:DropDownList ID="ddlGrijanje" runat="server" AutoPostBack="true" Enabled="false"></asp:DropDownList>
                    </div>

                </div>
            </div>
            <div class="divDetalji1">


                <asp:CheckBox ID="cbVoda" runat="server" Text="  Voda" Enabled="false" /><br />
                <asp:CheckBox ID="cbStruja" runat="server" Text="  Struja" Enabled="false" /><br />
                <asp:CheckBox ID="cbKanalizacija" runat="server" Text="  Kanalizacija"  Enabled="false"/><br />
                <asp:CheckBox ID="cbTelefon" runat="server" Text="  Telefon" Enabled="false" /><br />
                <asp:CheckBox ID="cbInternet" runat="server" Text="  Internet" Enabled="false" /><br />
                <asp:CheckBox ID="cbUknjizeno" runat="server" Text="  Uknjiženo" Enabled="false" /><br />
                <asp:CheckBox ID="cbNovogradnja" runat="server" Text="  Novogradnja" Enabled="false" /><br />
                <asp:CheckBox ID="cbAdaptiran" runat="server" Text="  Nedavno adaptiran" Enabled="false" /><br />
                <asp:CheckBox ID="cbNamjesten" runat="server" Text="  Namješten" Enabled="false" /><br />
                <asp:CheckBox ID="cbParking" runat="server" Text="  Parking" Enabled="false" /><br />
                <asp:CheckBox ID="cbGaraza" runat="server" Text="  Garaža" Enabled="false" /><br />
                <asp:CheckBox ID="cbLift" runat="server" Text="  Lift"  Enabled="false"/><br />

                <br />
                <asp:LinkButton ID="btnKorpa" runat="server" CssClass="button" OnClick="btnKorpa_Click">Dodaj u korpu</asp:LinkButton>
                <asp:LinkButton ID="btnOcjenjivanje" runat="server" CssClass="button" OnClick="btnOcjenjivanje_Click">Ocjeni</asp:LinkButton>
                

                <div id="right">
                   <div><a id="link" runat ="server" rel="prettyPhoto[gallery]">
                                    <!---<img id="slika" runat="server" src='<%# String.Format("/slikeNekretnina.ashx?id={0}",Eval("SlikaID")) %>' alt="" width="150" height="121" />--></a></div>
                    <asp:DataList runat="server" ID="listaSlika" RepeatDirection="Horizontal" RepeatColumns="2" >
                        <ItemTemplate>
                            <ul class="thumbnails">
                                <li><a href='<%# String.Format("/slikeNekretnina.ashx?id={0}",Eval("SlikaID")) %>' rel="prettyPhoto[gallery]">
                                    <img src='<%# String.Format("/slikeNekretnina.ashx?id={0}",Eval("SlikaID")) %>' alt="" width="150" height="121" /></a></li>
                            </ul>
                        </ItemTemplate>
              
                              </asp:DataList>
                    <div >
                        <label>Postavi javno pitanje:</label>
                        <hr />
                        <asp:TextBox ID="TextBox1" runat="server" Height="108px"  TextMode="MultiLine" Width="335px"></asp:TextBox>
                        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                           </div>
                    <hr />
                    <div>
                       <asp:LinkButton ID="LinkButton1" runat="server" CssClass="button" OnClick="LinkButton1_Click" CausesValidation="False" >Postavi</asp:LinkButton>
                    </div>
                    <div>
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="Pitanje" HeaderText="Pitanja" />
                                <asp:BoundField DataField="Odgovor" HeaderText="Odgovori" />
                            </Columns>
                        </asp:GridView>

                    </div>
                    <div class="navigation"><a href="#" class="prev">Previous</a> <a href="#" class="next">Next</a> </div>
                </div>

            </div>

            <div id="lijeviDIV">
                <div id="form-1" class="form-1 bot-1">
                    <div class="select-1">
                        <label>Vrsta oglasa</label>
                        <asp:DropDownList ID="ddlVrste" runat="server" AutoPostBack="true" Enabled="false"></asp:DropDownList>
                    </div>
                    <div class="select-1">
                        <label>Tip doma</label>
                        <asp:DropDownList ID="ddlKategorije" runat="server" AutoPostBack="true" Enabled="false"></asp:DropDownList>
                    </div>
                    <div class="select-1">
                        <label>Stanje</label>
                        <asp:DropDownList ID="ddlStanje" runat="server" AutoPostBack="true" Enabled="false"></asp:DropDownList>
                    </div>
                    <div class="select-1">
                        <label>Broj kvadrata</label>
                        <asp:TextBox ID="tbKvadrati" runat="server" ReadOnly="true"></asp:TextBox>
                    </div>
                    <div class="select-1">
                        <label>Adresa</label>
                        <asp:TextBox ID="tbAdresa" runat="server" ReadOnly="true"></asp:TextBox>
                    </div>
                    <div class="select-1">
                        <label>Cijena</label>
                        <asp:TextBox ID="tbCijena" runat="server" ReadOnly="true"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>


        <div class="clear"></div>
    </section>
    <%--<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.2/jquery.min.js"></script>
    <script type="text/javascript" src="http://cloud.github.com/downloads/malsup/cycle/jquery.cycle.all.latest.js"></script>--%>
    <script type="text/javascript" src="/js/galerija/jquery.prettyPhoto.js"></script>
    <script type="text/javascript" src="/js/galerija/main.js"></script>
</asp:Content>
