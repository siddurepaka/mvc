using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeMvc.Models;
using EmployeeMvc.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    [HttpGet]
        public IActionResult Create()
        {
            ViewBag.designation=new SelectList(new string[] { "Analyst", "Manager", "TeamMem" });
            ViewBag.projectName = new SelectList(new string[] { "A", "B", "c" });
        return View();
        }
    [HttpPost]
        public IActionResult Create(Employee item)
        {
            EmployeeRepository rep = new EmployeeRepository();
            // UserRepository rep = new UsRepository();
            rep.Add(item);
            return RedirectToAction("Login");
        }
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
        public IActionResult login(string eid, string pwd)
        {
            EmployeeRepository repository = new EmployeeRepository();
            Employee emp = repository.Validate(eid, pwd);
            if (emp != null)
            {
                return RedirectToAction("Details");

            }
            else
            {
                ViewData["err"] = "Invalid Credentials";
                return View();
            }
        }
        
        
        public IActionResult Details()
        {
            return View();
        }
    }

    
