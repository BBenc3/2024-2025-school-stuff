using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Osztályok0930
{
    class Auto : Jarmu
    {
        public Auto(int ossztomeg, string rendszam, int szemelyekszam, int kerekszam) :base (kerekszam, "Auto")
        {
            this.ossztomeg = ossztomeg;
            this.rendszam = rendszam;
            this.szemelyekszam = szemelyekszam;
        }

        public int ossztomeg { get; set; }
        public string rendszam { get; set; }
        public int szemelyekszam { get; set; }

        public int Terhelhetoseg()
        {
            throw new NotImplementedException();
        }
    }

    class Jarmu
    {
        public Jarmu(int kerekszam, string nev)
        {
            this.kerekszam = kerekszam;
            this.nev = nev;
        }

        public int kerekszam { get; set; }
        public string nev { get; set; }

        public bool IsStabil()
        {
            return kerekszam > 2 ;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
