using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BankCard
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        BankCard GetBankCard();


        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public partial class BankCard
    {
        [DataMember]
        public uint Id { get; set; }
        [DataMember]
        public string Nev { get; set; }
        [DataMember]
        public decimal KartyaSzam { get; set; }
        [DataMember]
        public string Lejarat { get; set; }
        [DataMember]
        public string Kibocsato { get; set; }
        [DataMember]
        public int BiztonsagiKod { get; set; }

    }
}
