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

namespace Administracija.TempKorisnici
{
    public partial class PretragaKorisnika : Form
    {
        SistemNekretnine.DB.Korisnici k = new SistemNekretnine.DB.Korisnici();
        
        public PretragaKorisnika()
        {
            InitializeComponent();
        }

        private void PretragaKorisnika_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            BindGrid();
            izmjeneMenu.DropDown.AutoClose = false;
        }

        private void imePrezimeInput_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        public void BindGrid()
        {
            korisniciGrid.DataSource = DAKorisnici.SelectByName(imePrezimeInput.Text.Trim());
            korisniciGrid.Columns[0].Visible = false;
            korisniciGrid.ClearSelection();
        }

        private void deaktivirajSubmit_Click(object sender, EventArgs e)
        {

            if (k != null)
            {
                //Zabraniti deaktivaciju trenutno prijavljenog korisnika i 
                // korisnika koji je već ranije deaktiviran
                if ((bool)korisniciGrid.SelectedRows[0].Cells[4].Value &&
                    k.KorisnikID != Global.prijavljeniKorisnik.KorisnikID)
                {
                    DAKorisnici.UpdateStatus(k.KorisnikID, false);
                    BindGrid();
                }
            }
        }

        private void korisniciGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kid = Convert.ToInt32(korisniciGrid.SelectedRows[0].Cells[0].Value);
            k = DAKorisnici.SelectById(kid);
        }

        private void btnLicniPodaci_Click(object sender, EventArgs e)
        {

            if (k != null)
            {
                IzmjenaLicnihPodataka updateForm = new IzmjenaLicnihPodataka(k);
                updateForm.Show();
                updateForm.FormClosed += new FormClosedEventHandler(frm_FormClosed1);
                BindGrid();
            }
        }

        private void frm_FormClosed1(object sender, System.EventArgs e)
        {
            BindGrid();


        }

        private void izmjeneMenu_Click(object sender, EventArgs e)
        {
            izmjeneMenu.DropDown.AutoClose = true;
        }

        private void btnStatusPodaci_Click(object sender, EventArgs e)
        {
            if (k != null)
            {
                IzmjenaStatusnihPodataka updateForm = new IzmjenaStatusnihPodataka(k);
                updateForm.Show();
                updateForm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                if (updateForm.Visible == false)
                    BindGrid();
            }
        }
       
        private void frm_FormClosed(object sender, System.EventArgs e)
        {
            BindGrid();


        }

    }
}
