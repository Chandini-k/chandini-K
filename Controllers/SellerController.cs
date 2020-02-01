using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaseStudy.Models;
using Microsoft.AspNetCore.Mvc;

namespace CaseStudy.Controllers
{
    public class SellerController:Controller
    {
        //SellerRepository sellerRepository = new SellerRepository();
        private readonly ISellerRepository sellerRepository;
        public SellerController(ISellerRepository selRepository)
        {
            sellerRepository = selRepository;
        }
        public IActionResult Search(int? id)
        {
            int ID = (int)((id == null) ? 1 : id);
            Seller seller = sellerRepository.GetSeller(ID);
            if (seller != null)
                return Content(seller.id + "\n" + seller.name + "\n" + seller.password + "\n" + seller.emailid + "\n" + seller.mobileno + "\n" + seller.companyname + "\n" + seller.briefabtcmpy + "\n" + seller.address + "\n" + seller.website + "\n" + seller.GST);
            return Content("Employee does not exist");
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
            //return View(emp);
        }
        public IActionResult Index()
        {
            List<Seller> sellerlist = sellerRepository.DisplayDetails();
            return View(sellerlist);
        }
        //public ViewResult AboutEmployee()
        //{
        //    Employee1 emp = employee1Repository.GetEmployee1(2);
        //    //ViewBag.projectName = "BookHive";
        //    EmployeeProjectViewModel ep = new EmployeeProjectViewModel();
        //    ep.employee = emp;
        //    ep.projectName = "BookHive";
        //    return View(ep);
        //}
        //public IActionResult GetAllEmployees()
        //{
        //    List<Employee1> elist = (employee1Repository.DisplayDetails()).Where(e => e.Dept == "Insurance").ToList();
        //    //return View("~/Views/Employee1/Index.cshtml",elist);
        //    return View("Index", elist);//relarive path to refer a view
        //}
    }
}
