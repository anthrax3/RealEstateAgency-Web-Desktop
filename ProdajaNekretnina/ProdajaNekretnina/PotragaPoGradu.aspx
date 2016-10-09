<%@ Page Title="" Language="C#" MasterPageFile="~/MasterStranica.Master" AutoEventWireup="true" CodeBehind="PotragaPoGradu.aspx.cs" Inherits="ProdajaNekretnina.PotragaPoGradu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container_12">
        <div class="grid_8">

            <div id="form-1" class="form-1 bot-1">

                <h2>Oznacite kanton</h2>
                <div class="select-1">

                    <asp:DropDownList ID="ddlKantoni" runat="server" CssClass="jqTransformSelectWrapper" AutoPostBack="true" OnSelectedIndexChanged="ddlKantoni_SelectedIndexChanged"></asp:DropDownList>
                </div>

                <br />

                <h2>Oznacite grad iz kojeg želite da Vam dolazi mail sa dodanim nekretninama.<br />
                    Nakon toga kliknite na button &quot;Spremi&quot;</h2>
                <div class="select-2">

                    <asp:DropDownList ID="ddlGrad"  runat="server" AutoPostBack="true"></asp:DropDownList>

                </div>

                <asp:LinkButton ID="btnDodaj" runat="server" OnClick="btnDodaj_Click" CssClass="button">Spremi</asp:LinkButton>
                <div class="clear"></div>

            </div>

            <br /><br />


            <br />

        <div style="width: 700px;">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderColor="#cccccc" BorderStyle="solid" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="100%">
                <AlternatingRowStyle BackColor="#DCDCDC" />
                <Columns>
                    <asp:BoundField DataField="Naslov" HeaderText="Naslov" />
                    <asp:BoundField DataField="BrojKvadrata" HeaderText="BK" />
                    <asp:BoundField DataField="Adresa" HeaderText="Adresa" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#string.Format("DetaljiNekretnine.aspx?id={0}", Eval("NekretninaID")) %>'>Detalji</asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
                <FooterStyle BackColor="#939393" ForeColor="Black" />
                <HeaderStyle BackColor="#939393" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
            </asp:GridView>
        </div>

        


  </div>
    </div>
</asp:Content>
