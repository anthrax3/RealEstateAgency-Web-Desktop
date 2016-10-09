using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SistemNekretnine.DB;

namespace ProdajaNekretnina.KorisniciSistema
{
    public partial class AktivneNekretnine : System.Web.UI.Page
    {
        int PitanjeID;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Request["id"]!=null)
                {
                    GridView1.DataSource=DANekretnine.getObjavljene(Convert.ToInt32(Request["id"]));
                    GridView1.DataBind();
                    GridView2.DataSource = DANekretnine.getNeodgPitanjaByKorID(Convert.ToInt32(Request["id"]));
                    GridView2.DataBind();
                }
            }
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
          Session[PitanjeID] = Convert.ToInt32(e.CommandArgument);
            Panel1.Visible = true;
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DANekretnine.InsertOdgovor(Convert.ToInt32(Session[PitanjeID] ), TextBox1.Text);
            Panel1.Visible = false;
            GridView2.DataSource = DANekretnine.getNeodgPitanjaByKorID(Convert.ToInt32(Request["id"]));
            GridView2.DataBind();
        }
    }
}