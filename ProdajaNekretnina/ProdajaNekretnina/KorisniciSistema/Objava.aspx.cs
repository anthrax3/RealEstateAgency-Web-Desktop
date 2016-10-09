using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SistemNekretnine.DB;
using System.Net;

namespace ProdajaNekretnina.KorisniciSistema
{
    public partial class Objava : System.Web.UI.Page
    {
        public int logirani
        {
            get { return (int)ViewState["logirani"]; }
            set { ViewState["logirani"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindListe();

                logirani = Convert.ToInt32(User.Identity.Name);

            }
        }
         
        private void BindListe()
        {
            ddlKategorije.DataSource = DANekretnine.getkategorije();
            ddlKategorije.DataTextField = "NazivKategorije";
            ddlKategorije.DataValueField = "KategorijaID";
            ddlKategorije.DataBind();
         

            ddlStanje.DataSource = DANekretnine.getSatanja();
            ddlStanje.DataTextField = "NazivStanja";
            ddlStanje.DataValueField = "StanjeID";
            ddlStanje.DataBind();

            ddlKantoni.DataSource = DANekretnine.getKantone();
            ddlKantoni.DataTextField = "Naziv";
            ddlKantoni.DataValueField = "KantonID";
            ddlKantoni.DataBind();

            ddlGrijanje.DataSource = DANekretnine.getGrijanje();
            ddlGrijanje.DataTextField = "NazivGrijanja";
            ddlGrijanje.DataValueField = "GrijanjeID";
            ddlGrijanje.DataBind();

            ddlSobe.DataSource = DANekretnine.getSobe();
            ddlSobe.DataTextField = "BrojSoba";
            ddlSobe.DataValueField = "SobaID";
            ddlSobe.DataBind();

            ddlSprat.DataSource = DANekretnine.getSpratovi();
            ddlSprat.DataTextField = "NazivSprata";
            ddlSprat.DataValueField = "SpratID";
            ddlSprat.DataBind();

            ddlVrste.DataSource = DANekretnine.getVrste();
            ddlVrste.DataTextField = "NazivVrste";
            ddlVrste.DataValueField = "VrstaID";
            ddlVrste.DataBind();
        }

        protected void btnSacuvaj_Click(object sender, EventArgs e)
        {
            int katID = Convert.ToInt32(ddlKategorije.SelectedValue);

            Kategorije k = DANekretnine.getKategorijeByID(katID);
            
                   Nekretnine n = new Nekretnine();
                    n.Adresa = tbAdresa.Text;
                    n.Aktivna = true;
                    n.BrojKvadrata = Convert.ToInt32(tbKvadrati.Text);
                    n.BrojPosjeta = 0;
                    n.Cijena = Convert.ToDouble(tbCijena.Text);
                    n.DatumObjave = DateTime.Now;
                    n.Garaža = cbGaraza.Checked;
                    n.GodinaIzgradnje = Convert.ToInt32(tbGodina.Text);
                    n.GrijanjeID = Convert.ToInt32(ddlGrijanje.SelectedValue);
                    n.Internet = cbInternet.Checked;
                    n.KategorijaID = Convert.ToInt32(ddlKategorije.SelectedValue);
                    n.Knalizacija = cbKanalizacija.Checked;
                    n.Lift = cbLift.Checked;
                    n.Namješten = cbNamjesten.Checked;
                    n.Naslov = tbNaslov.Text;
                    n.NedavnoAdaptiran = cbAdaptiran.Checked;
                    n.Novogradnja = cbNovogradnja.Checked;
                    n.Parking = cbParking.Checked;
                    n.SobeID = Convert.ToInt32(ddlSobe.SelectedValue);
                    n.SpratID = Convert.ToInt32(ddlSprat.SelectedValue);
                    n.StanjeID = Convert.ToInt32(ddlStanje.SelectedValue);
                    n.Struja = cbStruja.Checked;
                    n.Telefon = cbTelefon.Checked;
                    n.Uknjiženo = cbUknjizeno.Checked;
                    n.Voda = cbVoda.Checked;
                    n.VrstaID = Convert.ToInt32(ddlVrste.SelectedValue);
                    n.KantonID = Convert.ToInt32(ddlKantoni.SelectedValue);
                    
                    n.KorisnikID = logirani;
            
                    //Spašavanje slike
                    byte[] slika = uploadImage(n);

                    int id = DANekretnine.insertID(n);
                    int idG = Convert.ToInt32(ddlGrad.SelectedValue);

                    List<string> mailovi = DANekretnine.PotraznjaKorisniciEmail(idG);
                    foreach (var item in mailovi)
                    {
                        SendMail(item, n);
                    }

                    uploadImagesALL(id,slika);
                    //Spašavanje slike



                    clear();
                    Response.Redirect("/Naslovna.aspx");
            
        }

        protected void SendMail(string m, Nekretnine n)
        {
            // Gmail Address from where you send the mail
            var fromAddress = "nekretnine.seminarski.pep@gmail.com";
            // any address where the email will be sending
            var toAddress =m;
            //Password of your gmail address
            const string fromPassword = "nekretni";
            // Passing the values and make a email formate to display
            string subject = "Dodana nekretnina iz vase potrage!";
            string body ="Naziv nekretnine: " + n.Naslov+ "\n";
            body += "Cijena: " + Convert.ToString(n.Cijena) + "\n";
            body += "Mozete je pogledati na vasem profilu pod sekcijom Potraznja \n";
            body += "Hvala na ukazanom povjerenju! ";
            // smtp settings
            var smtp = new System.Net.Mail.SmtpClient();
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
                smtp.Timeout = 20000;
            }
            // Passing values to smtp object
            smtp.Send(fromAddress, toAddress, subject, body);
        }


        private void uploadImagesALL(int id, byte[] slika1)
        {
            List<SlikeNekretnina> sl = new List<SlikeNekretnina>();

            if (FileUpload1.PostedFile != null)
            {
                if (System.IO.Path.GetExtension(FileUpload1.FileName) == ".jpg")
                {
                   
                    SlikeNekretnina s = new SlikeNekretnina();
                    s.SlikaNekretnine = slika1;
                    s.NekretninaID = id;

                    sl.Add(s);
                }
            }

            if (FileUpload2.PostedFile != null)
            {
                if (System.IO.Path.GetExtension(FileUpload2.FileName) == ".jpg")
                {
                    byte[] slika = new byte[FileUpload2.PostedFile.ContentLength];
                    FileUpload2.PostedFile.InputStream.Read(slika, 0, FileUpload2.PostedFile.ContentLength);

                    SlikeNekretnina s1 = new SlikeNekretnina();
                    s1.SlikaNekretnine = slika;
                    s1.NekretninaID = id;

                    sl.Add(s1);
                }
            }

            if (FileUpload3.PostedFile != null)
            {
                if (System.IO.Path.GetExtension(FileUpload3.FileName) == ".jpg")
                {
                    byte[] slika = new byte[FileUpload3.PostedFile.ContentLength];
                    FileUpload3.PostedFile.InputStream.Read(slika, 0, FileUpload3.PostedFile.ContentLength);

                    SlikeNekretnina s3 = new SlikeNekretnina();
                    s3.SlikaNekretnine = slika;
                    s3.NekretninaID = id;

                    sl.Add(s3);
                }
            }

            if (FileUpload4.PostedFile != null)
            {
                if (System.IO.Path.GetExtension(FileUpload4.FileName) == ".jpg")
                {
                    byte[] slika = new byte[FileUpload4.PostedFile.ContentLength];
                    FileUpload4.PostedFile.InputStream.Read(slika, 0, FileUpload4.PostedFile.ContentLength);

                    SlikeNekretnina s4 = new SlikeNekretnina();
                    s4.SlikaNekretnine = slika;
                    s4.NekretninaID = id;

                    sl.Add(s4);
                }
            }

            foreach (var item in sl)
            {
                DANekretnine.insertSlika(item);
            }
        }

        private void clear()
        {
            tbAdresa.Text = "";
            tbCijena.Text = "";
            tbGodina.Text = "";
            tbKvadrati.Text = "";
            tbNaslov.Text = "";

            ddlGrad.SelectedIndex = 0;
            ddlGrijanje.SelectedIndex = 0;
            ddlKantoni.SelectedIndex = 0;
            ddlKategorije.SelectedIndex = 0;
            ddlSobe.SelectedIndex = 0;
            ddlSprat.SelectedIndex = 0;
            ddlStanje.SelectedIndex = 0;
            ddlVrste.SelectedIndex = 0;


        }

       private byte[] uploadImage(Nekretnine n)
        {
            byte[] slika = new byte[FileUpload1.PostedFile.ContentLength];
                    
            if (FileUpload1.PostedFile != null)
            {
                if (System.IO.Path.GetExtension(FileUpload1.FileName) == ".jpg" || System.IO.Path.GetExtension(FileUpload1.FileName) == ".JPEG")
                {
                    FileUpload1.PostedFile.InputStream.Read(slika, 0, FileUpload1.PostedFile.ContentLength);

                    n.SlikaThumb = slika;
                    
                }
            }
            return slika;
        }

        protected void ddlKantoni_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ddlKantoni.SelectedValue);

            Kantoni k = DANekretnine.getKantoniByID(ID);

            if (k != null)
            {
                ddlGrad.DataSource = DANekretnine.getGradove(k.KantonID);
                ddlGrad.DataTextField = "NazivGarda";
                ddlGrad.DataValueField = "GradID";
                ddlGrad.DataBind();
            }
        }
    }
}