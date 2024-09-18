using Server.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DataBaseManager
{
    internal interface IDML
    {
        string INSERT(Record record);
        string UPDATE (Record record);
        string DELETE(int ID);
    }
}
