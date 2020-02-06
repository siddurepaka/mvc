using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMvc.Models
{
    public class BuyerContext : DbContext
    {
        public BuyerContext(DbContextOptions<BuyerContext> options) : base(options)
        {

        }
        public DbSet<Buyer> Buyers { get; set; }
        public IEnumerable<object> Buyer { get; internal set; }
    }

    
}
