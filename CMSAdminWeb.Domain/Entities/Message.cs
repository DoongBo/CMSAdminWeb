using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSAdminWeb.Domain.Entities
{
    public class Message
    {
        [Key]
        public int Message_Id { get; set; }
        public int Message_Type { get; set; }
        public string Message_Content { get; set; }
        public string Message_Sender { get; set; }
        public string Message_UserNum { get; set; }
        public Nullable<System.DateTime> Message_Time { get; set; }
        public string Message_Title { get; set; }
    }
}
