using Server.DTOs;
using Server.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using Server.DTOs;

namespace Server.IServices
{
    [ServiceContract]
    public interface IJogosultsagokServiceWEB
    {
        //create, read, delete, update
        [OperationContract]
        [   
            WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "/Jogosultsagok")
            ]
        List<Jogosultsag> GetJogosultsagokWEB();
        [OperationContract]
        [
            WebInvoke(Method = "PUT",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "/Jogosultsagok")
            ]
        string JogosultsagokUpdateWEB(Jogosultsag jogosultsag);
        [OperationContract]
        [
            WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "/Jogosultsagok")
            ]
        string JogosultsagokInsertWEB(Jogosultsag jogosultsag);
        [OperationContract]
        [
            WebInvoke(Method = "DELETE",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "/Jogosultsagokdelete?id={id}")
            ]
        string JogosultsagokDeleteWEB(int id);

        [WebInvoke(Method = "GET")]
        [OperationContract]
        List<JogosultsagNevLeiras> JogosultsagNevLeiras();

        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest, UriTemplate = "/JogosultsagNevLeirasWEB")]
        [OperationContract]
        List<Jogosultsag> JogosultsagNevLeirasWEB();
    }
}
