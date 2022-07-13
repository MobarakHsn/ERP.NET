using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP.Controllers.ProductManager
{
    public class ProductIssueController : Controller
    {
        // GET: ProductIssue
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Issue isu)
        {
            if(ModelState.IsValid)
            {
                //isu.issued_by = Session["uname"].ToString();
                isu.issued_by = "mobarak";
                isu.issue_time = DateTime.Now;
                isu.status = "Pending";
                var db = new ERPEntities();
                db.Issues.Add(isu);
                TempData["msg"] = "Issue sent to Administration Panel";
                db.SaveChanges();
                return View();
            }
            return View(isu);
        }
        public ActionResult MyIssues()
        {
            var db = new ERPEntities();
            //var myList = (from list in db.Issues where list.issued_by.Equals(Session["uname"]) select list).ToArray();
            var myList = (from list in db.Issues where list.issued_by.Equals("mobarak") select list).ToArray();
            ViewBag.MyIssues = myList;
            return View();
        }
    }
}