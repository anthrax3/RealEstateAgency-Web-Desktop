<%@ Page Title="" Language="C#" MasterPageFile="~/MasterStranica.Master" AutoEventWireup="true" CodeBehind="Korpa.aspx.cs" Inherits="ProdajaNekretnina.Korpa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section id="content">
        <div class="container_12">

            <h3 class="top-1 p3" runat="server" id="naslovNekretnine">Finalizacija narudzbe</h3>

            <div id="divDetalji">
               <asp:GridView ID="narudzbeGrid" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="Nekretnine.Naslov" HeaderText="Nekretnine" />
                            <asp:BoundField DataField="Nekretnine.Cijena" HeaderText="Cijena" />
                            <asp:BoundField DataField="Kolicina" HeaderText="Količina" />
                        </Columns>
                    </asp:GridView>
                    <br /><br />
                <asp:LinkButton ID="btnZakljuci" runat="server" CssClass="button" OnClick="btnZakljuci_Click">Zakljuci narudzbu</asp:LinkButton>
            </div>
        </div>


        <div class="clear"></div>
    </section>
</asp:Content>
