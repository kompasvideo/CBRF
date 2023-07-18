using CBRF.Infrastructure;
using CBRF.Interfaces;
using CBRF.Interfaces.UFEBS_2023_4_1;
using CBRF_DB.Interfaces.UFEBS_2023_4_1;
using CBRF_DB.Models.UFEBS_2023_4_1;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;

namespace CBRF.Services.UFEBS_2023_4_1
{
    public class CbrDsigV110 : ICbrDsigV110
    {
        private const string urnSchema = "urn:cbr-ru:dsig:v1.1";
        private const string xsdName = @"\XSD\UFEBS_2023_4_1\cbr_dsig_v1.1.0.xsd";
        private readonly IXmlFile xmlFile;
        private readonly IDBCbrDsigEnvV110 iDBCbrDsigEnvV110;

        public CbrDsigV110(IXmlFile xmlFile, IDBCbrDsigEnvV110 iDBCbrDsigEnvV110)
        {
            this.xmlFile = xmlFile;
            this.iDBCbrDsigEnvV110 = iDBCbrDsigEnvV110;
        }

        public void LoadXmlAndSaveToDB()
        {
            string xmlName = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML файл (.xml)|*.xml";
            openFileDialog.DefaultExt = ".xml";
            if (openFileDialog.ShowDialog() == true)
            {
                xmlName = openFileDialog.FileName;
                var path = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
                if (xmlFile.VlidationXml(path + xsdName, urnSchema, xmlName))
                {
                    SigEnvelopeType loadData = xmlFile.OpenXml2(xmlName);
                    if (!iDBCbrDsigEnvV110.Save(loadData))
                    {
                        StatData.Error = true;
                        StatData.ErrorMessage = "Ошибка";
                    }
                }
            }
        }

        public List<SigEnvelope> ViewSigEnvelopeInDb()
        {
            return iDBCbrDsigEnvV110.Load();
        }
    }
}
