﻿using CBRF.Infrastructure;
using CBRF.Interfaces;
using CBRF.Interfaces.UFEBS_2023_4_1;
using CBRF_DB.Interfaces.UFEBS_2023_4_1;
using CBRF_DB.Models.UFEBS_2023_4_1;
using CBRF_DB.Services;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBRF.Services.UFEBS_2023_4_1
{
    public class CbrDsigEnvV110 : ICbrDsigEnvV110
    {
        private const string urnSchema = "urn:cbr-ru:dsig:env:v1.1";
        private const string xsdName = @"\XSD\UFEBS_2023_4_1\cbr_dsig_env_v1.1.0.xsd";
        private readonly IXmlFile xmlFile;
        private readonly IDBCbrDsigEnvV110 iDBCbrDsigEnvV110;

        public CbrDsigEnvV110(IXmlFile xmlFile, IDBCbrDsigEnvV110 iDBCbrDsigEnvV110)
        {
            this.xmlFile = xmlFile;
            this.iDBCbrDsigEnvV110 = iDBCbrDsigEnvV110;
        }

        public bool LoadXmlAndSaveToDB()
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
                    iDBCbrDsigEnvV110.Save(loadData);
                    return true;
                }                
            }
            return false;
        }

        public List<SigEnvelope> ViewSigEnvelopeInDb()
        {
            var item = iDBCbrDsigEnvV110.Load();
            if (item == null)
            {
                StatData.Error = true;
                StatData.ErrorMessage = "Нет БД БИК";
            }
            return item;
        }
    }
}
