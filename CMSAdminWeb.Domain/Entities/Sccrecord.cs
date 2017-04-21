using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSAdminWeb.Domain.Entities
{
    public class Sccrecord
    {
        [Key]
        public int Src_Id { get; set; }
        public Nullable<int> Src_SignId { get; set; }
        public string Src_Imagurl { get; set; }
    }
}
