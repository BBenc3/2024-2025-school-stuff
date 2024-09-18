using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Server.Modells
{
    [DataContract]
    public class Jogosultsag : Record
    {
        [DataMember]
        public string Nev { get; set; }
        [DataMember]
        public byte Szint { get; set; }
        [DataMember]
        public string Leiras { get; set; }
    }
}