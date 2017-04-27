using CMSAdminWeb.Domain.Concrete;
using CMSAdminWeb.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSAdminWeb.WebUI.Controllers
{
    //实时监控
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult OnlineStudent()
        {
            return View();
        }
    }
}