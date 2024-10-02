using Google.Protobuf.WellKnownTypes;
using Server.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Services;
using Server.DTOs;

namespace Server.IServices
{
    [ServiceContract]
    public interface IFelhasznalokServiceWEB
    {
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest, UriTemplate = "/Felhasznalolista_WEB")]
        [OperationContract]
        List<Felhasznalo> FelhasznalokLista_WEB();

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest, UriTemplate = "/FelhasznaloHozzaAd_WEB/")]
        string FelhasznaloHozzaAd_WEB(Felhasznalo felhasznalo);

        [OperationContract]
        [WebInvoke(
        Method = "PUT",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.WrappedRequest,
        UriTemplate = "/FelhasznaloUpdate_WEB/")]
        string FelhasznaloUpdate_Web(Felhasznalo felhasznalo);

        [OperationContract]
        [WebInvoke(
        Method = "DELETE",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.WrappedRequest,
        UriTemplate = "/FelhasznaloDelete_WEB?id={ID}")]
        string FelhasznaloDelete_WEB(int ID);


        [WebInvoke(Method = "GET")]
        [OperationContract]
        List<FelhasznalokNevEmail> FelhasznalokNevEmailCS();

        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest, UriTemplate = "/FelhasznalokNevEmail")]
        [OperationContract]
        List<Felhasznalo> FelhasznalokNevEmailWEB();

    }
}
