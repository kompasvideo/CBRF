using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBRF_DB.Models
{
    sealed public class BICDirectoryEntry
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BIC { get; set; }
        public List<ParticipantInfo> ParticipantInfoF { get; set; }
        public List<SWBICS> SWBICS { get; set; }
        public List<Accounts> Accounts { get; set; }

    }
}
