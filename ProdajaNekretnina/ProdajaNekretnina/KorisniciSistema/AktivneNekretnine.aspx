<%@ Page Title="" Language="C#" MasterPageFile="~/MasterStranica.Master" AutoEventWireup="true" CodeBehind="AktivneNekretnine.aspx.cs" Inherits="ProdajaNekretnina.KorisniciSistema.AktivneNekretnine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="content">
        <div class="container_12">
            <div class="grid_8">
                <h3 class="top-1 p3">Objavljene nekretnine</h3>
                <div >
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="NazivVrste" HeaderText="Vrsta oglasa" />
                            <asp:BoundField DataField="naslov" HeaderText="Naslov" />
                            <asp:BoundField DataField="Naziv" HeaderText="Kanton" />
                            <asp:BoundField DataField="NazivGarda" HeaderText="Grad" />
                            <asp:BoundField DataField="GodinaIzgradnje" HeaderText="Godina izgradnje" />
                            <asp:BoundField DataField="GodinaIzgradnje" HeaderText="Godina izgradnje" />
                            <asp:BoundField DataField="BrojKvadrata" HeaderText="Broj kvadrata" />
                            <asp:BoundField DataField="Cijena" HeaderText="Cijena" />
                            <asp:BoundField DataField="DatumObjave" HeaderText="Datum objave" />
                        </Columns>
                    </asp:GridView>
                </div>
                </div>
                 <div class="grid_8">
                <h3 class="top-1 p3">Pitanja:</h3>
                <div >
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" >
                        <Columns>
                            <asp:BoundField DataField="Pitanje" HeaderText="Pitanje:" />
                            <asp:TemplateField HeaderText="">
                                <ItemTemplate>

                                    
                                    <asp:LinkButton ID="LinkButton1" OnCommand="LinkButton1_Command" CommandArgument='<%#Eval("PitanjeID") %>' runat="server">Odgovori</asp:LinkButton>
                                </ItemTemplate>

                            </asp:TemplateField>
                          

                        </Columns>

                      
                      
                    </asp:GridView>
                </div>

            </div>
             <div class="grid_4">
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Height="65px" Width="274px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Morate unjeti text odgovora" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                 <asp:Button ID="Button1" runat="server" Text="Spremi odgovor" OnClick="Button1_Click" Height="26px" Width="119px" />
            </asp:Panel>
                 
                 </div>
            <div class="clear"></div>
            </div>
        </section>
</asp:Content>
