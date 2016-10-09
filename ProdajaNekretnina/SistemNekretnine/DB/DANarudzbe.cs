using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemNekretnine.DB;

namespace SistemNekretnine.DB
{
    public class DANarudzbe
    {
        public static int Insert(Narudzbe narudzba)
        {
            using(ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
               int id = (int)con.esp_Narudzbe_Insert(narudzba.BrojNarudzbe, narudzba.KupacID).FirstOrDefault();

               return id;
            }
        }

        public static void Insert_Stavke(NarudzbaStavke n, int id)
        {

            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                con.esp_NarudzbaStavke_Insert(id, n.NekretninaID, n.Kolicina);
            }
        }

        public static object getAll()
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Narudzbe_SelectAll().ToList();
            }
        }
        public static object getAllByDate(DateTime date)
        {
             using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Narudzba_GetByDate(date).ToList();
            }

        }

        public static int InsertStavke(Izlazi iz)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                int id = (int)con.esp_Narudzba_Insert(Convert.ToInt32(iz.BrojRacuna), iz.IznosBezPDV, iz.IznosSaPDV, iz.KorisnikID, iz.NarudzbaID).FirstOrDefault();

                return id;
            }
        }
        public static void InsertIzlazStavka(IzlazStavke stav){
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                con.esp_Narudzba_Insert_Izlaz_Stavka(stav.IzlazID, stav.NekretninaID, stav.Kolicina, stav.Cijena, stav.Popust);

                
            }
        
        }
        public static void updateStatus(int id)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                con.esp_Narudzba_UpdateStatus(id, false);
            }
        }

    }
}
