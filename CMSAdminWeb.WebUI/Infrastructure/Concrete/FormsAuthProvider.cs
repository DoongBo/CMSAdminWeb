using CMSAdminWeb.Domain.Abstract;
using CMSAdminWeb.Domain.Concrete;
using CMSAdminWeb.Domain.Entities;
using CMSAdminWeb.WebUI.HelpClasses;
using CMSAdminWeb.WebUI.Infrastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Security;
 

namespace CMSAdminWeb.WebUI.Infrastructure.Concrete
{
    public class FormsAuthProvider:IAuthProvider
    {
        IManagerRespository mansgers;
        public FormsAuthProvider(IManagerRespository efManagerRepository)
        {
            mansgers = efManagerRepository;
        }
        public bool Authenticate(string usernum, string password)
        {
            bool result = Check(usernum, password);
            if(result)
            {
                HttpContext.Current.Session.Clear();
                FormsAuthentication.SignOut();
                FormsAuthentication.SetAuthCookie(usernum, false);
            }
            return result;
        }
        private bool Check(string usernum,string passwrod)
        {
             if (mansgers.Managers == null || mansgers.Managers.Where(ma => ma.Mana_Num == "cmsadmin").FirstOrDefault() == null)
                {
                    Manager admin = new Manager()
                    {
                        Mana_Name = "超级管理员",
                        Mana_Num = "cmsadmin",
                        Mana_PSD = ConvertToMd5.Convert("admin@cms2017"),
                        Mana_Type = "超级管理员"
                    };
                    mansgers.AddElem(admin);
                }
                bool result = false;
                string pwd = ConvertToMd5.Convert(passwrod);
                if (mansgers.Managers.Where(ma => ma.Mana_PSD == pwd && ma.Mana_Num == usernum).FirstOrDefault() != null)
                    result = true;
                return result;
           
        }
    }
    
}