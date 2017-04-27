using CMSAdminWeb.Domain.Abstract;
using CMSAdminWeb.Domain.Concrete;
using CMSAdminWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMSAdminWeb.WebUI.HelpClasses
{
    public class MemberValidationAttribute : AuthorizeAttribute
    {
        //自定义角色分类
         
 
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {

            string managernum = httpContext.User.Identity.Name;
            string role = this.Roles;
            if (role == null || role == String.Empty)
                return true;
            if (managernum == null || managernum == String.Empty)
                return false;
            else
            {
                return CheckRole.Check(role);
            }
        }
    }
}