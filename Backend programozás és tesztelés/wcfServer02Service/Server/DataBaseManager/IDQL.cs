using Server.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DataBaseManager
{
    internal interface IDQL
    {
        List<Record> SELECT();
    }
}
