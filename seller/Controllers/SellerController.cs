using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using seller.Models;

namespace seller.Controllers
{
    public class SellerController : Controller
    {
        SellerRepository ser = new SellerRepository();
        public string Search()
        {
            Seller se = ser.GetSeller(1);
            return se.sid + "\n" + se.sname + "\n" + se.spassword + "\n" + se.scompanyname + "\n" + se.saddress + "\n" + se.sgstin;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}