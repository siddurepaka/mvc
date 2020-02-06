using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMvc.Models
{
    public class Buyer
    { 
        [Key]
        public int B_id { get; set; }
        public string B_username { get; set; }
        public string B_password { get; set; }
        public string B_mobilenum { get; set; }
        public DateTime B_createdatetime{ get; set; }

    }
}
