﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lexa.Controllers
{
    public class AlertController : Controller
    {
        // GET: Alert
        public ActionResult AlertList()
        {
            return View();
        }
    }
}