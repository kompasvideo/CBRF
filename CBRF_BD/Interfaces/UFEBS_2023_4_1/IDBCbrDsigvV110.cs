using CBRF_DB.Models;
using CBRF_DB.Models.UFEBS_2023_4_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBRF_DB.Interfaces.UFEBS_2023_4_1
{
    public interface IDBCbrDsigV110
    {
        void Save(SigEnvelopeType loadData);
        List<SigEnvelope> Load();
    }
}
