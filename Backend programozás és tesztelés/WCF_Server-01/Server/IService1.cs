using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Allat GetAnimal();

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Record
    {
        [DataMember]
        public int? Id { get; set; }

    }
    public class Allat : Record
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public byte? age { get; set; }
        [DataMember]
        public bool? gender { get; set; }
        [DataMember]
        public double? weight { get; set; }
        [DataMember]
        public char? @class { get; set; }

    }
}
