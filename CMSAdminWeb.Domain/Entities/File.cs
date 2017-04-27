using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSAdminWeb.Domain.Entities
{
    public class File
    {
        [Key]
        public int File_Id { get; set; }
        public string File_Name { get; set; }
        public string File_Path { get; set; }
        public string File_Type { get; set; }
        public string File_Ownner { get; set; }
        public Nullable<System.DateTime> File_Time { get; set; }
        public string File_Other { get; set; }
    }
}
