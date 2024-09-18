using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Server.Modells
{
    [DataContract]
    public class Felhasznalo : Record
    {
        [DataMember]
        public string LoginName { get; set; }
        [DataMember]
        public string HASH { get; set; }
        [DataMember]
        public string SALT { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int JogID { get; set; }
        [DataMember]
        public bool AktivE { get ; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string PorfileKep { get; set; }
    }
}