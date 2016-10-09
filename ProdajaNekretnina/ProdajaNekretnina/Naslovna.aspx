<%@ Page Title="" Language="C#" MasterPageFile="~/MasterStranica.Master" AutoEventWireup="true" CodeBehind="Naslovna.aspx.cs" Inherits="ProdajaNekretnina.Naslovna" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section id="content">
    <div class="container_12">	
      <div class="grid_8">
        <h2 class="top-1 p3">Welcome message!</h2>
        <p class="p2">Real Estate is one of <a href="http://blog.templatemonster.com/free-website-templates/" target="_blank" class="link">free website templates</a> created by TemplateMonster.com team. This website template is optimized for 1280X1024 screen resolution. It is also XHTML &amp; CSS valid.</p>
        <p class="line-1">Download the basic package of this <a class="link" href="http://blog.templatemonster.com/2012/04/09/free-website-template-real-estate-justslider/" target="_blank" rel="nofollow">Real Estate Template</a> (without PSD source) that is available for anyone without registration. If you need PSD source files, please go to the template download page at TemplateMonster to leave the e-mail address that you want the free template ZIP package to be delivered to.</p>
        <h3 class="p4">Najpojeceniji oglasi:</h3>
        <div >
             <div>
                        <asp:DataList runat="server" ID="dataTop3" RepeatDirection="Horizontal" Width="100%" RepeatColumns="3">
                            <ItemTemplate>
                                <div style="padding:3px 12px 3px 3px">
                                    <asp:Image ID="Image2" runat="server" ImageUrl='<%# String.Format("/imageHandler.ashx?id={0}",Eval("NekretninaID")) %>' Width="180" Height="120" CssClass="img-border" />
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
            <h2 class="top-1 p3">Find your home</h2>
            <div id="form-1" class="form-1 bot-1">
                <div class="select-1">
                    <label>Home type</label>
                    <select name="select" >
                        <option>Homes for sale</option>
                    </select>   
                </div>
                <div>
                    <label>Location</label>
                    <input type="text" value="Address, City, Zip" onBlur="if(this.value=='') this.value='Address, City, Zip'" onFocus="if(this.value =='Address, City, Zip' ) this.value=''"  />
                </div>
                <div class="select-2">
                    <label>Beds</label>
                    <select name="select" >
                        <option>&nbsp;</option>
                    </select>   
                </div>
                <div class="select-2 last">
                    <label>Baths</label>
                    <select name="select" >
                        <option>&nbsp;</option>
                    </select>   
                </div> 
                <a onClick="document.getElementById('form-1').submit()" class="button">Search</a>
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
