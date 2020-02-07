using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCAssign.Models;
using MVCAssign.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCAssign.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Designation = new SelectList(new string[] { "FSE", "Testing", "JAVA", "UI" });
            ViewBag.ProjectName = new SelectList(new string[] { "Emart", "Myntra", "banking", "" });
            return View();
        }
        [HttpPost]
        public IActionResult Signup(Employee e)
        {
            EmployeeRepository repository = new EmployeeRepository();
            repository.Add(e);
            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(int empid, string pwd)
        {
            EmployeeRepository repository = new EmployeeRepository();
            Employee employee = repository.Validate(empid, pwd);
            if (employee != null)
            {
                return RedirectToAction("Details", employee);
                //return RedirectToAction("Greet",new { id = 10 });
            }
            else
            {
                ViewData["err"] = "Invalid Credentials";
                return View();
            }
           
        }
        public IActionResult SignUp()
        {
            return RedirectToAction("Create");
        }
    }
}