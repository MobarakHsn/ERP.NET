using ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP.Controllers.ProductManager
{
    public class ProductLeaveController : Controller
    {
        // GET: ProductLeave
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Leave_requests lreq)
        {
            if(ModelState.IsValid)
            {
                if(lreq.start_time>lreq.end_time)
                {
                    TempData["msgd"] = "End time must be greater than start time!";
                    return View(lreq);
                }
                //lreq.employee_id = (int)Session["e_id"];
                lreq.employee_id = 1;
                lreq.request_made = DateTime.Now;
                lreq.status = "Pending";
                var db = new ERPEntities();
                db.Leave_requests.Add(lreq);
                TempData["msg"]= "Leave request sent to HR";
                db.SaveChanges();
                return View();
            }
            return View(lreq);
        }

        public ActionResult MyLeave()
        {
            var db = new ERPEntities();
            //var myList = (from list in db.Leave_requests where list.employee_id == (int)Session["e_id"] select list).ToArray();
            var myList = (from list in db.Leave_requests where list.employee_id==1 select list).ToArray();
            ViewBag.myList = myList;
            return View();
        }
    }
}