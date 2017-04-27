using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSAdminWeb.Domain.Entities
{
    public class Pcmessage
    {
        [Key]
        public int PCM_Id { get; set; }
        public string PCM_Num { get; set; }
        public string PCM_RoomName { get; set; }
        public string PCM_UserNum { get; set; }
        public string PCM_Mac { get; set; }
        public Nullable<int> PCM_NowState { get; set; }
        public Nullable<int> PCM_GetNewOpera { get; set; }
        public string PCM_AppRecord { get; set; }
        public string PCM_ScreenJpgsrc { get; set; }
        public string PCM_Course { get; set; }
        public Nullable<System.DateTime> PCM_LastTime { get; set; }
    }
}
