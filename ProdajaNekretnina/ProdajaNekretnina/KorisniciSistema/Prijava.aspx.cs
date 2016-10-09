using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SistemNekretnine.DB;
using System.Web.Security;

namespace ProdajaNekretnina.KorisniciSistema
{
    public partial class Prijava : System.Web.UI.Page
    {
        public bool logiran { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPrijava_Click(object sender, EventArgs e)
        {
            if (tbKorisnicko.Text != "" && tbLozinka.Text != "")
            {
                Kupci k = DAKupci.logiranje(tbKorisnicko.Text, tbLozinka.Text);

                if (k != null)
                { 
                    Session["kupac"] = k;
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(k.KupacID.ToString(), false, 30);
                    string encryptTicket = FormsAuthentication.Encrypt(ticket);
                    HttpCookie loginCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptTicket);
                    Response.Cookies.Add(loginCookie);
                   
                    Response.Redirect(FormsAuthentication.GetRedirectUrl(k.KupacID.ToString(), false));
                  
                    logiran = true;

                }
                else
                {
                    logiran = false;
                    tbLozinka.Text = "";
                    tbKorisnicko.Text = "";
                    CustomValidator err = new CustomValidator();
                    err.IsValid = false;
                    err.ErrorMessage = "Kombinacija korisničkog imena i lozinke je netačna!";
                    Page.Validators.Add(err);
                    ValidationSummary1.ShowMessageBox = true;
                }
            }
        }
    }
}