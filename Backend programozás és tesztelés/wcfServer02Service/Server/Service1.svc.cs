using Server.Controllers;
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

        public string FelhasznaloHozzaAd_Web(Felhasznalo record)
        {
            return FelhasznaloInsert(record);
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

        #region JogosultsagServices
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
    }
}
