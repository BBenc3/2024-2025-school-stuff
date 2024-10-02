using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes_Allat
{
    class Allat
    {
        private int eves { get; set; }
        protected Allat(int eves)
        {
            this.eves = eves;
        }
    }
    class Emlős : Allat
    {
        private bool szarzfoldi { get; set; }
        public Emlős(bool szarazfoldi, int eves) : base(eves)
        {
            this.szarzfoldi = szarazfoldi;
        }
        public string szarazfoldi()
        {
            return szarzfoldi ? "Szarazdoldi" : "Nem szarazfoldi";
        }
    }

    class Hal : Allat
    {
        private double uszasisebesseg { get; set; }
        public Hal(double uszasisebesseg, int eves) : base(eves)
        {
            this.uszasisebesseg = uszasisebesseg;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }
}
