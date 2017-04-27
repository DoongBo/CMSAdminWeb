using CMSAdminWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSAdminWeb.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        //code first,初始化时若是数据库不存在则按一下对象创建

        public DbSet<User> Users { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Sccrecord> Sccrecords { get; set; }
        public DbSet<SignRecord> SignRecords { get; set; }
        public DbSet<Studuty> Studutys { get; set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<Pcmessage> Pcmessages { get; set; }
        public DbSet<Notice> Notices { get; set; }
    } 
}
