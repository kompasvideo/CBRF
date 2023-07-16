using CBRF_DB.Models;
using System.Collections.Generic;

namespace CBRF.Interfaces.BIK
{
    public interface IDirectoryBIK
    {
        /// <summary>
        /// Загрузить справочник БИК в БД
        /// </summary>
        void LoadDirectoryBIKAndSaveToDB();

        /// <summary>
        /// Просмотреть справочник БИК из БД
        /// </summary>
        List<BICDirectoryEntry> ViewDirectoryBIKInDB();
    }
}
