using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class Herbarijum
    {
        public int HerbarijumID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public DateTime DatumOsnivanja { get; set; }
    }
}
