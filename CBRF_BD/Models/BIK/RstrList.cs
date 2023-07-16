using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBRF_DB.Models
{
    public class RstrList
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Rstr { get; set; }
        //public DateTime RstrDate { get; set; }
        public string RstrDate { get; set; }
    }
}
