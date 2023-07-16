using CBRF.Interfaces;
using CBRF_DB.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Xml;

namespace CBRF.Services
{
    public class XmlFile :IXmlFile
    {
        public bool VlidationXml(string pathXsd, string lUrnSchema, string pathXml)
        {
            bool result = true;
            XmlSchemaSet schema = new XmlSchemaSet();
            schema.Add(lUrnSchema, pathXsd);
            XmlReader rd = XmlReader.Create(pathXml);
            XDocument doc = XDocument.Load(rd);
            rd.Close();
            try
            {
                doc.Validate(schema, ValidationEventHandler);

            }
            catch (Exception)
            {
                result = false;
                MessageBox.Show("Error validation xml file");
            }
            return result;

            void ValidationEventHandler(object sender, ValidationEventArgs e)
            {
                XmlSeverityType type = XmlSeverityType.Warning;
                if (Enum.TryParse<XmlSeverityType>("Error", out type))
                {
                    if (type == XmlSeverityType.Error) throw new Exception(e.Message);
                }
            }
        }
        public ED807 OpenXml(string pathXml)
        {
            ED807 loadData = null;
            try
            {
                using (FileStream fs = new FileStream(pathXml, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(ED807));
                    loadData = xmlSerializer.Deserialize(fs) as ED807;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error deserialize xml file");
            }
            return loadData;
        }

        public SigEnvelopeType OpenXml2(string pathXml)
        {
            SigEnvelopeType loadData = null;
            try
            {
                using (FileStream fs = new FileStream(pathXml, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(SigEnvelopeType));
                    loadData = xmlSerializer.Deserialize(fs) as SigEnvelopeType;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error deserialize xml file");
            }
            return loadData;
        }

    }
}
