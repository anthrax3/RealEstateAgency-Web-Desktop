using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SistemNekretnine.DB;
using SistemNekretnine.Util;

namespace ProdajaNekretnina
{
    public partial class Registracija : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistracija_Click(object sender, EventArgs e)
        {
            Kupci k = DAKupci.provjeriEmail(tbEmail.Text);

            if (k == null)
            {
                Kupci kup = new Kupci();
                kup.Ime = tbIme.Text;
                kup.Prezime = tbPrezime.Text;
                kup.DatumRegistracije = DateTime.Now;
                kup.Email = tbEmail.Text;
                string salt = UIHelper.GenerateSalt();
                kup.LozinkaSalt = salt;
                kup.LozinkaHash = UIHelper.GenerateHash(tbPassword.Text, salt);
                kup.Status = true;

                DAKupci.Insert(kup);

                Response.Redirect("/KorisniciSistema/Prijava.aspx");

                ClearForm();
            }
            else
            {
                string display = "Email je zauzet!";
                ClientScript.RegisterStartupScript(this.GetType(), "Upozorenje", "alert('" + display + "');", true);
            }
        }

        private void ClearForm()
        {
            tbIme.Text = "";
            tbPrezime.Text = "";
            tbEmail.Text = "";
            tbPassword.Text = "";
            tbRetypePassword.Text = "";
        }
    }
}