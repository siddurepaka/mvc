using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMVC.Models
{
    public interface ISeller
    {
        //Seller Display();
        Seller GetSeller(int id);
    }
}