using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmartMvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmartMvc.Controllers
{
    public class BuyerController : Controller
    {
        public readonly BuyerContext _context;
       // private object e;

        public BuyerController(BuyerContext context)

        {
            this._context = context;
        }
        // GET: Buyer
        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(Buyer b)
        {
            try
            {
                _context.Add(b);
                _context.SaveChanges();
                ViewBag.message = b.B_username + "has got successfully Registered";
                return RedirectToAction("Login");
            }
            catch (Exception e)
            {
                ViewBag.message = b.B_username + " Registeration Failed";

                return View();
            }
            
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Buyer b)
        {
            var logUser = _context.Buyers.Where(e => e.B_username == b.B_username&& e.B_password == b.B_password);
            if (logUser == null)
            {
                ViewBag.message = "Not Valid";


                return View();
            }
            else
            {
              //  HttpContext.Session.SetString("UName", b.B_username);

                return View();
            }
            
        }
         public ActionResult Index()
        {
            return View();
        }

        // GET: Buyer/Details/5h8']i
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Buyer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Buyer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
           
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Buyer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Buyer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Buyer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Buyer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}