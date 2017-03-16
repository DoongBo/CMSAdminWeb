using CMSAdminWeb.Domain.Abstract;
using CMSAdminWeb.Domain.Entities;
using CMSAdminWeb.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSAdminWeb.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IUserRespository userreposotory;
        public HomeController(IUserRespository userrep)
        {
            userreposotory = userrep;
        }
        // GET: Home
        public ActionResult Index()
        {
            Overview overview = new Overview();
            IEnumerable<User> users = userreposotory.Users;
            return View(overview);
        }
    }
}