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
using Microsoft.Reporting.WinForms;
namespace Administracija.Izvjestaji
{
    public partial class ProdajaNekretnina : Form
    {
        public ProdajaNekretnina()
        {
            InitializeComponent();
        }

        private void ProdajaNekretnina_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "Administracija.Izvjestaji.ProdajaReport.rdlc";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<esp_IzlaziByDatum_Result1> ds = DANekretnine.SelectProdajaByDatum(dateTimePicker1.Value, dateTimePicker2.Value);
            ReportDataSource rds = new ReportDataSource("DataSet1", ds);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            //reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumOd", dateTimePicker1.Value.ToShortDateString()));
            //reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumDo", dateTimePicker2.Value.ToShortDateString()));

            reportViewer1.RefreshReport();
            
        }
    }
}
