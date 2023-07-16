using CBRF.Interfaces.BIK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Windows;
using CBRF_DB.Interfaces;
using CBRF_DB.Models;
using CBRF.Interfaces;

namespace CBRF.Services.BIK
{
    public class DirectoryBIK : IDirectoryBIK
    {
        private readonly IDBDirectoryBIK dBDirectoryBIK;
        private const string urnSchema = "urn:cbr-ru:ed:v2.0";
        private const string xsdName = @"\XSD\BIK\20230714_ED807_full.xsd";
        private const string xmlName = @"\XML\BIK\20230714_ED807_full.xml";
        private readonly IXmlFile xmlFile;
        public DirectoryBIK(IDBDirectoryBIK dBDirectoryBIK, IXmlFile xmlFile)
        {
            this.dBDirectoryBIK = dBDirectoryBIK;
            this.xmlFile = xmlFile;
        }

        /// <summary>
        /// Загрузить справочник БИК в БД
        /// </summary>
        public void LoadDirectoryBIKAndSaveToDB()
        {
            var path = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
            if(xmlFile.VlidationXml(path + xsdName, urnSchema, path + xmlName))
            {
                ED807 loadData = xmlFile.OpenXml(path + xmlName);
                dBDirectoryBIK.Save(loadData);
            }
        }
        
        /// <summary>
        /// Просмотреть справочник БИК из БД
        /// </summary>
        public List<BICDirectoryEntry> ViewDirectoryBIKInDB()
        {
            return dBDirectoryBIK.Load();
        }
    }    
}
