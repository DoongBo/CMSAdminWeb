using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSAdminWeb.Domain.Entities
{
    public class Term
    {
        [Key]
        public int Term_Id { get; set; }
        public string Term_Name { get; set; }
        public Nullable<System.DateTime> Term_StartDate { get; set; }
        public Nullable<System.DateTime> Term_EndDate { get; set; }
        public Nullable<System.DateTime> Term_FirstMonday { get; set; }
    }
}
