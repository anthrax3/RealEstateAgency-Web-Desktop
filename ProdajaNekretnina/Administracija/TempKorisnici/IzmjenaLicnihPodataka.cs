using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SistemNekretnine.DB;
using System.Net.Mail;

namespace Administracija.TempKorisnici
{
    public partial class IzmjenaLicnihPodataka : Form
    {
        private SistemNekretnine.DB.Korisnici korisnik;

        public IzmjenaLicnihPodataka(SistemNekretnine.DB.Korisnici k)
        {
            InitializeComponent();

            if (k != null)
            {
                korisnik = k;
                ucitajPodatke();
            }
            
        }

        void ucitajPodatke()
        {
            imeInput.Text = korisnik.Ime;
            prezimeInput.Text = korisnik.Prezime;
            telefonInput.Text = korisnik.Telefon;
            emailInput.Text = korisnik.Email;
        }

        private void IzmjenaLicnihPodataka_Load(object sender, EventArgs e)
        {

        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            SistemNekretnine.DB.Korisnici k = new SistemNekretnine.DB.Korisnici();
            k.KorisnikID = korisnik.KorisnikID;
            k.Ime = imeInput.Text.Trim();
            k.Prezime = prezimeInput.Text.Trim();
            k.Email = emailInput.Text.Trim();
            k.Telefon = telefonInput.Text.Trim();
            DAKorisnici.UpdateLicniPodaci(k);

            MessageBox.Show(Global.GetString("user_update_succ"), "Korisnik", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void imeInput_Validating(object sender, CancelEventArgs e)
        {
            if (imeInput.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(imeInput, Global.GetString("name_req"));
            }
        }

        private void prezimeInput_Validating(object sender, CancelEventArgs e)
        {

            if (prezimeInput.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(prezimeInput, Global.GetString("lname_req"));
            }
        }

        private void emailInput_Validating(object sender, CancelEventArgs e)
        {
            if (emailInput.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(emailInput, Global.GetString("email_req"));
                return;
            }
            try
            {
                MailAddress mail = new MailAddress(emailInput.Text);
            }
            catch (Exception)
            {
                e.Cancel = true;
                errorProvider1.SetError(emailInput, Global.GetString("email_err"));
            }
        }

        private void telefonInput_Validating(object sender, CancelEventArgs e)
        {
            if (telefonInput.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(telefonInput, Global.GetString("tel_req"));
            }
        }




    }
}
