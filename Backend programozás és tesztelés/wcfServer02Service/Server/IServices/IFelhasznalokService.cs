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
    public interface IFelhasznalokService
    {
        [WebGet]
        [OperationContract]
        List<Felhasznalo> FelhasznalokLista_CS();

        [OperationContract]
        string FelhasznaloInsert(Felhasznalo record);

        [OperationContract]
        [WebInvoke (Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat =WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest, UriTemplate="/FelhasznaloHozzaAd/")]
        string FelhasznaloHozzaAd_Web(Felhasznalo felhasznalo);
    }
}
