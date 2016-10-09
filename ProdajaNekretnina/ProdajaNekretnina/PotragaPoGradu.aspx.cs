using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemNekretnine.DB;

namespace ProdajaNekretnina
{
    public partial class PotragaPoGradu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlKantoni.DataSource = DANekretnine.getKantone();
                ddlKantoni.DataTextField = "Naziv";
                ddlKantoni.DataValueField = "KantonID";
                ddlKantoni.DataBind();
           

            }

        }

        protected void ddlKantoni_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ddlKantoni.SelectedValue);
            ddlGrad.DataSource = DANekretnine.getGradove(ID);
            ddlGrad.DataTextField = "NazivGarda";
            ddlGrad.DataValueField = "GradID";
            ddlGrad.DataBind();
            BindGrid();
        }
        protected void BindGrid()
        {
            int id = Convert.ToInt32(ddlGrad.SelectedValue);
            GridView1.DataSource = DANekretnine.PotraznjaSelect(id);
            GridView1.DataBind();
        }

        protected void btnDodaj_Click(object sender, EventArgs e)
        {
            Kupci k = (Kupci)Session["kupac"];
            DANekretnine.PotraznjaInsert(Convert.ToInt32(k.KupacID), Convert.ToInt32(ddlGrad.SelectedValue));

        }
    }
}