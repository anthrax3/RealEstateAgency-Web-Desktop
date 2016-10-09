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
using SistemNekretnine.Util;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Administracija.Korisnici
{
    public partial class NoviKorisnik : Form
    {
        public NoviKorisnik()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                SistemNekretnine.DB.Korisnici k = new SistemNekretnine.DB.Korisnici();
                k.Ime = imeInput.Text.Trim();
                k.Prezime = prezimeInput.Text.Trim();
                k.Email = emailInput.Text.Trim();
                k.Telefon = telefonInput.Text.Trim();

                k.KorisnickoIme = korisnickoImeInput.Text;
                k.LozinkaSalt = UIHelper.GenerateSalt();
                k.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, k.LozinkaSalt);
                k.Status = true;

                List<Uloge> tempUloge = ulogeList.CheckedItems.Cast<Uloge>().ToList();

               
                try
                {
                    DAKorisnici.Insert(k);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Global.GetString(ex.Message));
                    return;
                }
                foreach (var item in tempUloge)
                {
                    DAKorisnici.insertUloge(item, k);  //Global.prijavljeniKorisnik);
                }

                MessageBox.Show(Global.GetString("user_succ"), "Korisnik", MessageBoxButtons.OK, MessageBoxIcon.Information);

                

                clear();
            }
        }

        private void clear()
        {
            imeInput.Text = "";
            prezimeInput.Text = "";
            emailInput.Text = "";
            telefonInput.Text = "";
            korisnickoImeInput.Text = "";
            lozinkaInput.Text = "";

            ulogeList.ClearSelected(); //Poništiti selekciju
            foreach (int item in ulogeList.CheckedIndices)
            {
                //Poništiti označene uloge
                ulogeList.SetItemCheckState(item, CheckState.Unchecked);
            }
        }

        private void NoviKorisnik_Load(object sender, EventArgs e)
        {
            ((ListBox)ulogeList).DataSource = DAKorisnici.Uloge_Select();
            ((ListBox)ulogeList).DisplayMember = "Naziv";
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

        private void korisnickoImeInput_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(lozinkaInput.Text, @"^(?=.*[a-z])(?=.*\d).{8,15}$"))
            {
                e.Cancel = true;
                errorProvider1.SetError(lozinkaInput, Global.GetString("password_notmatched"));
            }


            if (lozinkaInput.TextLength < 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(lozinkaInput, Global.GetString("password_err"));
            }
        }

        private void lozinkaInput_Validating(object sender, CancelEventArgs e)
        {
            if (korisnickoImeInput.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(korisnickoImeInput, Global.GetString("username_req"));
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
