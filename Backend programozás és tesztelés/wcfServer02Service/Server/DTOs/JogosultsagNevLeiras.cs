using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Server.Controllers;
using Server.Modells;

namespace Server.DTOs
{
    public class JogosultsagNevLeiras
    {
        public string Nev { get; set; }
        public string Leiras { get; set; }

        private JogosultsagNevLeiras(string nev, string leiras)
        {
            Nev = nev;
            Leiras = leiras;
        }

        public JogosultsagNevLeiras() { }

        public List<JogosultsagNevLeiras> JogosultsagNevLeirasLista()
        {
            List<JogosultsagNevLeiras> list = new List<JogosultsagNevLeiras>();
            List<Record> jogosultsagok = new JogosultsagokController().SELECT();
            foreach (Jogosultsag jogosultsag in jogosultsagok)
            {
                list.Add(new JogosultsagNevLeiras(jogosultsag.Nev, jogosultsag.Leiras));
            }

            return list;
        }
    }
}