using Server.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server.IServices
{
    [ServiceContract]
    public interface IJogosultsagokService
    {
        [OperationContract]
        List<Jogosultsag> GetJogosultsagok();
    }
}
