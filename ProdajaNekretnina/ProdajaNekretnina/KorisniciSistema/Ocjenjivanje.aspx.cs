using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SistemNekretnine.DB;
using SistemNekretnine;

namespace ProdajaNekretnina
{
    public partial class Ocjenjivanje : System.Web.UI.Page
    {
        public int nekretninaID
        {
            get { return (int)ViewState["nekretninaID"]; }
            set { ViewState["nekretninaID"] = value; }
        }

        public int logirani
        {
            get { return (int)ViewState["logirani"]; }
            set { ViewState["logirani"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.Name != "" && Request["id"] != null)
                {
                    logirani = Convert.ToInt32(User.Identity.Name);
                    nekretninaID = Convert.ToInt32(Request["id"]);
                }
                else
                {
                    logirani = 0;
                    nekretninaID = 0;
                }

                BindGrid();
            }
        }

        private void BindGrid()
        {
            Preporuka p = new Preporuka();

            gridOcjene.DataSource = p.GetSlicneProizvode(nekretninaID, logirani);
            gridOcjene.DataBind();
        }

        protected void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (rblOcijeni.SelectedItem != null)
            {
                Ocjene o = DANekretnine.provjeriOcjenjene(logirani, nekretninaID);

                if (o == null)
                {
                    Ocjene oc = new Ocjene();
                    oc.KupacID = logirani;
                    oc.NekretninaID = nekretninaID;
                    oc.Datum = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    oc.Ocjena = Convert.ToInt32(rblOcijeni.SelectedIndex + 1);

                    DANekretnine.inesrtOcjena(oc);

                    string display = "Uspješno spašeno.";
                    ClientScript.RegisterStartupScript(this.GetType(), "Info", "alert('" + display + "');", true);

                    BindGrid();
                }
                else
                {
                    string display = "Uslugu ste već ocjenili!";
                    ClientScript.RegisterStartupScript(this.GetType(), "Upozorenje", "alert('" + display + "');", true);
                }
            }
        }
    }
}