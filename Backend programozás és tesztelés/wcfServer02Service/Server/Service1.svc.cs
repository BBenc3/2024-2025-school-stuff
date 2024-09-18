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
        public List<Felhasznalo> FelhasznalokLista_CS()
        {
            List<Felhasznalo> list = new List<Felhasznalo>();
            List<Record> records = new FelhasznaloController().SELECT();
            foreach (Record record in records)
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
    }
}
