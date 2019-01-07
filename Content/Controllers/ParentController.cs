using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Content.Controllers
{
    public class ParentController : Controller
    {
        // GET: Parent
        public ActionResult PR_Home()
        {
            return View();
        }
        public ActionResult PR_Location()
        {
            return View();
        }
        public ActionResult PR_Today()
        {
            return View();
        }
        public ActionResult PR_History()
        {
            return View();
        }
        public ActionResult PR_Cancel()
        {
            return View();
        }
    }
}