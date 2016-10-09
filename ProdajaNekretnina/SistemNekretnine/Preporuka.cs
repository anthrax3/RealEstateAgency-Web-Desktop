using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemNekretnine.DB;

namespace SistemNekretnine
{
    public class Preporuka
    {
        Dictionary<int, List<Ocjene>> tempUsluge = new Dictionary<int, List<Ocjene>>();

        ProdajaNekretninaEntities con = new ProdajaNekretninaEntities();
        #region Item-based preporuka

        //Funkcija koja se poziva iz web dijela aplikacije
        public List<Nekretnine> GetSlicneProizvode(int nekretninaID, int korisnikID)
        {
            UcitajProizvode(nekretninaID);

            List<Ocjene> ocjene = con.Ocjene.Where(x => x.NekretninaID == nekretninaID).OrderBy(x => x.KupacID).ToList();

            List<Ocjene> zajednickeOcjene1 = new List<Ocjene>();
            List<Ocjene> zajednickeOcjene2 = new List<Ocjene>();

            List<Nekretnine> preporuceno = new List<Nekretnine>();

            //Prva petlja - lista svih proizvoda (ne uključujući onaj koji je proslijeđen u funkciju)
            foreach (var item in tempUsluge)
            {
                foreach (Ocjene o in ocjene)  //Sve ocjene aktivnog proizvoda
                {
                    //Provjeriti da li je naredni proizvod (iz liste proizvodi) ocijenio isti kupac
                    if (item.Value.Where(x => x.KupacID == o.KupacID).Count() > 0)
                    {
                        zajednickeOcjene1.Add(o);
                        zajednickeOcjene2.Add(item.Value.Where(x => x.KupacID == o.KupacID).First());
                    }
                }

                //Za računanje sličnosti se uzimaju samo zajedničke ocjene, odnosno ocjene istih kupaca za oba proizvoda
                double slicnost = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);
                if (slicnost > 0.6) //Granična vrijednost (treshold)
                    preporuceno.Add(DANekretnine.SelectById(item.Key));

                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();
            }

            List<Ocjene> ocjenePacijenta = con.Ocjene.Where(x => x.KupacID == korisnikID).ToList();
            foreach (Ocjene oc in ocjenePacijenta)
            {
                Nekretnine idNekretnine = oc.Nekretnine;
                preporuceno.Remove(idNekretnine);
            }

            //Lista preporučenih proizvoda
            return preporuceno;
        }

        //Učitava se kolekcija proizvoda i njihovih ocjena (osim onog koji se trenutno pregleda)
        private void UcitajProizvode(int nekretninaID)
        {
            List<Nekretnine> aktivneNekretnine = con.Nekretnine.Where(x => x.NekretninaID != nekretninaID).ToList();

            List<Ocjene> ocjene = new List<Ocjene>();
            foreach (Nekretnine p in aktivneNekretnine)
            {
                ocjene = con.Ocjene.Where(x => x.NekretninaID == p.NekretninaID).OrderBy(x => x.KupacID).ToList();
                if (ocjene.Count > 0)
                    tempUsluge.Add(p.NekretninaID, ocjene);

            }
        }

        //Cosine similarity
        double GetSlicnost(List<Ocjene> ocjene1, List<Ocjene> ocjene2)
        {
            if (ocjene1.Count != ocjene2.Count)
                return 0;

            int brojnik = 0;
            double int1 = 0;
            double int2 = 0;

            for (int i = 0; i < ocjene1.Count; i++)
            {
                brojnik += (Int32)ocjene1[i].Ocjena * (Int32)ocjene2[i].Ocjena;
                int1 += (Int32)ocjene1[i].Ocjena * (Int32)ocjene1[i].Ocjena;
                int2 += (Int32)ocjene2[i].Ocjena * (Int32)ocjene2[i].Ocjena;
            }

            int1 = Math.Sqrt(int1);
            int2 = Math.Sqrt(int2);

            double nazivnik = int1 * int2;

            if (nazivnik != 0)
                return brojnik / nazivnik;

            return 0;

        }

        #endregion


    }
}
