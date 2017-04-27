using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSAdminWeb.Domain.Entities
{
    public class Studuty
    {
        [Key]
        public int Duty_Id { get; set; }
        public string Duty_StuNum { get; set; }
        public string Duty_StuName { get; set; }
        public string Duty_Week { get; set; }
        public string Duty_Date { get; set; }
        public string Duty_Time { get; set; }
    }
}
