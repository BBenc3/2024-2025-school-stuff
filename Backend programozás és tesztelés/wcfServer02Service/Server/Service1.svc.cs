using Server.Controllers;
using Server.DTOs;
using Server.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Server
{
    public class Service1 : IService1
    {
        #region FelhsznaloServices
        #region General
        public List<Felhasznalo> FelhasznalokLista_CS()
        {
            List<Felhasznalo> list = new List<Felhasznalo>();
            List<Record> records = new FelhasznaloController().SELECT();
            foreach (Felhasznalo record in records)
            {
                list.Add((Felhasznalo)record);
            }

            return list;
        }
        public string FelhasznaloInsert(Felhasznalo record)
        {
            FelhasznaloController felhasznalo = new FelhasznaloController();
            return felhasznalo.INSERT(record);
        }

        public string FelhasznaloUpdate(Felhasznalo felhasznalo)
        {
            return new FelhasznaloController().UPDATE(felhasznalo);
        }

        public string FelhasznaloDelete(int ID)
        {
            return new FelhasznaloController().DELETE(ID);
        }
        #endregion
        #region WEB
        public List<Felhasznalo> FelhasznalokLista_WEB()
        {
            return FelhasznalokLista_CS();
        }
        public string FelhasznaloHozzaAd_WEB(Felhasznalo record)
        {
            return FelhasznaloInsert(record);
        }

        public string FelhasznaloUpdate_Web(Felhasznalo felhasznalo)
        {
            return FelhasznaloUpdate(felhasznalo);
        }

        public string FelhasznaloDelete_WEB(int ID)
        {
            return FelhasznaloDelete(ID);
        }
        #endregion
        #endregion

        #region JogosultsagServices
        #region General
        public List<Jogosultsag> JogosultsagokLista()
        {
            List<Jogosultsag> list = new List<Jogosultsag>();
            List<Record> records = new JogosultsagokController().SELECT();
            foreach (Jogosultsag record in records)
            {
                list.Add((Jogosultsag)record);
            }

            return list;
        }

        public string JogosultsagFrissit(Jogosultsag jogosultsag)
        {
            return new JogosultsagokController().UPDATE(jogosultsag);
        }

        public string JogosultsagokTorol(int ID)
        {
            return new JogosultsagokController().DELETE(ID);
        }

        public string JogosultsagHozzaAd(Jogosultsag jogosultsag)
        {
            return new JogosultsagokController().INSERT(jogosultsag);
        }

        public string JogosultsagTorol(int ID)
        {
            return new JogosultsagokController().DELETE(ID);
        }
        #endregion
        #region WEB
        public string JogosultsagokInsertWEB(Jogosultsag jogosultsag)
        {
            return JogosultsagHozzaAd(jogosultsag);
        }
        public string JogosultsagokDeleteWEB(int ID)
        {
            return JogosultsagokTorol(ID);
        }
        public string JogosultsagokUpdateWEB(Jogosultsag jogosultsag)
        {
            return JogosultsagFrissit(jogosultsag);
        }
        public List<Jogosultsag> GetJogosultsagokWEB()
        {
            return JogosultsagokLista();
        }

        #endregion
        #endregion

        public List<FelhasznalokNevEmail> FelhasznalokNevEmailCS()
        {
            return new FelhasznalokNevEmail().FelhasznalokNevEmailLista();
        }
        public List<Felhasznalo> FelhasznalokNevEmailWEB()
        {
            return FelhasznalokLista_CS();
        }
        public List<JogosultsagNevLeiras> JogosultsagNevLeiras()
        {
            return new JogosultsagNevLeiras().JogosultsagNevLeirasLista();
        }
        public List<Jogosultsag> JogosultsagNevLeirasWEB()
        {
            return JogosultsagokLista();
        }
    }
}

