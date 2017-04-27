using CMSAdminWeb.Domain.Abstract;
using CMSAdminWeb.Domain.Entities;
using CMSAdminWeb.WebUI.Infrastructure.Abstract;
using CMSAdminWeb.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CMSAdminWeb.WebUI.Controllers
{
    //登录界面
    [AllowAnonymous]
    public class LoginController : Controller
    {
        IAuthProvider authProvider;
        public LoginController(IAuthProvider auth)
        {
            authProvider = auth;
          
        }
        public ActionResult Index()
        {
            bool isauth = this.HttpContext.User.Identity.IsAuthenticated;
            if (isauth)
                return Redirect(Url.Action("Index", "Home"));
            return View("Login");
        }

        // GET: Home
        public ActionResult Login()
        {
            bool isauth = this.HttpContext.User.Identity.IsAuthenticated;
            if (isauth)
               return Redirect(Url.Action("Index", "Home"));
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnurl)
        {
            if(ModelState.IsValid)
            {
                  if (authProvider.Authenticate(model.UserName, model.Password))
                    {
                        return Redirect(returnurl ?? Url.Action("Index", "Home"));
                    }
                    else
                    {
                        ModelState.AddModelError("", "请输入正确的账户密码！");
                        return View();
                    }

              
                
            }
            else
            {
                return View();
            }
            
        }
        public ActionResult LogOut()
        {
            HttpContext.Session.Clear();
            FormsAuthentication.SignOut();
            return  Redirect(Url.Action("Index", "Home"));
        }
    }
}