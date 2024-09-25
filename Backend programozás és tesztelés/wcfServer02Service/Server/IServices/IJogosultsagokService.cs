using Server.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Server.IServices
{
    [ServiceContract]
    public interface IJogosultsagokService
    {
        [OperationContract]
        [WebGet]
        List<Jogosultsag> JogosultsagokLista();
        [OperationContract]
        [WebInvoke(Method = "POST")]
        string JogosultsagHozzaAd(Jogosultsag jogosultsag);
        [OperationContract]
        [WebInvoke(Method = "PUT")]
        string JogosultsagFrissit(Jogosultsag jogosultsag);
        [OperationContract]
        [WebInvoke(Method = "DELETE")]
        string JogosultsagTorol(int ID);
    }
}
