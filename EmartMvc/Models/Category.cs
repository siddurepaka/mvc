using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMvc.Models
{
    public class Category
    {
        [Key]
        public int C_id { get; set; }
        public string C_name { get; set; }
        public string C_details { get; set; }
    }
}
