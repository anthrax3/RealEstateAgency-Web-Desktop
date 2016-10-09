using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracija
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void btnNoviKorisnik_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Korisnici.NoviKorisnik newForm = new Korisnici.NoviKorisnik();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            newForm.MdiParent = this;
            newForm.Size = this.Size;
            newForm.Show();
        }

        private void btnPretragaKorisnika_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            TempKorisnici.PretragaKorisnika newForm = new TempKorisnici.PretragaKorisnika();
            newForm.WindowState = FormWindowState.Maximized;
            newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            newForm.MdiParent = this;
            newForm.Size = this.Size;
            newForm.Show();
        }

        private void btnDodajNekretninu_Click(object sender, EventArgs e)
        {
            TempNekretnine.NovaNekretnina frmNekre = new TempNekretnine.NovaNekretnina();
            frmNekre.FormClosing += frmNekreClosing;
            frmNekre.ShowDialog();
        }

        private void frmNekreClosing(object sender, FormClosingEventArgs e)
        {

            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            TempNekretnine.PregledNekretnina frmPregledNekre = new TempNekretnine.PregledNekretnina();
            frmPregledNekre.WindowState = FormWindowState.Maximized;
            frmPregledNekre.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmPregledNekre.MdiParent = this;
            frmPregledNekre.Size = this.Size;
            frmPregledNekre.Show();
           
        }

        private void btnPregledNekretnina_Click(object sender, EventArgs e)
        {
           
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            TempNekretnine.PregledNekretnina frmPregledNekre = new TempNekretnine.PregledNekretnina();
            frmPregledNekre.WindowState = FormWindowState.Maximized;
            frmPregledNekre.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmPregledNekre.MdiParent = this;
            frmPregledNekre.Size = this.Size;
            frmPregledNekre.Show();
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            TempNarudzbe.PregledNarudzbi frmPregledNarudz = new TempNarudzbe.PregledNarudzbi();
            frmPregledNarudz.WindowState = FormWindowState.Maximized;
            frmPregledNarudz.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmPregledNarudz.MdiParent = this;
            frmPregledNarudz.Size = this.Size;
            frmPregledNarudz.Show();
        }

        private void izvještajiPoDatumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvjestaji.ProdajaNekretnina form = new Izvjestaji.ProdajaNekretnina();
            form.WindowState = FormWindowState.Maximized;
            form.MdiParent = this;
            form.Show();
        }

        private void printanjeUgovoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izvjestaji.Izlazi form = new Izvjestaji.Izlazi();
            form.WindowState = FormWindowState.Maximized;
            form.MdiParent = this;
            form.Show();
        }
    }
}
