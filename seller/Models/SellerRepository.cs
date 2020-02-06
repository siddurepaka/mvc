using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace seller.Models
{
    
        public class SellerRepository : Interface
        {
            private List<Seller> sList;
            public SellerRepository()
            {
                 sList = new List<Seller>() { new Seller(1, "Ajay", "123", "Cts", "12345", "abc", "chennai", "qwer", "qw@gmail.com", 1234656) };
            }
        public Seller GetSeller(int id)
        {
            Seller el = sList.FirstOrDefault(e => e.sid == id);
            return el;
        }

    }
}
