using Model.DTOs;
using Newtonsoft.Json;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Content.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AD_Checker_Reg()
        {
            return View();
        }

        ////public ActionResult AD_Checker_Register(object<<<<<)
        ////{
        ////    return content(jsonconvert.serializeobject(user), "application/json");
        ////}
        public ActionResult AD_Checker_Register(Checker_AddDTO checker)
        {
            Checker_AddDTO checkerInfo = ServiceProvider.AdminService.Checker_Add();
            return Content(JsonConvert.SerializeObject(checkerInfo), "application/json");
        }
        
        public ActionResult AD_Driver_Reg()
        {
            return View();
        }
        public ActionResult AD_Home()
        {
            return View();
        }
        public ActionResult AD_Parent_Reg()
        {
            return View();
        }
        public ActionResult AD_School_Reg()
        {
            return View();
        }

        public ActionResult AD_Staff_Reg()
        {
            return View();
        }
    }
}