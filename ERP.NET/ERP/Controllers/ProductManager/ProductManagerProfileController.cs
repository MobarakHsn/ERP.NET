using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP.Controllers.ProductManager
{
    public class ProductManagerProfileController : Controller
    {
        // GET: ProductManagerProfile
        public ERPEntities db = new ERPEntities();
        [HttpGet]
        public ActionResult MyProfile()
        {
            //var user=(from u in db.Users where u.id==(int)Session["id"] select u).SingleOrDefault();
            var user = (from u in db.Users where u.id == 1 select u).SingleOrDefault();
            var employee = (from em in db.Employees where em.employee_id==user.id select em).SingleOrDefault();
            ViewBag.user = user;
            ViewBag.employee = employee;
            return View();
        }
        [HttpGet]
        public ActionResult EditProfile()
        {
            //var user=(from u in db.Users where u.id==(int)Session["id"] select u).SingleOrDefault();
            var user = (from u in db.Users where u.id == 1 select u).SingleOrDefault();
            ViewBag.user = user;
            return View(user);
        }
        [HttpPost]
        public ActionResult EditProfile(User us)
        {
            //var user=(from u in db.Users where u.id==(int)Session["id"] select u).SingleOrDefault();
            var user = (from u in db.Users where u.id == 1 select u).SingleOrDefault();
            ViewBag.user = user;
            if(ModelState.IsValid)
            {
                if(us.password!=user.password)
                {
                    TempData["msge"] = "Wrong Current Password!";
                    return View(us);
                }
                user.firstname = us.firstname;
                user.lastname = us.lastname;
                user.phone = us.phone;
                user.email = us.email;
                db.SaveChanges();
                TempData["msgs"] = "Profile Updated!";
                return View(us);
            }
            return View(us);
        }
    }
}