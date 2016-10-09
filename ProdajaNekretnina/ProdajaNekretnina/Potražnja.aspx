<%@ Page Title="" Language="C#" MasterPageFile="~/MasterStranica.Master" AutoEventWireup="true" CodeBehind="Potražnja.aspx.cs" Inherits="ProdajaNekretnina.Potražnja" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="content">
        <div class="container_12">
            <div class="grid_8">
                <h3 class="top-1 p3">Zadnje dodani oglasi</h3>
                <div >
                    <div>
                        <asp:DataList runat="server" ID="zadnjeDodani" RepeatDirection="Horizontal" Width="100%">
                            <ItemTemplate>
                                <div style="padding:3px 12px 3px 3px">
                                    <asp:Image ID="Image2" runat="server" ImageUrl='<%# String.Format("/imageHandler.ashx?id={0}",Eval("NekretninaID")) %>' Width="200" Height="186" CssClass="img-border" />
                                    <h3><%# Eval("Naslov") %></h3>
                                    <p>Broj kvadrata: <%# Eval("BrojKvadrata") %></p>
                                    <p>Adresa: <%# Eval("Adresa") %></p>
                                    <h4>Cijena: <%# Eval("Cijena") %></h4>
                                    <a href='<%# String.Format("/DetaljiNekretnine.aspx?id={0}",Eval("NekretninaID")) %>' class="button">Detalji</a>
                                </div>
                            </ItemTemplate>
                        </asp:DataList>
                    </div>
                </div>
            </div>
           
            <div class="grid_4">
                <div class="left-1">
                    <h2 class="top-1 p3">Pronadjite vas dom</h2>
                    <div id="form-1" class="form-1 bot-1">
                        <div class="select-1">
                            <label>Tip doma</label>
                            <asp:DropDownList ID="ddlKategorije" runat="server" AutoPostBack="false"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlKategorije" ErrorMessage="Odaberite tip doma"></asp:RequiredFieldValidator>
                        </div>
                        <div class="select-1">
                            <label>Stanje</label>
                            <asp:DropDownList ID="ddlStanje" runat="server" AutoPostBack="false"></asp:DropDownList>
                        </div>
                         <div class="select-2">
                            <label>Kanton</label>
                            <asp:DropDownList ID="ddlKantoni" runat="server" AutoPostBack="false" ></asp:DropDownList>
                        </div>
                        <%-- <div class="select-2 last">
                            <label runat="server" id="labelGrad">Grad</label>
                            <asp:DropDownList ID="ddlGrad" runat="server" AutoPostBack="false"></asp:DropDownList>
                        </div>--%>
                        <div class="select-2">
                            <label>Cijena OD</label>
                            <asp:TextBox ID="tbCijena" runat="server"  TextMode="Number" Text="min"></asp:TextBox>
                        </div>
                        <div class="select-2 last">
                            <label>Cijena DO</label>
                            <asp:TextBox ID="tbCiejnaDO" runat="server" TextMode="Number" Text="max"></asp:TextBox>
                        </div>
                        
                        <asp:LinkButton ID="btnTrazi" runat="server" CssClass="button" OnClick="btnTrazi_Click">Trazi</asp:LinkButton>
                        <div class="clear"></div>
                    </div>
                    <h2 class="p3">Find our office</h2>
                    <img src="/images/page1-img4.png" alt="" />
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
