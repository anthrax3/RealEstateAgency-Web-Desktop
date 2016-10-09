//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemNekretnine.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kupci
    {
        public Kupci()
        {
            this.Narudzbe = new HashSet<Narudzbe>();
            this.Ocjene = new HashSet<Ocjene>();
            this.Nekretnine = new HashSet<Nekretnine>();
            this.Potraznja = new HashSet<Potraznja>();
        }
    
        public int KupacID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public System.DateTime DatumRegistracije { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Status { get; set; }
    
        public virtual ICollection<Narudzbe> Narudzbe { get; set; }
        public virtual ICollection<Ocjene> Ocjene { get; set; }
        public virtual ICollection<Nekretnine> Nekretnine { get; set; }
        public virtual ICollection<Potraznja> Potraznja { get; set; }
    }
}