using CMSAdminWeb.Domain.Concrete;
using CMSAdminWeb.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSAdminWeb.WebUI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //code first ，当没有数据库时生成数据库
            //EFDbContext efcontext = new EFDbContext();
            Overview overview = new Overview();
            return View(overview);
        }
    }
}