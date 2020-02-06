using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMVC.Models
{
    public class SellerRepositiry : ISeller
    {
        private List<Seller> slist;
        public SellerRepositiry()
        {
            slist = new List<Seller>(){ new Seller(1,"A","123","CTS","YES","NoTHing","Chennai","cts.com","cts@gmail.com",7989209071),
            new Seller(2,"E","213","CTS","YES","NoTHing","Chennai","cts.com","cts@gmail.com",7989071),
            new Seller(3,"Q","321","CTS","YES","NoTHing","Chennai","cts.com","cts@gmail.com",7989209)};
        }
        public Seller GetSeller(int id)
        {
            Seller s = slist.FirstOrDefault(e => e.sid == id);
            return s;
        }

    }
}