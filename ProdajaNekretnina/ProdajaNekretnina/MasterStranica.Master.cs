using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SistemNekretnine.DB;

namespace ProdajaNekretnina
{
    public partial class MasterStranica : System.Web.UI.MasterPage
    {
        public Narudzbe narudzba
        {
            get { return (Narudzbe)Session["narudzbaId"]; }
            set { Session["narudzbaId"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (narudzba != null)
                {
                    linkKorpa.Text = "Korpa (" + narudzba.NarudzbaStavke.Count + ")";
                }
                if (Session["kupac"] != null)
                {
                    fooItem.Visible = true;
                }
                else
                    fooItem.Visible = false;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("/KorisniciSistema/Prijava.aspx");
        }

        protected void btnRegistracija_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Registracija.aspx");

        }

        protected void btnKorisnicki_Click(object sender, EventArgs e)
        {
            Response.Redirect("/KorisniciSistema/KorisnickiProfil.aspx");
        }
    }
}