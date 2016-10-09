<%@ Page Title="" Language="C#" MasterPageFile="~/MasterStranica.Master" AutoEventWireup="true" CodeBehind="Ocjenjivanje.aspx.cs" Inherits="ProdajaNekretnina.Ocjenjivanje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="content">
        <div class="container_12">
            <div class="grid_8">
                  <h3 class="top-1 p3" runat="server" id="naslovNekretnine">Odaberite ocjenu</h3>
                <div class="wrap block-1">
                    <div>
                    <asp:RadioButtonList ID="rblOcijeni" runat="server" RepeatLayout="Table">
                        <asp:ListItem Text="Ocjena 1"></asp:ListItem>
                        <asp:ListItem Text="Ocjena 2"></asp:ListItem>
                        <asp:ListItem Text="Ocjena 3"></asp:ListItem>
                        <asp:ListItem Text="Ocjena 4"></asp:ListItem>
                        <asp:ListItem Text="Ocjena 5"></asp:ListItem>
                    </asp:RadioButtonList>

                    <asp:LinkButton ID="btnSacuvaj" runat="server" CssClass="button" OnClick="btnSacuvaj_Click">Sačuvaj</asp:LinkButton>
                 </div>
            </div>
          </div>

            <div class="grid_4">
                  <h3 class="top-1 p3" runat="server" id="H1">Preporucene usluge</h3>
                <div class="left-1">
                    <asp:GridView ID="gridOcjene" runat="server" AutoGenerateColumns="false" GridLines="None" Width="300px">
                        <Columns>
                            <asp:BoundField HeaderText="Naziv nekretnine" DataField="Naslov" />
                            <asp:BoundField HeaderText="Cijena" DataField="Cijena" />
                        </Columns>
                     </asp:GridView>
                </div>
            </div>
        </div>
        <div class="clear"></div>
    </section>
</asp:Content>
