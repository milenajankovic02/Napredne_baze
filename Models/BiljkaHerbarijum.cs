using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Models
{
    public class BiljkaHerbarijum
    {
        public int BiljkaHerbarijumID { get; set; }
        public int BiljkaID { get; set; }
        public Biljka Biljka { get; set; }
        public int HerbarijumID { get; set; }
        public Herbarijum Herbarijum { get; set; }
        public DateTime DatumSmještanja { get; set; }
    }
}
