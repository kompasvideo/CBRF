using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CBRF_DB.Models
{
    sealed public class ParticipantInfo
    {
        public List<RstrList> RstrList { get; set; }
        public string NameP { get; set; }
        public string CntrCd { get; set; }
        public string Rgn { get; set; }
        public string Ind { get; set; }
        public string Tnp { get; set; }
        public string Nnp { get; set; }
        public string Adr { get; set; }
        //public DateTime DateIn { get; set; }
        public string DateIn { get; set; }
        public string PtType { get; set; }
        public string Srvcs { get; set; }
        public string XchType { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string UID { get; set; }
        public string ParticipantStatus { get; set; }
        public string PrntBIC { get; set; }
        public string RegN { get; set; }
        public string EnglName { get; set; }
    }
}
