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
using System.IO;

namespace Administracija.TempNekretnine
{
    public partial class NovaNekretnina : Form
    {
        public NovaNekretnina()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void NovaNekretnina_Load(object sender, EventArgs e)
        {
            BindForm();
            this.ActiveControl = comboVrste;
        }

        private void BindForm()
        {
            comboBoxStanje.DataSource = DANekretnine.getSatanja();
            comboBoxStanje.DisplayMember = "NazivStanja";
            comboBoxStanje.ValueMember = "StanjeID";

            comboBoxKategorije.DataSource = DANekretnine.getkategorije();
            comboBoxKategorije.DisplayMember = "NazivKategorije";
            comboBoxKategorije.ValueMember = "KategorijaID";

            comboVrste.DataSource = DANekretnine.getVrste();
            comboVrste.DisplayMember = "NazivVrste";
            comboVrste.ValueMember = "VrstaID";

            comboBoxSprat.DataSource = DANekretnine.getSpratovi();
            comboBoxSprat.DisplayMember = "NazivSprata";
            comboBoxSprat.ValueMember = "SpratID";

            comboBoxSobe.DataSource = DANekretnine.getSobe();
            comboBoxSobe.DisplayMember = "BrojSoba";
            comboBoxSobe.ValueMember = "SobaID";

            comboBoxGrijanje.DataSource = DANekretnine.getGrijanje();
            comboBoxGrijanje.DisplayMember = "NazivGrijanja";
            comboBoxGrijanje.ValueMember = "GrijanjeID";

            comboBox1.DataSource = DANekretnine.getKantone();
            comboBox1.DisplayMember = "Naziv";
            comboBox1.ValueMember = "KantonID";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vrstaList_Validating(object sender, CancelEventArgs e)
        {

            if(comboVrste.SelectedIndex == 0)
            {
                MessageBox.Show(Global.GetString("vrste_req"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //e.Cancel = true;
                //errorProvider1.SetError(comboVrste, Global.GetString("vrste_req"));
            
            }
        }

        private void comboBoxKategorije_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxKategorije.SelectedIndex == 0)
            {
                MessageBox.Show(Global.GetString("kategorije_req"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //e.Cancel = true;
                //errorProvider1.SetError(comboBoxKategorije, Global.GetString("kategorije_req"));
            }
        }

        private void comboBoxStanje_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxStanje.SelectedIndex == 0)
            {
                MessageBox.Show(Global.GetString("stanje_req"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //e.Cancel = true;
                //errorProvider1.SetError(comboBoxStanje, Global.GetString("stanje_req"));
            }
        }

        private void sifraInput_Validating(object sender, CancelEventArgs e)
        {
            if (tbNaslov.Text.Trim()=="")
            {
                MessageBox.Show(Global.GetString("naziv_req"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //e.Cancel = true;
                //errorProvider1.SetError(tbNaslov, Global.GetString("naziv_req"));
            }
        }

        private void nazivInput_Validating(object sender, CancelEventArgs e)
        {
            if (tbBrojKvadrata.Text.Trim() == "")
            {
                MessageBox.Show(Global.GetString("kvadrati_req"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //e.Cancel = true;
                //errorProvider1.SetError(tbBrojKvadrata, Global.GetString("kvadrati_req"));
            }
        }

        private void tbAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (tbAdresa.Text.Trim() == "")
            {
                MessageBox.Show(Global.GetString("adresa_req"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //e.Cancel = true;
                //errorProvider1.SetError(tbAdresa, Global.GetString("adresa_req"));
            }   //
        }

        private void cijenaInput_Validating(object sender, CancelEventArgs e)
        {
            if(cijenaInput.Text=="")
            {
                MessageBox.Show(Global.GetString("cijena_req"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            //if (cijenaInput.Text.Length == 0)
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(cijenaInput, Global.GetString("cijena_req"));
            //}
        }

        //private void comboBoxKategorije_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Kategorije k = (Kategorije)comboBoxKategorije.SelectedItem;

        //    if (k.KategorijaID != 0)
        //    {
        //        if (k.NazivKategorije == "Garaže")
        //        {
        //            comboBoxGrijanje.Enabled = false;
        //            comboBoxSobe.Enabled = false;
        //            comboBoxSprat.Enabled = false;

        //            checkBoxGaraža.Enabled = false;
        //            checkBoxInternet.Enabled = false;
        //            checkBoxLift.Enabled = false;
        //            checkBoxNamješten.Enabled = false;
        //            checkBoxParking.Enabled = false;
        //            checkBoxTelefon.Enabled = false;
        //        }

        //        if (k.NazivKategorije == "Kuće" || k.NazivKategorije == "Vikendice")
        //        {
        //            comboBoxSprat.Enabled = false;
        //            comboBoxSobe.Enabled = false;
        //        }
        //    }
        //}

        private void dodajButton_Click(object sender, EventArgs e)
        {
            int kkk = Convert.ToInt32( Global.prijavljeniKorisnik.KorisnikID);

            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                Kategorije k = (Kategorije)comboBoxKategorije.SelectedItem;

                //if (k.NazivKategorije == "Garaže")
                //{
                //    Nekretnine n = new Nekretnine();

                //    n.Adresa = tbAdresa.Text;
                //    n.Aktivna = checkBoxAktivna.Checked;
                //    n.BrojKvadrata = Convert.ToInt32(tbBrojKvadrata.Text);
                //    n.BrojPosjeta = 0;
                //    n.Cijena = Convert.ToDouble(cijenaInput.Text);
                //    n.DatumObjave = DateTime.Now;
                //    n.GodinaIzgradnje = Convert.ToInt32(textBoxGodina.Text);
                //    n.KategorijaID = Convert.ToInt32(comboBoxKategorije.SelectedValue);
                //    n.Naslov = tbNaslov.Text;
                //    n.NedavnoAdaptiran = checkBoxNedavnoAdaptiran.Checked;
                //    n.Novogradnja = checkBoxNovogradnja.Checked;
                //    n.StanjeID = Convert.ToInt32(comboBoxStanje.SelectedValue);
                //    n.Struja = checkBoxStruja.Checked;
                //    n.Uknjiženo = checkBoxUknjiženo.Checked;
                //    n.VrstaID = Convert.ToInt32(comboVrste.SelectedValue);
                //    n.KantonID = Convert.ToInt32(comboBox1.SelectedValue);
                //    n.SpratID = null;
                //    n.KorisnikID = kkk;
                //    n.GrijanjeID = null;
                //    n.Internet = null;

                //    //Spašavanje slike

                //    if (pictureBox1.Image != null)
                //    {
                //        using (MemoryStream ms = new MemoryStream())
                //        {
                //            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //            n.SlikaThumb = ms.ToArray();
                //        }
                //    }

                //    DANekretnine.insert(n);

                //    MessageBox.Show(Global.GetString("nekre_succ"), "Korisnik", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    clear();
                //}

                //if (k.NazivKategorije == "Kuće" || k.NazivKategorije == "Vikendice")
                //{
                //    Nekretnine n = new Nekretnine();
                //    n.Adresa = tbAdresa.Text;
                //    n.Aktivna = checkBoxAktivna.Checked;
                //    n.BrojKvadrata = Convert.ToInt32(tbBrojKvadrata.Text);
                //    n.BrojPosjeta = 0;
                //    n.Cijena = Convert.ToDouble(cijenaInput.Text);
                //    n.DatumObjave = DateTime.Now;
                //    n.Garaža = checkBoxGaraža.Checked;
                //    n.GodinaIzgradnje = Convert.ToInt32(textBoxGodina.Text);
                //    n.GrijanjeID = Convert.ToInt32(comboBoxGrijanje.SelectedValue);
                //    n.Internet = checkBoxInternet.Checked;
                //    n.KategorijaID = Convert.ToInt32(comboBoxKategorije.SelectedValue);
                //    n.Knalizacija = checkBoxKanalizacija.Checked;
                //    n.Namješten = checkBoxNamješten.Checked;
                //    n.Naslov = tbNaslov.Text;
                //    n.NedavnoAdaptiran = checkBoxNedavnoAdaptiran.Checked;
                //    n.Novogradnja = checkBoxNovogradnja.Checked;
                //    n.Parking = checkBoxParking.Checked;
                //    n.StanjeID = Convert.ToInt32(comboBoxStanje.SelectedValue);
                //    n.Struja = checkBoxStruja.Checked;
                //    n.Telefon = checkBoxTelefon.Checked;
                //    n.Uknjiženo = checkBoxUknjiženo.Checked;
                //    n.Voda = checkBoxVoda.Checked;
                //    n.VrstaID = Convert.ToInt32(comboVrste.SelectedValue);
                //    n.KantonID = Convert.ToInt32(comboBox1.SelectedValue);
                //    n.KorisnikID = kkk;


                //    //Spašavanje slike

                //    if (pictureBox1.Image != null)
                //    {
                //        using (MemoryStream ms = new MemoryStream())
                //        {
                //            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //            n.SlikaThumb = ms.ToArray();
                //        }
                //    }

                //    DANekretnine.insert(n);
                //    MessageBox.Show(Global.GetString("nekre_succ"), "Korisnik", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    clear();
                //}
                //else
                //{

                if (Validacija() == true)
                {
                    Nekretnine n = new Nekretnine();

                    //   if(comboBoxSobe.SelectedIndex==0)
                    //   {
                    //       n.SobeID = null;
                    //   }
                    //else
                    //   {
                    //       n.SobeID = Convert.ToInt32(comboBoxSobe.SelectedValue); ;
                    //   }
                    //if(comboBoxGrijanje.SelectedIndex==0)
                    //{
                    //    n.GrijanjeID = null;
                    //}
                    //else
                    //{
                    //    n.GrijanjeID = Convert.ToInt32(comboBoxGrijanje.SelectedValue); ;
                    //}
                    //if(comboBoxSprat.SelectedIndex==0)
                    //{
                    //    n.SpratID = null;
                    //}
                    //else
                    //{
                    //    n.SpratID = Convert.ToInt32(comboBoxSprat.SelectedValue); ;
                    //}
                    n.Adresa = tbAdresa.Text;
                    n.Aktivna = checkBoxAktivna.Checked;
                    n.BrojKvadrata = Convert.ToInt32(tbBrojKvadrata.Text);
                    n.BrojPosjeta = 0;
                    n.Cijena = Convert.ToDouble(cijenaInput.Text);
                    n.DatumObjave = DateTime.Now;
                    n.Garaža = checkBoxGaraža.Checked;
                    n.GodinaIzgradnje = Convert.ToInt32(textBoxGodina.Text);
                    //n.GrijanjeID = Convert.ToInt32(comboBoxGrijanje.SelectedValue);
                    n.Internet = checkBoxInternet.Checked;
                    n.KategorijaID = Convert.ToInt32(comboBoxKategorije.SelectedValue);
                    n.Knalizacija = checkBoxKanalizacija.Checked;
                    n.Lift = checkBoxLift.Checked;
                    n.Namješten = checkBoxNamješten.Checked;
                    n.Naslov = tbNaslov.Text;
                    n.NedavnoAdaptiran = checkBoxNedavnoAdaptiran.Checked;
                    n.Novogradnja = checkBoxNovogradnja.Checked;
                    n.Parking = checkBoxParking.Checked;
                    n.SobeID = Convert.ToInt32(comboBoxSobe.SelectedValue);
                    // n.SpratID = Convert.ToInt32(comboBoxSprat.SelectedValue);
                    n.StanjeID = Convert.ToInt32(comboBoxStanje.SelectedValue);
                    n.Struja = checkBoxStruja.Checked;
                    n.Telefon = checkBoxTelefon.Checked;
                    n.Uknjiženo = checkBoxUknjiženo.Checked;
                    n.Voda = checkBoxVoda.Checked;
                    n.VrstaID = Convert.ToInt32(comboVrste.SelectedValue);
                    n.KantonID = Convert.ToInt32(comboBox1.SelectedValue);
                    n.KorisnikID = kkk;

                    //Spašavanje slike

                    if (pictureBox1.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            n.SlikaThumb = ms.ToArray();
                        }
                    }

                    DANekretnine.insert(n);
                    MessageBox.Show(Global.GetString("nekre_succ"), "Korisnik", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear();
                }
                else
                {
                    errorProvider1.SetError(dodajButton, Global.GetString("sobe_req"));
                    MessageBox.Show(Global.GetString("nekre_bad"), "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
            }
                    
                    
                

            
        }

        private void clear()
        {
            comboBoxSobe.SelectedIndex = 0;
            comboBoxSprat.SelectedIndex = 0;
            comboBoxStanje.SelectedIndex = 0;
            comboVrste.SelectedIndex = 0;
            comboBoxKategorije.SelectedIndex = 0;
            comboBoxGrijanje.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;

            tbAdresa.Text = "";
            tbBrojKvadrata.Text = "";
            tbNaslov.Text = "";
            cijenaInput.Text = "";
            textBoxGodina.Text = "";
            slikaInput.Text = "";

            checkBoxAktivna.Checked = false;
            checkBoxGaraža.Checked = false;
            checkBoxInternet.Checked = false;
            checkBoxKanalizacija.Checked = false;
            checkBoxLift.Checked = false;
            checkBoxNamješten.Checked = false;
            checkBoxNedavnoAdaptiran.Checked = false;
            checkBoxNovogradnja.Checked = false;
            checkBoxParking.Checked = false;
            checkBoxStruja.Checked = false;
            checkBoxTelefon.Checked = false;
            checkBoxUknjiženo.Checked = false;
            checkBoxVoda.Checked = false;
        }


        private bool Validacija()
        {
            if (comboBoxGrijanje.SelectedIndex == 0 || comboBoxSprat.SelectedIndex == 0 || comboBoxSobe.SelectedIndex == 0
                        //&& comboBoxKategorije.SelectedIndex == 0 && comboVrste.SelectedIndex == 0 && comboBox1.SelectedIndex == 0
                        || comboBoxKategorije.SelectedIndex == 0 || cijenaInput.Text.Trim() == "" || tbAdresa.Text.Trim() == "" ||
                        tbNaslov.Text.Trim() == "" || textBoxGodina.Text.Trim() == "" || tbBrojKvadrata.Text.Trim() == "")
                       return false;

            
            else
                return true;

        }


        private void dodajSlikuButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            Bitmap slika = new Bitmap(openFileDialog1.FileName);
            Bitmap slikaR = new Bitmap(186, 200);

            Graphics.FromImage(slikaR).DrawImage(slika, 0, 0, 166, 200);
            pictureBox1.Image = slikaR;

            slikaInput.Text = openFileDialog1.FileName;
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show(Global.GetString("godina_req"), "Korisnik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            //    e.Cancel = true;
            //    errorProvider1.SetError(comboBoxStanje, Global.GetString("kant_req"));
            }
        }

        private void textBoxGodina_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxGodina.Text.Trim()=="")
            {
                MessageBox.Show(Global.GetString("godina_req"), "Korisnik", MessageBoxButtons.OK, MessageBoxIcon.Information);

               // e.Cancel = true;
               // errorProvider1.SetError(comboBoxStanje, Global.GetString("godina_req"));
            }
        }

        private void comboBoxGrijanje_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxGrijanje.SelectedIndex==0)
            {
                MessageBox.Show(Global.GetString("grijanje_req"), "Korisnik", MessageBoxButtons.OK, MessageBoxIcon.Information);

               // e.Cancel = true;
               // errorProvider1.SetError(comboBoxStanje, Global.GetString("grijanje_req"));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if(cijenaInput.Text =="")
                {
                    MessageBox.Show(Global.GetString("cijena_e"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                //http://prntscr.com/8gl39n
           
        }

        private void sobe_val(object sender, CancelEventArgs e)
        {
            if (comboBoxSobe.SelectedIndex == 0) 
            {
                MessageBox.Show(Global.GetString("sobe_req"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void sprat_validating(object sender, CancelEventArgs e)
        {
            if (comboBoxSprat.SelectedIndex == 0)
            {
                MessageBox.Show(Global.GetString("sprat_req"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void comboBoxGrijanje_Validating_1(object sender, CancelEventArgs e)
        {
            if (comboBoxGrijanje.SelectedIndex == 0)
            {
                MessageBox.Show(Global.GetString("grijanje_req"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        //private void comboBoxSobe_Validating(object sender, CancelEventArgs e)
        //{
        //    if (comboBoxSobe.SelectedIndex==0)
        //    {
        //        e.Cancel = true;
        //        errorProvider1.SetError(comboBoxStanje, Global.GetString("sobe_req"));
        //    }
        //}
    }
}
