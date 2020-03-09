using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LexaVertical.Controllers
{
    public class UserGroupController : Controller
    {
        // GET: UserGroup
        public ActionResult GroupList()
        {
            return View();
        }
    }
}