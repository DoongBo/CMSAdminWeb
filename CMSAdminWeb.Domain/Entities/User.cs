using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSAdminWeb.Domain.Entities
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }
        public string User_Num { get; set; }
        public string User_Name { get; set; }
        public string User_Dept { get; set; }
        public string User_Class { get; set; }
        public string User_PSD { get; set; }
        public int User_HasNew { get; set; }
        
    }
}
