using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMvc.Models
{
    public class Item
    {
        [Key]
        public int I_id { get; set; }
        public int C_id { get; set; }
        public int SC_id { get; set; }
        public double I_price { get; set; }
        public string I_des { get; set; }
        public int I_stocknum{ get; set; }
        public string I_remarks{ get; set; }
    }
}
