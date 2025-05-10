using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class Biljka
    {
        public int BiljkaID { get; set; }
        public string Naziv { get; set; }
        public string Vrsta { get; set; }
        public DateTime DatumZalivanja { get; set; }
        public string Opis { get; set; }

        public Biljka() { }

        public Biljka(string naziv, string vrsta, DateTime datumZalivanja, string opis)
        {
            Naziv = naziv;
            Vrsta = vrsta;
            DatumZalivanja = datumZalivanja;
            Opis = opis;
        }
    }
}
