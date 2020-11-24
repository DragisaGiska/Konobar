using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._4._2014.kafic
{
    class Pica
    {
        private string naziv;
        private float cijena;

        public string Naziv
        {
            get { return this.naziv; }
        }
        public float Cijena
        {
            get { return this.cijena; }
        }

        public Pica(string naziv, float cijena)
        {
            this.naziv = naziv;
            this.cijena = cijena;
        }

        public override string ToString()
        {
            return String.Format("{0,-21}|{1,6}KM|",this.naziv,this.cijena);
        }
    }
}
