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
       public object AddElem(object elem) { object oj = new object(); return oj; }
       public void DeletElem(object elem) { }
       public void EditElem(object elem) { }
    }
    public class EFFileRepository : IFileRespository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<File> Files
        {
            get { return context.Files; }
        }
        public object AddElem(object elem) { object oj = new object(); return oj; }
        public void DeletElem(object elem) { }
        public void EditElem(object elem) { }
    }
    public class EFManagerRepository : IManagerRespository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Manager> Managers
        {
            get { 
                return context.Managers; 
            }

        }
        //after change or add a manager

        public object AddElem(object manag)
        {
            Manager manager = (Manager)manag;
            context.Managers.Add(manager);
            context.SaveChanges();
            return (object)manager;
        }
         public void DeletElem(object elem){}
          public void EditElem(object elem) { }
    }
    public class EFMessageRepository : IMessageRespository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Message> Messages
        {
            get { return context.Messages; }
        }
        public object AddElem(object elem) { object oj = new object(); return oj; }
        public void DeletElem(object elem) { }
        public void EditElem(object elem) { }
    }
    public class EFSccrecordRepository : ISccrecordRespository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Sccrecord> Sccrecords
        {
            get { return context.Sccrecords; }
        }
        public object AddElem(object elem) { object oj = new object(); return oj; }
        public void DeletElem(object elem) { }
        public void EditElem(object elem) { }
    }
    public class EFSignRecordRepository : ISignRecordRespository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<SignRecord> SignRecords
        {
            get { return context.SignRecords; }
        }
        public object AddElem(object elem) { object oj = new object(); return oj; }
        public void DeletElem(object elem) { }
        public void EditElem(object elem) { }
    }
    public class EFStudutyRepository : IStudutyRespository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Studuty> Studutys
        {
            get { return context.Studutys; }
        }
        public object AddElem(object elem) { object oj = new object(); return oj; }
        public void DeletElem(object elem) { }
        public void EditElem(object elem) { }
    }
    public class EFTermRepository : ITermRespository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Term> Terms
        {
            get { return context.Terms; }
        }
        public object AddElem(object elem) { object oj = new object(); return oj; }
        public void DeletElem(object elem) { }
        public void EditElem(object elem) { }
    }
    public class EFPcmessageRepository : IPcmessageRespository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Pcmessage> Pcmessages
        {
            get { return context.Pcmessages; }
        }
        public object AddElem(object elem) { object oj = new object(); return oj; }
        public void DeletElem(object elem) { }
        public void EditElem(object elem) { }
    }
    public class EFNoticeRepository : INoticeRespository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Notice> Notices
        {
            get { return context.Notices; }
        }
        public object AddElem(object elem) { object oj = new object(); return oj; }
        public void DeletElem(object elem) { }
        public void EditElem(object elem) { }
    }
}
