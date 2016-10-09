using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemNekretnine.DB
{
    public class DAKorisnici
    {
        public static Korisnici SelectByKorisnickoIme(string p1, string p2)
        {
            using(ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                Korisnici k = con.esp_Korisnici_SelectByKorisnickoIme(p1).FirstOrDefault();

                if (k != null)
                {
                    if (Util.UIHelper.GenerateHash(p2, k.LozinkaSalt) == k.LozinkaHash)
                    {
                        k.KorisniciUloge = con.esp_KorisniciUloge_SelectByKorisnik(k.KorisnikID).ToList();
                        return k;
                    }
                }

                return null;
            }
        }

        public static void insertUloge(Uloge item, Korisnici korisnici)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                con.esp_KorisniciUloge_Insert(korisnici.KorisnikID, item.UlogaID);

            }
        }

        public static void Insert(Korisnici k)
        {

            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                con.Korisnici.Add(k);
                con.SaveChanges();
            }
        }

        public static List<Uloge> Uloge_Select()
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Uloge_SelectAll().ToList();
            }
        }

        public static List<KorisniciUloge> getUlogeByKorisnikID(int p)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return (from ku in con.KorisniciUloge
                        where ku.KorisnikID == p
                        select ku).ToList();
            }
        }

        public static object SelectByName(string p)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Korisnici_SelectByName(p).ToList();
            }
        }

        public static void UpdateStatus(int p1, bool p2)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                con.esp_Korisnici_UpdateStatus(p1, p2);
            }
        }

        public static Korisnici SelectById(int kid)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return (from k in con.Korisnici
                        where k.KorisnikID == kid
                        select k).FirstOrDefault();
            }
        }

        public static void UpdateLicniPodaci(Korisnici k)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                if (k != null)
                    con.esp_Korisnici_Update(k.KorisnikID, k.Ime, k.Prezime, k.Email, k.Telefon);
            }
        }

        public static ICollection<KorisniciUloge> Uloge_SelectByKorisnikID(int p)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_KorisniciUloge_SelectByKorisnik(p).ToList();
            }
        }

        public static void ResetPassword(Korisnici k)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                con.esp_Korisnici_ResetPass(k.KorisnikID, k.LozinkaSalt, k.LozinkaHash);
            }
        }

        public static void UpdateUloge(int p, List<Uloge> list)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                con.esp_DeleteKorisniciUloge(p);
                foreach (Uloge u in list)
                {
                    con.esp_KorisniciUloge_Insert(p, u.UlogaID);
                }
            }
        }

        public static List<Uloge> UlogeTEMP_SelectByKorisnikID(int p)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
               return con.esp_KorisniciUlogeTEMP_SelectByKorisnik(p).ToList();
            }
        }
    }
}
