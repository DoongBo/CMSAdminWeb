using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSAdminWeb.Domain.Entities
{
    public class SignRecord
    {
        [Key]
        public int Record_Id { get; set; }
        public string Record_Num { get; set; }
        public string Record_Name { get; set; }
        public Nullable<System.DateTime> Record_InTime { get; set; }
        public Nullable<System.DateTime> Record_OutTime { get; set; }
        public string Record_CourseName { get; set; }
        public string Record_PCNum { get; set; }
        public string Record_RoomName { get; set; }
        public Nullable<int> Record_HasExit { get; set; }
    }
}
