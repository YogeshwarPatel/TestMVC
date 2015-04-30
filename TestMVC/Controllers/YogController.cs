using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMVC.Controllers
{
    public class YogController : Controller
    {
        //
        // GET: /Yog/

        public ActionResult Index()
        {
            return View("MyProfile");
        }

        public ActionResult MyProfile()
        {
            return View();
        }
    }
}
