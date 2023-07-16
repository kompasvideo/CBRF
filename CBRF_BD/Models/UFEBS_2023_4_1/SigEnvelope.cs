using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CBRF_DB.Models.UFEBS_2023_4_1
{
    sealed public class SigEnvelope
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string SigContainer { get; set; }
        public byte[] Object { get; set; }
    }
}
