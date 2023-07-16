using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBRF.Interfaces
{
    public interface IXmlFile
    {
        bool VlidationXml(string pathXsd, string lUrnSchema, string pathXml);
        ED807 OpenXml(string pathXml);
        SigEnvelopeType OpenXml2(string pathXml);
    }
}
