using CBRF_DB.Models.UFEBS_2023_4_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBRF.Interfaces.UFEBS_2023_4_1
{
    public interface ICbrDsigEnvV110
    {
        bool LoadXmlAndSaveToDB();
        List<SigEnvelope> ViewSigEnvelopeInDb();
    }
}
