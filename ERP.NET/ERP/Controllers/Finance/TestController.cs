using ERP.Finance_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP.Controllers.Finance
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var db = new ERPEntities1();
            var ware = db.Warehouses.ToList();
            return View(ware);
        }
    }
}