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

namespace Administracija.TempNarudzbe
{
    public partial class PregledNarudzbi : Form
    {
        public PregledNarudzbi()
        {
            InitializeComponent();
        }

        private void PregledNarudzbi_Load(object sender, EventArgs e)
        {
            dataGridViewNekretnine.DataSource = DANarudzbe.getAll();
        }

        private void dataGridViewNekretnine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            esp_Narudzbe_SelectAll_Result xx = (esp_Narudzbe_SelectAll_Result)dataGridViewNekretnine.Rows[e.RowIndex].DataBoundItem;

            TempNarudzbe.ZakljuciNaruzbu zakljuci = new ZakljuciNaruzbu(xx,Global.prijavljeniKorisnik.KorisnikID);
            zakljuci.ShowDialog();

            dataGridViewNekretnine.DataSource = DANarudzbe.getAll();
        }

        private void btnTrazi_Click(object sender, EventArgs e)
        {
            dataGridViewNekretnine.DataSource = DANarudzbe.getAllByDate(dateTimePicker1.Value);
        }
    }
}
