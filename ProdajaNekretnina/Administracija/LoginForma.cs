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

namespace Administracija
{
    public partial class LoginForma : Form
    {
        public LoginForma()
        {
            InitializeComponent();
        }

        private void potvrdiButton_Click(object sender, EventArgs e)
        {
            SistemNekretnine.DB.Korisnici k = DAKorisnici.SelectByKorisnickoIme(korisnickoImeInput.Text, lozinkaInput.Text);

            if (k != null) //Ispravni korisnički podaci
            {
                List<KorisniciUloge> tempUloge = DAKorisnici.getUlogeByKorisnikID(k.KorisnikID);

                if (tempUloge!=null) //Postoji definisana minimalno jedna uloga na sistemu
                {
                    if (tempUloge.Count>0)
                    {
                        Global.prijavljeniKorisnik = k;
                        this.DialogResult = DialogResult.OK;

                        GlavnaForma frmGlavna = new GlavnaForma();
                        frmGlavna.Show();
                        this.Hide();
                    }
                    
                }
            }
            else
            {
                lozinkaInput.Text = "";
                MessageBox.Show(Global.GetString("login_err"), "Prijava", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void korisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (korisnickoImeInput.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(korisnickoImeInput, Global.GetString("username_req"));
            }
        }

        private void lozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            if (lozinkaInput.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(lozinkaInput, Global.GetString("password_req"));
            }
        }

        private void lozinkaInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
                potvrdiButton_Click(potvrdiButton, EventArgs.Empty);
        }

        private void LoginForma_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
        }

        private void korisnickoImeInput_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
