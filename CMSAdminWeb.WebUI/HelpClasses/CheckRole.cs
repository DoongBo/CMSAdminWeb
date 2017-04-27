using CMSAdminWeb.Domain.Abstract;
using CMSAdminWeb.Domain.Concrete;
using CMSAdminWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMSAdminWeb.WebUI.HelpClasses
{
    public static class CheckRole
    {
       
        public static bool Check(string role)
        {
            IManagerRespository managerrep = new EFManagerRepository();
            HttpContext httpcontext = HttpContext.Current;
            string usernum = httpcontext.User.Identity.Name;

            Manager user = managerrep.Managers.Where(ma => ma.Mana_Num == usernum).FirstOrDefault();
            if (user == null)
                return false;
            else
                switch (user.Mana_Type)
                {
                    case "学生管理员": if (role == "stuman"||role=="all") return true; else return false;
                    case "授课教师": if (role == "teacher"||role=="all") return true; else return false; ;
                    case "超级管理员": if (role == "admin"||role=="all") return true; else return false;
                    default: return false;
                }
        }
    }
}