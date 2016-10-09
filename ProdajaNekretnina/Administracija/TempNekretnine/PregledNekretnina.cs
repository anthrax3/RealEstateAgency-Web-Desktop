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

namespace Administracija.TempNekretnine
{
    public partial class PregledNekretnina : Form
    {
        public PregledNekretnina()
        {
            this.AutoScroll = true;
            InitializeComponent();
            dataGridViewNekretnine.DataSource = DANekretnine.nekretnineAll();
        }

        private void PregledNekretnina_Load(object sender, EventArgs e)
        {
            BindForm();
            dataGridViewNekretnine.DataSource = DANekretnine.nekretnineAll();
        }

        private void BindForm()
        {
            comboBoxKategorije.DataSource = DANekretnine.getkategorije();
            comboBoxKategorije.DisplayMember = "NazivKategorije";
            comboBoxKategorije.ValueMember = "KategorijaID";

            comboVrste.DataSource = DANekretnine.getVrste();
            comboVrste.DisplayMember = "NazivVrste";
            comboVrste.ValueMember = "VrstaID";
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        
        {
            

            //if (this.ValidateChildren(ValidationConstraints.Enabled))
            //{
            //    dataGridViewNekretnine.DataSource = DANekretnine.getPretraga(Convert.ToInt32(comboBoxKategorije.SelectedValue), Convert.ToInt32(comboVrste.SelectedValue), checkBoxAktivna.Checked);
            //}
            //else
                if (comboBoxKategorije.SelectedIndex==0 && comboVrste.SelectedIndex == 0 && checkBoxAktivna.Checked == false)
                {
                    dataGridViewNekretnine.DataSource = DANekretnine.nekretnineAll();
                }

            else
               dataGridViewNekretnine.DataSource = DANekretnine.getPretraga(Convert.ToInt32(comboBoxKategorije.SelectedValue), Convert.ToInt32(comboVrste.SelectedValue), checkBoxAktivna.Checked);

        }

        private void comboVrste_Validating(object sender, CancelEventArgs e)
        {
            if (comboVrste.SelectedIndex==0)
            {
                e.Cancel = true;
                errorProvider1.SetError(comboVrste, Global.GetString("vrste_req"));
            }
        }

        private void comboBoxKategorije_Validating(object sender, CancelEventArgs e)
        {

            if (comboBoxKategorije.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(comboBoxKategorije, Global.GetString("kategorije_req"));
            }
        }
    }
}
