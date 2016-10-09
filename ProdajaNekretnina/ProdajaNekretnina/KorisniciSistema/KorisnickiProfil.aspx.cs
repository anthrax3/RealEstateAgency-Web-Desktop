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
    public partial class KorisnickiProfil : System.Web.UI.Page
    {
        public int logirani
        {
            get { return (int)ViewState["logirani"]; }
            set { ViewState["logirani"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User.Identity.Name != "")
                {
                    logirani = Convert.ToInt32(User.Identity.Name);
                    BindForm();
                }
                else
                {
                    logirani = 0;
                }
            }
        }

        private void BindForm()
        {
            Kupci k = DAKupci.getByID(logirani);
            
            tbEmail.Text = k.Email;
            tbIme.Text = k.Ime;
            tbPrezime.Text = k.Prezime;
            
        }

        protected void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Kupci k = DAKupci.provjeriEmail(tbEmail.Text);

            if (k == null)
            {
                Kupci kup = new Kupci();
                kup.KupacID = Convert.ToInt32(User.Identity.Name);
                kup.Email = tbEmail.Text;
                string salt = UIHelper.GenerateSalt();
                kup.LozinkaSalt = salt;
                kup.LozinkaHash = UIHelper.GenerateHash(tbPassword.Text, salt);
                DAKupci.update(kup);

                BindForm();
            }
        }

        protected void btnNekretnine_Click(object sender, EventArgs e)
        {
            Response.Redirect("/KorisniciSistema/AktivneNekretnine.aspx?id=" + logirani);
        }

        protected void btnNarudzbe_Click(object sender, EventArgs e)
        {
            Response.Redirect("/KorisniciSistema/PregledNarudzbi.aspx?id=" + logirani);
        }
    }
}