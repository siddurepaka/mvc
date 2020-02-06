using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMvc.Models
{
    public class Seller
    {
        [Key]
        public int SID { get; set; }
        public string S_username { get; set; }
        public string S_password { get; set; }
        public string S_comapnyname { get; set;}
        public string S_gstin { get; set; }
        public string S_abtcompany { get; set; }
        public string S_postaladdress { get; set; }
        public string S_website { get; set; }
        public string S_emailid { get; set; }
        public long S_mobilenum { get; set; }
        public string photopath { get; set; }
        
    }
    }

