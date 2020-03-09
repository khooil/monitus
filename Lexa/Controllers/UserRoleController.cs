using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Web.Mvc;

namespace Lexa.Controllers
{
    public class UserRoleController : Controller
    {
        // GET: UserRole
        public ActionResult RoleList()
        {
            return View();
        }

        public ActionResult DashBoard()
        {
            return View("~/Views/Dashboard/CustomDash.cshtml");
        }
    }
}