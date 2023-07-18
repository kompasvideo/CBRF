using CBRF_DB.Interfaces;
using CBRF_DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CBRF_DB.Services
{
    public class DBDirectoryBIK : IDBDirectoryBIK
    {
        public void Save(ED807 loadData)
        {
            using (BIKApplicationContext db = new BIKApplicationContext())
            {
                // пересоздадим базу данных
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                var path = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
                path += "\\" + Properties.Resources.StringDb;
                foreach (var item in loadData.BICDirectoryEntry)
                {
                    BICDirectoryEntry bICDirectoryEntry = new BICDirectoryEntry
                    {
                        BIC = int.Parse(item.BIC)
                    };
                    if (item.ParticipantInfo != null && item.ParticipantInfo.Length > 0)
                    {
                        foreach (var item2 in item.ParticipantInfo)
                        {
                            if (item2 != null)
                            {
                                bICDirectoryEntry.ParticipantInfoF = new List<ParticipantInfo>();
                                ParticipantInfo ParticipantInfoF = new ParticipantInfo();
                                ParticipantInfoF.NameP = item2.NameP;
                                ParticipantInfoF.CntrCd = item2.CntrCd;
                                ParticipantInfoF.Rgn = item2.Rgn;
                                ParticipantInfoF.Ind = item2.Ind;
                                ParticipantInfoF.Tnp = item2.Tnp;
                                ParticipantInfoF.Nnp = item2.Nnp;
                                ParticipantInfoF.Adr = item2.Adr;
                                ParticipantInfoF.DateIn = item2.DateIn;
                                ParticipantInfoF.PtType = item2.PtType;
                                ParticipantInfoF.Srvcs = item2.Srvcs;
                                ParticipantInfoF.XchType = item2.XchType;
                                ParticipantInfoF.UID = item2.UID;
                                ParticipantInfoF.ParticipantStatus = item2.ParticipantStatus;
                                ParticipantInfoF.PrntBIC = item2.PrntBIC;
                                ParticipantInfoF.RegN = item2.RegN;
                                ParticipantInfoF.EnglName = item2.EnglName;
                                if (item2.RstrList != null)
                                {
                                    if (item2.RstrList.Length > 0)
                                    {
                                        foreach (var item3 in item2.RstrList)
                                        {
                                            ParticipantInfoF.RstrList = new List<RstrList>();
                                            RstrList rstrList = new RstrList();
                                            rstrList.Rstr = item3.Rstr;
                                            rstrList.RstrDate = item3.RstrDate;
                                            db.FRstrList.Add(rstrList);
                                            ParticipantInfoF.RstrList.Add(rstrList);
                                        }
                                    }
                                }
                                else ParticipantInfoF.RstrList = null;
                                bICDirectoryEntry.ParticipantInfoF.Add(ParticipantInfoF); 
                                db.FParticipantInfo.Add(ParticipantInfoF);

                            }
                         }
                     }
                    else
                    {
                        bICDirectoryEntry.ParticipantInfoF = null;
                    }
                    if (item.SWBICS != null && item.SWBICS.Length > 0)
                    {
                        foreach(var item4 in item.SWBICS)
                        {
                            if (item4 != null)
                            {
                                bICDirectoryEntry.SWBICS = new List<SWBICS>();
                                SWBICS sWBICS = new SWBICS();
                                sWBICS.SWBIC = item4.SWBIC;
                                sWBICS.DefaultSWBIC = item4.DefaultSWBIC;
                                db.FSWBICS.Add(sWBICS);
                                bICDirectoryEntry.SWBICS.Add(sWBICS);
                            }
                        }
                    }
                    else
                    {
                        bICDirectoryEntry.SWBICS = null;
                    }
                    if(item.Accounts != null && item.Accounts.Length > 0)
                    { 
                        foreach (var account in item.Accounts) 
                        {
                            bICDirectoryEntry.Accounts = new List<Accounts>();
                            Accounts sAccounts = new Accounts();
                            sAccounts.Account = account.Account;
                            sAccounts.RegulationAccountType = account.RegulationAccountType;
                            sAccounts.CK = account.CK;
                            sAccounts.AccountCBRBIC = account.AccountCBRBIC;
                            sAccounts.DateIn = account.DateIn;
                            sAccounts.AccountStatus = account.AccountStatus;
                            sAccounts.DateOut = account.DateOut;
                            if (account.AccRstrList != null && account.AccRstrList.Length > 0) 
                            { 
                                foreach(var acc in account.AccRstrList)
                                {
                                    sAccounts.AccRstr = new List<AccRstrList>();
                                    AccRstrList accRstr = new AccRstrList();
                                    accRstr.AccRstr = acc.AccRstr;
                                    accRstr.AccRstrDate = acc.AccRstrDate;
                                    db.FAccRstrList.Add(accRstr);
                                    sAccounts.AccRstr.Add(accRstr);
                                }
                            }
                            bICDirectoryEntry.Accounts.Add(sAccounts);
                            db.FAccounts.Add(sAccounts);
                        }
                    }
                    db.FBICDirectoryEntry.Add(bICDirectoryEntry);
                }
                db.SaveChanges();
            }

        }

        public List<BICDirectoryEntry> Load()
        {
            List<BICDirectoryEntry> entries = null;
            using (BIKApplicationContext db = new BIKApplicationContext())
            {
                try
                {
                    db.FAccRstrList.Load();
                    db.FAccounts.Load();
                    db.FRstrList.Load();
                    db.FSWBICS.Load();
                    db.FParticipantInfo.Load();
                    db.FBICDirectoryEntry.Load();
                    entries = db.FBICDirectoryEntry.ToList();
                }
                catch(Exception) { }
            }
            return entries;
        }
    }
}
