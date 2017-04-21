using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSAdminWeb.Domain.Entities
{
    public class Manager
    {
        [Key]
        public string Mana_Num { get; set; }
        public string Mana_Name { get; set; }
        public string Mana_Type { get; set; }
        public string Mana_PSD { get; set; }
    }
}
