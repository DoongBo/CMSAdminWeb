using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSAdminWeb.Domain.Entities
{
    public class Notice
    {
        [Key]
        public int Notice_Id { get; set; }
        public string Notice_Content { get; set; }
        public string Notice_Title { get; set; }
        public string Notice_Sender { get; set; }
        public Nullable<System.DateTime> Notice_Time { get; set; }
    }
}
