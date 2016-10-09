using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SistemNekretnine.DB;

namespace ProdajaNekretnina
{
    public partial class DetaljiNekretnine : System.Web.UI.Page
    {
        public Nekretnine tempNekretnina { get; set; }

        public Narudzbe narudzba
        {
            get { return (Narudzbe)Session["narudzbaId"]; }
            set { Session["narudzbaId"] = value; }
        }

        public int nekretninaID
        {
            get { return (int)ViewState["nekretninaID"]; }
            set { ViewState["nekretninaID"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Request["id"]!=null)
                {
                    tempNekretnina = DANekretnine.getByID(Convert.ToInt32(Request["id"]));

                    nekretninaID = Convert.ToInt32(Request["id"]);

                    if(tempNekretnina!=null)
                    {
                        BindForm();

                        int brojPosjeta =(int)tempNekretnina.BrojPosjeta+1;
                        DANekretnine.updateBrojPosjeta(brojPosjeta, nekretninaID);
                    }
                }
            }
        }

        private void BindForm()
        {
            List<SlikeNekretnina> tempSlike = DANekretnine.getSlike(tempNekretnina.NekretninaID);

            listaSlika.DataSource = tempSlike;
            listaSlika.DataBind();
            if (tempSlike.Count==0)
            {
                link.HRef = String.Format("/imageHandler.ashx?id={0}", tempNekretnina.NekretninaID);
                slika.Src = String.Format("/imageHandler.ashx?id={0}", tempNekretnina.NekretninaID);
            }
            BindDropListe();

            naslovNekretnine.InnerText = tempNekretnina.Naslov;

            cbAdaptiran.Checked = (bool)tempNekretnina.NedavnoAdaptiran;
            cbGaraza.Checked = (bool)tempNekretnina.Garaža;
            cbInternet.Checked = (bool)tempNekretnina.Internet;
            cbKanalizacija.Checked = (bool)tempNekretnina.Knalizacija;
            cbLift.Checked = (bool)tempNekretnina.Lift;
            cbNamjesten.Checked = (bool)tempNekretnina.Namješten;
            cbNovogradnja.Checked = (bool)tempNekretnina.Novogradnja;
            cbParking.Checked = (bool)tempNekretnina.Parking;
            cbStruja.Checked = (bool)tempNekretnina.Struja;
            cbTelefon.Checked = (bool)tempNekretnina.Telefon;
            cbUknjizeno.Checked = (bool)tempNekretnina.Uknjiženo;
            cbVoda.Checked = (bool)tempNekretnina.Voda;

            tbKvadrati.Text = tempNekretnina.BrojKvadrata.ToString();
            tbCijena.Text = tempNekretnina.Cijena.ToString() + " KM";
            tbAdresa.Text = tempNekretnina.Adresa;

            ddlVrste.SelectedValue = tempNekretnina.VrstaID.ToString();
            ddlStanje.SelectedValue = tempNekretnina.StanjeID.ToString();
            ddlSprat.SelectedValue = tempNekretnina.SpratID.ToString();
            ddlSobe.SelectedValue = tempNekretnina.SobeID.ToString();
            ddlKategorije.SelectedValue = tempNekretnina.KategorijaID.ToString();
            ddlKantoni.SelectedValue = tempNekretnina.KantonID.ToString();
            ddlGrijanje.SelectedValue = tempNekretnina.GrijanjeID.ToString();

        }

        private void BindDropListe()
        {
            ddlKategorije.DataSource = DANekretnine.getkategorije();
            ddlKategorije.DataTextField = "NazivKategorije";
            ddlKategorije.DataValueField = "KategorijaID";
            ddlKategorije.DataBind();

            ddlStanje.DataSource = DANekretnine.getSatanja();
            ddlStanje.DataTextField = "NazivStanja";
            ddlStanje.DataValueField = "StanjeID";
            ddlStanje.DataBind();

            ddlKantoni.DataSource = DANekretnine.getKantone();
            ddlKantoni.DataTextField = "Naziv";
            ddlKantoni.DataValueField = "KantonID";
            ddlKantoni.DataBind();

            ddlGrad.DataSource = DANekretnine.getGradove((int)tempNekretnina.KantonID);
            ddlGrad.DataTextField = "NazivGarda";
            ddlGrad.DataValueField = "GradID";
            ddlGrad.DataBind();

            ddlGrijanje.DataSource = DANekretnine.getGrijanje();
            ddlGrijanje.DataTextField = "NazivGrijanja";
            ddlGrijanje.DataValueField = "GrijanjeID";
            ddlGrijanje.DataBind();

            ddlSobe.DataSource = DANekretnine.getSobe();
            ddlSobe.DataTextField = "BrojSoba";
            ddlSobe.DataValueField = "SobaID";
            ddlSobe.DataBind();

            ddlSprat.DataSource = DANekretnine.getSpratovi();
            ddlSprat.DataTextField = "NazivSprata";
            ddlSprat.DataValueField = "SpratID";
            ddlSprat.DataBind();

            ddlVrste.DataSource = DANekretnine.getVrste();
            ddlVrste.DataTextField = "NazivVrste";
            ddlVrste.DataValueField = "VrstaID";
            ddlVrste.DataBind();

            GridView1.DataSource = DANekretnine.GetPitanjaByNekretninaID(Convert.ToInt32(Request["id"]));
            GridView1.DataBind();
        }

        protected void btnKorpa_Click(object sender, EventArgs e)
        {
            if (Page.User.Identity.IsAuthenticated)
            {

                if (narudzba == null)
                {
                    narudzba = new Narudzbe();
                    narudzba.Datum = DateTime.Now;
                    narudzba.KupacID = Convert.ToInt32(Page.User.Identity.Name);
                    Random rnd = new Random();
                    int prvi = rnd.Next(1, 445);
                    narudzba.BrojNarudzbe = Convert.ToString(prvi);
                    narudzba.Status = true;
                    narudzba.Otkazano = false;
                }

                foreach (NarudzbaStavke s in narudzba.NarudzbaStavke)
                {
                    if (s.NekretninaID == nekretninaID)
                    {
                        s.Kolicina += 1;
                        return;
                    }
                }

                NarudzbaStavke narudzbaStavke = new NarudzbaStavke();
                narudzbaStavke.NekretninaID = nekretninaID;
                narudzbaStavke.Nekretnine = DANekretnine.SelectById(nekretninaID);
                narudzbaStavke.Kolicina = 1;

                narudzba.NarudzbaStavke.Add(narudzbaStavke);

                if (narudzba != null)
                    ((HyperLink)(this.Master.FindControl("linkKorpa"))).Text = string.Format("{0}", "Korpa (" + narudzba.NarudzbaStavke.Count + ")");
            }

            else
            {
                Response.Redirect("/KorisniciSistema/Prijava.aspx");
            }

        }

        protected void btnOcjenjivanje_Click(object sender, EventArgs e)
        {
            Response.Redirect("/KorisniciSistema/Ocjenjivanje.aspx?id=" + nekretninaID);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                Label3.Text = "Niste unjeli pitanje!!";
                return;
            }
            DANekretnine.InsertPitanje(Convert.ToInt32(Request["id"]), TextBox1.Text);
            GridView1.DataSource = DANekretnine.GetPitanjaByNekretninaID(Convert.ToInt32(Request["id"]));
            GridView1.DataBind();
            TextBox1.Text = "";
            Label3.Text = "";
        }
    }
}