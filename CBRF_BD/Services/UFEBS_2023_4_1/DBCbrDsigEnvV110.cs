using CBRF_DB.Interfaces.UFEBS_2023_4_1;
using CBRF_DB.Models;
using CBRF_DB.Models.UFEBS_2023_4_1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace CBRF_DB.Services.UFEBS_2023_4_1
{
    public class DBCbrDsigEnvV110 : IDBCbrDsigEnvV110
    {
        public bool Save(SigEnvelopeType loadData)
        {
            using (CbrDsigEnvV10ApplicationContext db = new CbrDsigEnvV10ApplicationContext())
            {
                // пересоздадим базу данных
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                var path = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
                path += "\\" + Properties.Resources.StringDb;
                try
                {
                    SigEnvelope sigEnvelope = new SigEnvelope
                    {
                        SigContainer = loadData.SigContainer.ToString(),
                        Object = loadData.Object,
                    };
                    db.FSigEnvelope.Add(sigEnvelope);
                    db.SaveChanges();
                }
                catch (Exception ex) 
                { 
                    return false;
                }
            }
            return true;
        }

        public List<SigEnvelope> Load()
        {
            List<SigEnvelope> entries = null;
            using (CbrDsigEnvV10ApplicationContext db = new CbrDsigEnvV10ApplicationContext())
            {
                try
                {
                    db.FSigEnvelope.Load();
                    entries = db.FSigEnvelope.ToList();
                }
                catch (Exception) 
                {
                }
            }
            return entries;
        }
    }
}
