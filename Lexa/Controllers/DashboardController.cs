using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Web.Mvc;
using System.Collections.Specialized;

namespace Lexa.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult testajax()
        {
            NameValueCollection col = Request.QueryString;
            var j = 1;

            return View();
        }
        

        public ActionResult Calendar()
        {
            return View();
        }

        public ActionResult RangeSlider()
        {
            return View();
        }

        public ActionResult SessionTimeout()
        {
            return View();
        }
    }
}