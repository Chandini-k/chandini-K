using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Employee.Models;
using Microsoft.AspNetCore.Authorization;

namespace Employee.Controllers
{
    public class EmployeeController:Controller
    {
        //IEmployee1Repository employee1Repository = new Employee1Repository();
        private readonly IEmployee1Repository employee1Repository;//dependency injected obj
        public EmployeeController(IEmployee1Repository emRepository)
        {
            employee1Repository = emRepository;
        }
        public IActionResult Search(int? Id)
        {
            int ID = (int)((Id == null) ? 1 : Id);
           Employee1 emp= employee1Repository.GetEmployee1(ID);
            //if(emp!=null)
            //return Content(emp.Id + "\n" + emp.Name + "\n" + emp.Email + "\n" + emp.Dept);
            //return Content("Employee does not exost");
            //ViewData["Id"] = emp.Id;
            //ViewData["name"] = emp.Name;
            //ViewData["Email"] = emp.Email;
            //ViewData["Dept"] = emp.Dept;
            //ViewBag.Id = emp.Id;
            //ViewBag.name = emp.Name;
            //ViewBag.Email = emp.Email;
            //ViewBag.Dept = emp.Dept;
            //ViewData["employee"] = emp;
            //ViewBag.employee = emp;
            return View(emp);
        }
        public IActionResult Index()
        {
            List<Employee1> elist = employee1Repository.DisplayDetails();
            return View(elist);
        }
        public ViewResult AboutEmployee()
        {
            Employee1 emp = employee1Repository.GetEmployee1(2);
            //ViewBag.projectName = "BookHive";
            EmployeeProjectViewModel ep = new EmployeeProjectViewModel();
            ep.employee = emp;
            ep.projectName = "BookHive";
            return View(ep);
        }
        public IActionResult GetAllEmployees()
        {
            List<Employee1> elist = (employee1Repository.DisplayDetails()).Where(e=>e.Dept==Dept.Insurance).ToList();
            //return View("~/Views/Employee1/Index.cshtml",elist);
            return View("Index", elist);//relarive path to refer a view
        }
        [HttpGet]
        public IActionResult Create()
        {
            //    Employee1 emp = employee1Repository.GetEmployee1(2);
            //    return View(emp);
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee1 emp)
        {
            if (ModelState.IsValid)
            {
                employee1Repository.AddEmployee(emp);
                return RedirectToAction("Index");
            }
            //else
            //{
            //    return View("Fail");
            //}
            return View();
        }
        public IActionResult Fail()
        {
            return View();
        }
        public IActionResult Success()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Employee1> elist = employee1Repository.DisplayDetails();
            return View(elist);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Employee1 e)
        {
            bool res = employee1Repository.AddEmployee(e);
            //return View();
            return RedirectToAction("Index");
        }
        public bool IsExist(string email)
        {
            var result = (employee1Repository.DisplayDetails()).Find(r => r.Email==email);
            if (result == null)
                return true;
            else
                return false;
        }
        [AcceptVerbs("Get", "Post")]
        //[AllowAnonymous]
        public JsonResult IsEmailExist(string email)
        {
            return IsExist(email) ? Json(true) : Json("email exist");
        }
        public IActionResult _myPartial()
        {

        }
    }
}