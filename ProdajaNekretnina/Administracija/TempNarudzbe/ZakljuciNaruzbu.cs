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
    public partial class ZakljuciNaruzbu : Form
    {

        public esp_Narudzbe_SelectAll_Result tempNekretnina { get; set; }

        public int logirani { get; set; }

        public ZakljuciNaruzbu(esp_Narudzbe_SelectAll_Result x , int log)
        {
            InitializeComponent();

            tempNekretnina = x;

            tbNaslov.Text = tempNekretnina.Naslov;
            double a =Convert.ToDouble( tempNekretnina.Cijena);
            string formatted = String.Format("{0:F2}", a);
            tbCijena.Text = formatted;

            logirani = log;
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            double uplaceno = Convert.ToDouble(tbUplaceno.Text);

            if (tempNekretnina.Cijena <= uplaceno)
            {

                Random rnd = new Random();

                Izlazi iz = new Izlazi();
                iz.BrojRacuna = rnd.Next().ToString();
                iz.Datum = DateTime.Now;
                iz.IznosBezPDV = Convert.ToDecimal(tempNekretnina.Cijena);
                iz.IznosSaPDV = Convert.ToDecimal(tempNekretnina.Cijena+tempNekretnina.Cijena * 0.17);
                iz.KorisnikID = logirani;
                iz.Zakljucen = false;
                iz.NarudzbaID = tempNekretnina.NarudzbaID;


                int id =DANarudzbe.InsertStavke(iz);

                IzlazStavke izstavk = new IzlazStavke();
                izstavk.IzlazID = id;
                izstavk.Kolicina = 1;
                izstavk.Popust = 0;
                izstavk.Cijena = Convert.ToDecimal(tempNekretnina.Cijena);
                izstavk.NekretninaID = tempNekretnina.NekretninaID;
                
                DANarudzbe.InsertIzlazStavka(izstavk);
                DANarudzbe.updateStatus(tempNekretnina.NarudzbaID);

                DANekretnine.updateStatus(tempNekretnina.NekretninaID);

                MessageBox.Show("Usješno izvršen obračun!", "Info",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Usluga kosta vise nego sto je uplaceno!", "Upozorenje",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbUplaceno_TextChanged(object sender, EventArgs e)
        {
            if (tbUplaceno.Text == "")
                return;
            double uplaceno = Convert.ToDouble(tbUplaceno.Text);

            double vratiti = (double)tempNekretnina.Cijena-uplaceno;
            tbVratiti.Text = vratiti.ToString() + "KM";
        }
    }
}
