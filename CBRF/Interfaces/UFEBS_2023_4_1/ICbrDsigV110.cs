using CBRF_DB.Models.UFEBS_2023_4_1;
using System.Collections.Generic;

namespace CBRF.Interfaces.UFEBS_2023_4_1
{
    public interface ICbrDsigV110
    {
        void LoadXmlAndSaveToDB();
        List<SigEnvelope> ViewSigEnvelopeInDb();
    }
}
