using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemNekretnine.DB;
using System.Resources;
using System.Reflection;

namespace Administracija
{
    public class Global
    {
        //Pristup sistemu
        public static SistemNekretnine.DB.Korisnici prijavljeniKorisnik { get; set; }

        //Učitavanje poruke na osnovu ključa
        public static string GetString(string key)
        {
            ResourceManager rm = new ResourceManager("Administracija.Poruke", Assembly.GetExecutingAssembly());
            return rm.GetString(key);
        }
    }
}
