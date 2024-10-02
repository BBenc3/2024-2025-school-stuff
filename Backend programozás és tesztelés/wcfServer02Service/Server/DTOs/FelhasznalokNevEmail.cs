using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Server.Controllers;
using Server.Modells;


namespace Server.DTOs
{
    public class FelhasznalokNevEmail
    {
        public string Nev { get; set; }
        public string Email { get; set; }

        private FelhasznalokNevEmail(string nev, string email)
        {
            Nev = nev;
            Email = email;
        }

        public FelhasznalokNevEmail(){}

        public List<FelhasznalokNevEmail> FelhasznalokNevEmailLista()
        {
            List<FelhasznalokNevEmail> list = new List<FelhasznalokNevEmail>();
            List<Record> felhasznalok = new FelhasznaloController().SELECT();
            foreach (Felhasznalo felhasznalo in felhasznalok)
            {
                list.Add(new FelhasznalokNevEmail(felhasznalo.Name, felhasznalo.Email));
            }

            return list;
        }
    }
}