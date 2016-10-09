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
using System.Text.RegularExpressions;

namespace Administracija.TempKorisnici
{
    public partial class IzmjenaStatusnihPodataka : Form
    {
        private SistemNekretnine.DB.Korisnici korisnik;

        public IzmjenaStatusnihPodataka(SistemNekretnine.DB.Korisnici k)
        {
            InitializeComponent();

            if (k != null)
            {
                korisnik = k;
                UcitajPodatke();
            }
        }

        void UcitajPodatke()
        {
            korisnickoImeInput.Text = korisnik.KorisnickoIme;
            aktivanCheck.Checked = korisnik.Status;
            ((ListBox)ulogeList).DataSource = DAKorisnici.Uloge_Select();
            ((ListBox)ulogeList).DisplayMember = "Naziv";
            ((ListBox)ulogeList).ClearSelected();


            korisnik.KorisniciUloge = DAKorisnici.Uloge_SelectByKorisnikID(korisnik.KorisnikID);
            List<Uloge> tempUloge = DAKorisnici.UlogeTEMP_SelectByKorisnikID(korisnik.KorisnikID);
            for (int i = 0; i < ulogeList.Items.Count; i++)
            {

                foreach (var item in tempUloge)
                {
                    if (item.Naziv==((Uloge)ulogeList.Items[i]).Naziv)
                    {
                          ulogeList.SetItemCheckState(i, CheckState.Checked);
                    }
                }
               
            }

        }

        private void IzmjenaStatusnihPodataka_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (lozinkaInput.Text != "")
            {
                korisnik.LozinkaSalt = UIHelper.GenerateSalt();
                korisnik.LozinkaHash = UIHelper.GenerateHash(lozinkaInput.Text, korisnik.LozinkaSalt);
                DAKorisnici.ResetPassword(korisnik);
            }

            DAKorisnici.UpdateUloge(korisnik.KorisnikID, ulogeList.CheckedItems.Cast<Uloge>().ToList());

            string poruka = "";
            if (korisnik.KorisnikID != Global.prijavljeniKorisnik.KorisnikID && !aktivanCheck.Checked)
                poruka = Global.GetString("status_err");
            else if (korisnik.Status != aktivanCheck.Checked)
                DAKorisnici.UpdateStatus(korisnik.KorisnikID, aktivanCheck.Checked);

            MessageBox.Show(poruka + "\n" + Global.GetString("user_update_succ"), "Promjene", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Close();
        }

        private void lozinkaInput_Validating(object sender, CancelEventArgs e)
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
    }
}
