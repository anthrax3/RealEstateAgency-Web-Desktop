using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SistemNekretnine.DB;

namespace ProdajaNekretnina
{
    public partial class Korpa : System.Web.UI.Page
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
                    BindGrid();
            }
        }
        private void BindGrid()
        {
            narudzbeGrid.DataSource = narudzba.NarudzbaStavke;
            narudzbeGrid.DataBind();
        }
        protected void btnZakljuci_Click(object sender, EventArgs e)
        {
            if (narudzba != null)
            {
                Int32 id = DANarudzbe.Insert(narudzba);

                foreach (NarudzbaStavke n in narudzba.NarudzbaStavke)
                {
                    DANarudzbe.Insert_Stavke(n, id);
                }

                narudzba=null;
            }
        }
    }
}