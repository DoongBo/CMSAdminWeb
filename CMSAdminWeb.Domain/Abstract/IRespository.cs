using CMSAdminWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSAdminWeb.Domain.Abstract
{
    public interface IUserRespository : BaseOprate
    {
        IEnumerable<User> Users { get; }
    }
    public interface IFileRespository : BaseOprate
    {
        IEnumerable<File> Files { get; }
    }
    public interface IManagerRespository : BaseOprate
    {
        IEnumerable<Manager> Managers { get; }
    }
    public interface IMessageRespository : BaseOprate
    {
        IEnumerable<Message> Messages { get; }
    }
    public interface ISccrecordRespository : BaseOprate
    {
        IEnumerable<Sccrecord> Sccrecords { get; }
    }
    public interface ISignRecordRespository : BaseOprate
    {
        IEnumerable<SignRecord> SignRecords { get; }
    }
    public interface IStudutyRespository : BaseOprate
    {
        IEnumerable<Studuty> Studutys { get; }
    }
    public interface ITermRespository : BaseOprate
    {
        IEnumerable<Term> Terms { get; }
    }
    public interface IPcmessageRespository : BaseOprate
    {
        IEnumerable<Pcmessage> Pcmessages { get; }
    }
    public interface INoticeRespository : BaseOprate
    {
        IEnumerable<Notice> Notices { get; }
    }

}
