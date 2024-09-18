using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Server.Modells
{
    [DataContract]
    public class Record
    {
        [DataMember]
        public int ID { get; set; }
    }
}