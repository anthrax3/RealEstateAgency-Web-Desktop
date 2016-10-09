using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemNekretnine.DB;

namespace SistemNekretnine.DB
{
    public class DAKupci
    {
        public static Kupci logiranje(string p1, string p2)
        {
            using(ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                Kupci k = con.esp_Kupci_SelectByEmail(p1).FirstOrDefault();

                if (k != null)
                {
                    if (Util.UIHelper.GenerateHash(p2, k.LozinkaSalt) == k.LozinkaHash)
                        return k;
                }

                return null;
            }
        }

        public static Kupci provjeriEmail(string p)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return con.esp_Kupci_SelectByEmail(p).FirstOrDefault();
            }
        }

        public static void Insert(Kupci kup)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                con.Kupci.Add(kup);
                con.SaveChanges();
            }
        }

        public static Kupci getByID(int logirani)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                return (from k in con.Kupci
                        where k.KupacID == logirani
                        select k).FirstOrDefault();
            }
        }

        public static void update(Kupci k)
        {
            using (ProdajaNekretninaEntities con = new ProdajaNekretninaEntities())
            {
                con.esp_Kupci_Update(k.Email, k.KupacID, k.LozinkaSalt, k.LozinkaHash);
            }
        }
    }
}
