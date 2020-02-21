using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCUsingModelValidations.Repositories;
using MVCUsingModelValidations.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCUsingModelValidations.Controllers
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
            ViewBag.Country = new SelectList(new string[] { "","INDIA", "CANADA", "USA", "UK" });
            return View();
        }
        [HttpPost]//Get and post method when action name is same 
        public IActionResult Create(User item)
        {
            UserRepository repository = new UserRepository();
            repository.Add(item);
            //    return RedirectToAction("Login");
            if (ModelState.IsValid)
            {
                return RedirectToAction("Login");
            }
            else
                return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string uname,string pwd)
        {
            UserRepository repository = new UserRepository();
            User user = repository.Validate(uname, pwd);
            if(user!=null)
            {
                return RedirectToAction("Details", user);
                //return RedirectToAction("Greet",new { id = 10 });
            }
            else
            {
                ViewData["err"] = "Invalid Credentials";
                return View();
            }
        }
        public IActionResult Details(User item)
        {
            return View(item);
        }
        //public IActionResult Details([Bind(include:"Name")]User item)
        //{
        //    return View(item);
        //}
        public IActionResult Greet(int id)
        {
            return View();
        }
    }
}