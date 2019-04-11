using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak1
{
    class Knjiga
    {
        public string Naziv { get; set; }

        public Knjiga(string naziv)
        {
            Naziv = naziv;
        }
        
        public override string ToString()
        {
            return $"{Naziv}";
        }

    }
}
