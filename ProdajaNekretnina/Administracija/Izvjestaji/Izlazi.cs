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
namespace Administracija.Izvjestaji
{
    public partial class Izlazi : Form
    {
        public Izlazi()
        {
            InitializeComponent();
        }

        private void Izlazi_Load(object sender, EventArgs e)
        {
            List<esp_Izlazi_SelAll_Result> temp = DANekretnine.SelectAllIzlazi();
            dataGridView1.DataSource = temp;
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int izlazId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value);
                bool cekiran = Convert.ToBoolean((dataGridView1.SelectedRows[0].Cells[4].Value));

                Ugovor frm = new Ugovor(izlazId, cekiran);
                frm.Show();
                frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            }
        }
        private void frm_FormClosed(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = DANekretnine.SelectAllIzlazi();
          

        }
    }
}
