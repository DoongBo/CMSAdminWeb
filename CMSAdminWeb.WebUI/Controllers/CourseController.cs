using CMSAdminWeb.WebUI.HelpClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSAdminWeb.WebUI.Controllers
{
    [MemberValidationAttribute(Roles = "teacher")]
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            return View();
        }
    }
}