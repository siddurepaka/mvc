using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EmartMvc.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmartMvc.Controllers
{
    public class SellerController : Controller

    {
        public readonly SellerContext _context;
        private readonly IWebHostEnvironment hostingEnvironment;
      
        public SellerController(SellerContext context,IWebHostEnvironment hostingEnvironment)

        {
           this._context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: Seller
        [HttpGet]
        public ActionResult Registration()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Registration(Seller s)
        {
            try
            {
                _context.Add(s);
                _context.SaveChanges();
                ViewBag.message = s.S_username + "has got successfully Registered";
                return RedirectToAction("Login");
            }
            catch (Exception e)
            {
                ViewBag.message = s.S_username + " Registeration Failed";

                return View();
            }


        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Seller b)
        {
            var logUser = _context.Sellers.Where(e => e.S_username == b.S_username && e.S_password == b.S_password);
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

        // GET: Seller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Seller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Seller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SellerViewModel model)
        {


            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.
                if (model.photo != null)
                {
                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    string[] name = model.photo.FileName.Split('\\');

                    uniqueFileName = Guid.NewGuid().ToString() + "_" +name[name.Length-1];
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    // Use CopyTo() method provided by IFormFile interface to
                    // copy the file to wwwroot/images folder
                    model.photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Seller newSeller = new Seller
                {
                    S_username = model.S_username,
                   S_emailid = model.S_emailid,
                    S_comapnyname = model.S_comapnyname,
                    S_abtcompany=model.S_abtcompany,
                    S_mobilenum=model.S_mobilenum,
                    // Store the file name in PhotoPath property of the employee object
                    // which gets saved to the Employees database table
                    photopath = uniqueFileName
                };

                _context.Add(newSeller);
                _context.SaveChanges();
            }
            return View();
        }

        // GET: Seller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Seller/Edit/5
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

        // GET: Seller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Seller/Delete/5
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