using Microsoft.Reporting.WinForms;
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
using System.Drawing.Printing;

namespace Administracija.Izvjestaji
{
    public partial class Ugovor : Form
    {
        int id;
        public Ugovor()
        {
          
            InitializeComponent();
        }
        public Ugovor(int izlazID,bool cekiran)
        {
            if(cekiran)
            {

               int idN=  Convert.ToInt32( DANekretnine.nekretninaIDD(izlazID));
               DANekretnine.updateStatus(idN);
            }
            id = izlazID;
            InitializeComponent();
            esp_Izlazi_Ugovor1_Result lista = DANekretnine.SelectIzlazUgovorByID(id);
            List<esp_Izlazi_Ugovor1_Result> lis = new List<esp_Izlazi_Ugovor1_Result>();
            lis.Add(lista);
            ReportDataSource rds = new ReportDataSource("DataSet1", lis);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();

            
            

            

            DANekretnine.ZakljuciIzlaz(id);
        }

        private void Ugovor_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
        }

        private void reportViewer1_Print(object sender, ReportPrintEventArgs e)
        {


        }

        private void esp_Izlazi_Ugovor1_ResultBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
