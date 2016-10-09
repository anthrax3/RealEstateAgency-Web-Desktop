using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SistemNekretnine.DB;

namespace ProdajaNekretnina
{
    public partial class Naslovna : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                dataTop3.DataSource = DANekretnine.getTOP3();
                dataTop3.DataBind();
            }
        }
    }
}