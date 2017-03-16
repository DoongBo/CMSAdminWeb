using CMSAdminWeb.Domain.Abstract;
using CMSAdminWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSAdminWeb.Domain.Concrete
{
    public class EFUserRepository : IUserRespository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<User> Users
        {
            get { return context.Users; }
        }
    }
}
