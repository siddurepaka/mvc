using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMvc.Models
{
    public class SubCategory
    {
        [Key]
        public int SC_id { get; set; }
        public string SC_name { get; set; }
    }
}