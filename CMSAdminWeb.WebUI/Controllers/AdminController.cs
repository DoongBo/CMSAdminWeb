using CMSAdminWeb.WebUI.HelpClasses;
using CMSAdminWeb.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSAdminWeb.WebUI.Controllers
{
    //超级管理员

    [MemberValidationAttribute(Roles = "admin")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            
            return View();
        }
    }
}