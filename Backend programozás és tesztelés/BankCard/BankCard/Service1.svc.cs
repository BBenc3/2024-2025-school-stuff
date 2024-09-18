using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BankCard
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public BankCard GetBankCard()
        {
            BankCard bankCard = new BankCard();
            bankCard.Id = 1;
            bankCard.Nev = "Kartya Tulaj";
            bankCard.KartyaSzam = 1234123412341234;
            bankCard.Lejarat = "06/24";
            bankCard.Kibocsato = "OTP";
            bankCard.BiztonsagiKod = 987;
            return bankCard;
        }


    }
}
