using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemNekretnine.DB;

namespace SistemNekretnine.DB
{
    public class DANekretnine
    {
        public static object getSatanja()
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                List<StanjaNekretnina> st = con.StanjaNekretnina.ToList();
                StanjaNekretnina s = new StanjaNekretnina();
                s.NazivStanja = "-Odaberite stanje-";
                s.StanjeID = 0;
                st.Insert(0, s);

                return st;
            }
        }

        public static List<Kategorije> getkategorije()
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                List<Kategorije> st = con.Kategorije.ToList();
                Kategorije s = new Kategorije();
                s.NazivKategorije = "-Odaberite kategoriju-";
                s.KategorijaID = 0;
                st.Insert(0, s);

                return st;
            }
        }

        public static object getVrste()
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                List<VrsteProdaje> st = con.VrsteProdaje.ToList();
                VrsteProdaje s = new VrsteProdaje();
                s.NazivVrste = "-Odaberite vrstu-";
                s.VrstaID = 0;
                st.Insert(0, s);

                return st;
            }
        }

        public static object getSpratovi()
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                List<Spratovi> st = con.Spratovi.ToList();
                Spratovi s = new Spratovi();
                s.NazivSprata = "-Odaberite sprat-";
                s.SpratID = 0;
                st.Insert(0, s);

                return st;
            }
        }

        public static object getSobe()
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                List<Sobe> st = con.Sobe.ToList();
                Sobe s = new Sobe();
                s.BrojSoba = "-Odaberite sobe-";
                s.SobaID = 0;
                st.Insert(0, s);

                return st;
            }
        }

        public static object getGrijanje()
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                List<TipGrijanja> st = con.TipGrijanja.ToList();
                TipGrijanja s = new TipGrijanja();
                s.NazivGrijanja = "-Odaberite tip grijanja-";
                s.GrijanjeID = 0;
                st.Insert(0, s);

                return st;
            }
        }

        public static void insert(Nekretnine n)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {

                con.esp_Nekretnine_Insert(n.VrstaID, n.KategorijaID, n.KantonID, n.SobeID, n.SpratID, n.GrijanjeID, n.StanjeID,
                    n.KorisnikID, n.Naslov, n.BrojKvadrata, n.Adresa, n.Cijena, n.GodinaIzgradnje, n.Voda, n.Struja, n.Knalizacija,
                    n.Uknjiženo, n.Parking, n.Lift, n.Namješten, n.Internet, n.Novogradnja, n.NedavnoAdaptiran, n.Garaža, n.Telefon, n.SlikaThumb);

                //con.Nekretnine.Add(n);
                //con.SaveChanges();
            }

        }

        public static int  nekretninaIDD(int i)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
                return con.esp_IDNEKT(i).FirstOrDefault().Value;
        }

        public static void updateStatus(int i)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
                 con.esp_Nekretnina_UpdateStatus(i);
        }

        public static object nekretnineAll()
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Nekretnine_All().OrderBy(x=>x.DatumObjave).ToList();
            }
        }

        public static object getPretraga(int p1, int p2, bool p3)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Nekretnine_PretragaAdmin(p1, p2, p3).ToList();
            }
        }

        public static Nekretnine SelectById(int nekretninaID)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return (from n in con.Nekretnine
                        where n.NekretninaID == nekretninaID
                        select n).FirstOrDefault();
            }
        }

        public static object getZadnjeDodane()
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Nekretnine_SelectZadnjeDodane().ToList();
            }
        }

        public static object getKantone()
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                List<Kantoni> st = con.Kantoni.ToList();
                Kantoni s = new Kantoni();
                s.Naziv = "-Odaberite-";
                s.KantonID = 0;
                st.Insert(0, s);

                return st;
            }
        }

        public static Kantoni getKantoniByID(int ID)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return (from k in con.Kantoni
                        where k.KantonID == ID
                        select k).FirstOrDefault();
            }
        }

        public static object getGradove(int p)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return (from g in con.Gradovi
                        where g.KantonID == p
                        select g).ToList();
            }
        }

        public static object getProdaja( int kantonID, int kategorijaID, int stanejDI, double cijenaOD,double cijenaDO)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Nekretnine_SelectProdajaPage(kategorijaID, kantonID,  stanejDI, cijenaOD, cijenaDO).ToList();
            }
        }

        public static object getPotraznja( int kantonID, int kategorijaID, int stanejDI, double cijenaOD, double cijenaDO)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Nekretnine_SelectProdajaNEW(kategorijaID, kantonID, stanejDI, cijenaOD, cijenaDO).ToList();
            }
        }

        public static object getZadnjeDodaneProdaja()
        {
          
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Nekretnine_SelectZadnjeDodaneProdaja().ToList();
            }
        }

        public static object getZadnjeDodaneIzanjmljivanje()
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Nekretnine_SelectZadnjeDodaneIznajmljivanje().ToList();
            }
        }

        public static object getIznajmljivanje( int kantonID, int kategorijaID, int stanejDI, double cijenaOD, double cijenaDO)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Nekretnine_SelectIznajmljivanjePage(kategorijaID, kantonID,  stanejDI, cijenaOD, cijenaDO).ToList();
            }
        }

        public static SlikeNekretnina SelectSlika(int slikaID)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return (from s in con.SlikeNekretnina
                        where s.SlikaID == slikaID
                        select s).FirstOrDefault();
            }
        }

        public static Nekretnine getByID(int p)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return (from n in con.Nekretnine
                        where n.NekretninaID == p
                        select n).FirstOrDefault();
            }
        }

        public static List<SlikeNekretnina> getSlike(int p)
        {

            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return (from s in con.SlikeNekretnina
                        where s.NekretninaID == p
                        select s).ToList();
            }
        }

        public static Ocjene provjeriOcjenjene(int logirani, int nekretninaID)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Ocjene_Provjeri(logirani, nekretninaID).FirstOrDefault();
            }
        }

        public static void inesrtOcjena(Ocjene oc)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                con.Ocjene.Add(oc);
                con.SaveChanges();
            }
        }

        public static Kategorije getKategorijeByID(int katID)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return (from k in con.Kategorije
                        where k.KategorijaID == katID
                        select k).FirstOrDefault();
            }
        }

        public static int insertID(Nekretnine n)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
               int id= (int)con.esp_Nekretnine_Insert(n.VrstaID, n.KategorijaID, n.KantonID, n.SobeID, n.SpratID, n.GrijanjeID,
                    n.StanjeID, n.KorisnikID, n.Naslov, n.BrojKvadrata, n.Adresa, n.Cijena, n.GodinaIzgradnje, n.Voda, n.Struja,
                    n.Knalizacija, n.Uknjiženo, n.Parking, n.Lift, n.Namješten, n.Internet, n.Novogradnja, n.NedavnoAdaptiran, n.Garaža, n.Telefon, n.SlikaThumb).FirstOrDefault();

               return id;
            }
        }

        public static void insertSlika(SlikeNekretnina s)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                con.SlikeNekretnina.Add(s);
                con.SaveChanges();
            }
        }

        public static void updateBrojPosjeta(int brojPosjeta,int id)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                con.esp_Nekretnine_UpdateBrojPosjeta(brojPosjeta, id);
            }
        }

        public static object getObjavljene(int p)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Nekretnine_SelectByKupac(p).ToList();
            }
        }

        public static object getTOP3()
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Nekretnine_TOP3().ToList();
            }
        }



        public static void PotraznjaInsert(int kid, int gid)
        { 
            using(ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {

                 con.esp_PotraznjaInsert(kid, gid);
            }
        }

        public static List<Nekretnine> PotraznjaSelect(int gid)
        {
            using(ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {

                return con.esp_PotraznjaSelectAll(gid).ToList();
            }

        }
        public static List<string> PotraznjaKorisniciEmail(int g)
        {

            using(ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {

                return con.esp_PotraznjaKorisniciEmail(g).ToList();
            }
        }

        public static List<esp_IzlaziByDatum_Result1> SelectProdajaByDatum(DateTime datumOd, DateTime datumDo)
        {
            using(ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_IzlaziByDatum(datumOd, datumDo).ToList();
            }

        }
        public static List<esp_Izlazi_SelAll_Result> SelectAllIzlazi()
        {

            //Evo ato ti je pucalo, vracao si izlaze a trebao si ovaj complex pe
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Izlazi_SelAll().ToList(); 

                //jebem mu visaul :D
            }
        }
        public static esp_Izlazi_Ugovor1_Result SelectIzlazUgovorByID(int izID)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Izlazi_Ugovor1(izID).FirstOrDefault();
            }
        }
        public static void ZakljuciIzlaz(int izID)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                 con.esp_Izlazi_Zakljuci(izID);
            }

        }
        public static void InsertPitanje(int nekID, string pitanje)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                con.esp_Pitanja_InsertPitanje(nekID, pitanje);
            }

        }
        public static List<JavnaPitanja> GetPitanjaByNekretninaID(int nekID)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Pitanja_SelectAll(nekID).ToList();
            }

        }

        public static List<esp_Pitanja_SelectNeodgovorenaByKorID_Result1> getNeodgPitanjaByKorID(int korID)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {

                return con.esp_Pitanja_SelectNeodgovorenaByKorID(korID).ToList();
            }
        }
        public static void InsertOdgovor(int pitanjeID, string odg)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                con.esp_Pitanja_InsertOdgovor(pitanjeID, odg);
            }
        }
    }
}
