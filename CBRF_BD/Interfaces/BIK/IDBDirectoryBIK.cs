using CBRF_DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBRF_DB.Interfaces
{
    public interface IDBDirectoryBIK
    {
        void Save(ED807 loadData);
        List<BICDirectoryEntry> Load();
    }
}
