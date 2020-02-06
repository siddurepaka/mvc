using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmpManagement.Models;

namespace EmpManagement.Controllers
{
    public class EmployeeController :Controller
    {
        
       private readonly Interface employeeRepository;//= new EmployeeRepository();
        public EmployeeController(Interface empRep)
        {
            employeeRepository = empRep;
        }
      //  public IActionResult Search(int? id)
       // {
           // List<Employee> elist = employeeRepository.DisplayDetails();
         //int ID = (int)((id == null) ? 1 : id);
         //  Employee emp = employeeRepository.GetEmployee(1);
            // if (emp != null)
            //{
            //  return Content ( emp.Id + "\n " + emp.Name + "\n" + emp.Email + "\n" + emp.Dept)

            //    ;
            //}
            //return Content("EMployee doesnt exists");
            //}
            // ViewData["id"]=emp.Id
            //  ViewBag.id = emp.Id;
            //  ViewBag.name = emp.Name;

            //    ViewBag.email = emp.Email;

            //   ViewBag.dept = emp.Dept;
          // ViewData["employee"] = emp;

         //  return View(emp);
      //  }
            public IActionResult Index()
        {
            List<Employee> elist = employeeRepository.DisplayDetails();
            return View(elist);
            // return "hello from mvc Index";
        }
       public ViewResult AboutEmployee()
        {
            Employee emp = employeeRepository.GetEmployee(2);
            // ViewBag.ProjectName = "aaaaaaaaaaaaaa";
            //return View(emp);

            EmployeeProject ep = new EmployeeProject();
            ep.employee1 = emp;
            ep.ProjectName = "AAAAA";
            return View(emp);

        }
        
        public IActionResult GetAllEmployee()
        {
            List<Employee> elist = (employeeRepository.DisplayDetails().Where(e => e.Dept == "cse").ToList());
            return View("~/Views/Employee/Index.cshtml", elist);
        }
        [HttpGet]
        public  IActionResult   Create()
        {
            Employee emp = employeeRepository.GetEmployee(1);
            return View(emp);
        }
        [HttpPost]
        public IActionResult Create(int id)
        {
            return View("success");
        }

        public IActionResult Success()
        {
            return View("");
        }
        public IActionResult List()
        {
            List<Employee> elist = employeeRepository.DisplayDetails();
            return View(elist);

        }
        public IActionResult Register(Employee employee)
        {
            bool re = employeeRepository.AddEmployee(employee); 
            return RedirectToAction("Index");
        }
    }
}