using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HtmlHelpers.Models;
using HtmlHelpers.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HtmlHelpers.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Country = new SelectList(new string[] { " ","INDIA", "USA", "CHINA" });
            return View();
        }
        [HttpPost]
        public IActionResult Create(User item)
        {
            UserRepository repository = new UserRepository();
            repository.Add(item);
            return RedirectToAction("login");
        }
        
        public IActionResult login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult login(string uname,string pwd)
        {
            UserRepository repository = new UserRepository();
            User user = repository.Validate(uname, pwd);
            if(user!=null)
            {
                return RedirectToAction("Details",user);

            }
            else
            {
                ViewData["err"] = "Invalid Credentials";
                return View();
            }
        }
        public IActionResult Details([Bind(include:"Name")]
        User item)
        {
            return View(item);
        }
    }
}