using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CaseStudy.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace CaseStudy.Controllers
{
    public class SellerController : Controller
    {
        public readonly SellerContext _context;
        private readonly IWebHostEnvironment hostingEnvironment;
        public SellerController(SellerContext context, IWebHostEnvironment hostingEnvironment)
        {
            this._context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public ActionResult SellerRegister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SellerRegister(Seller b)
        {
            try
            {

                _context.Add(b);
                _context.SaveChanges();
                ViewBag.message = b.UserName + "has got successfully registered";
                return RedirectToAction("SellerLogin");
            }
            catch (Exception e)
            {
                ViewBag.message = b.UserName + "Registration failed ";
                return View();
            }

        }
        [HttpGet]
        public ActionResult SellerLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SellerLogin(Buyer b)
        {
            var logUser = _context.sellers.Where(e => e.UserName == b.UserName && e.Password == b.Password).ToList();
            if (logUser.Count == 0)
            {
                ViewBag.message = "Not valid User";
                return View();
            }
            else
            {//to store session values
                HttpContext.Session.SetString("UName", b.UserName);

                ////HttpContext.Session.SetString("lastLogin", DateTime.Now.ToString());
                return RedirectToAction("CreateSellerDashBoard");
            }

        }

        public ActionResult CreateSellerDashBoard()
        {
            if (HttpContext.Session.GetString("UName") != null)
            {
                ViewBag.uname = HttpContext.Session.GetString("UName").ToString();
                //ViewBag.lldt = HttpContext.Session.GetString("lastLogin").ToString();
                if (Request.Cookies["lastLogin"] != null)
                {
                    ViewBag.lldt = Request.Cookies["lastLogin"].ToString();
                }
            }
            return View();
        }
        public ActionResult SellerLogOut()
        {
            Response.Cookies.Append("lastLogin", DateTime.Now.ToString());
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        // GET: CookieSession
        public ActionResult SellerIndex()
        {
            return View();
        }

        // GET: CookieSession/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CookieSession/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SellerViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                // If the Photo property on the incoming model object is not null, then the user
                // has selected an image to upload.
                if (model.PhotoPath != null)
                {
                    // The image must be uploaded to the images folder in wwwroot
                    // To get the path of the wwwroot folder we are using the inject
                    // HostingEnvironment service provided by ASP.NET Core
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    // To make sure the file name is unique we are appending a new
                    // GUID value and and an underscore to the file name
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.PhotoPath.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    // Use CopyTo() method provided by IFormFile interface to
                    // copy the file to wwwroot/images folder
                    model.PhotoPath.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Seller newseller = new Seller
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Companyname = model.Companyname,
                    Password = model.Password,
                    GSTIN = model.GSTIN,
                    BriefabtCompany = model.BriefabtCompany,
                    Address = model.Address,
                    Website = model.Website,
                    MobileNo = model.MobileNo,
                    // Store the file name in PhotoPath property of the employee object
                    // which gets saved to the Employees database table
                    PhotoPath = uniqueFileName
                };

                _context.Add(newseller);
                _context.SaveChanges();
                return RedirectToAction("Details", new { id = newseller.Sid });
            }
            return View();

        }
        // GET: CookieSession/Details/5
        public async Task<IActionResult> Details(int id)
        {
            Seller seller = _context.sellers.FirstOrDefault(e => e.Sid == id);
            return View(seller);
        }


        // GET: CookieSession/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seller = await _context.sellers.FindAsync(id);
            if (seller == null)
            {
                return NotFound();
            }
            return View(seller);
        }
        // POST: CookieSession/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Sid,UserName,Password,Email,MobileNo")] Seller seller)
        {
            if (id != seller.Sid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seller);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SellerExists(seller.Sid))

                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(SellerIndex));
            }
            return View(seller);
        }


        // GET: CookieSession/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CookieSession/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var buyer = await _context.sellers.FindAsync(id);
            _context.sellers.Remove(buyer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(SellerIndex));
        }
        private bool SellerExists(int id)
        {
            return _context.sellers.Any(e => e.Sid == id);
        }
    }
}