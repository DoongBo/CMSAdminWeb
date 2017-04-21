using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMSAdminWeb.WebUI.Models
{
    //主布局显示摘要
    public class Overview
    {
        public string UserCount { get; set; }
        public string NotiLastTime { get; set; }
        public string NotiCount { get; set; }

        public string LastCommand { get; set; }
        public string LastCommandTime { get; set; }

        public string MessagesCount { get; set; }
        public string ManagerName { get; set; }
        public string MessagesContent { get; set; }
        public string MessagesTime { get; set; }

        public string UserName { get; set; }

        public string PCCount { get; set; }
        public string OnlineCount { get; set; }
        public string PCState { get; set; }
        public Overview()
        {
            NotiCount = "10";
            UserCount = "7";
            NotiLastTime = "2017-3-15";
            LastCommand = "你猜我会让你做什么";
            LastCommandTime = "2017-3-15";
            MessagesCount = "5";
            ManagerName = "就是我呀";
            MessagesContent = "大家好";
            MessagesTime = "2017-3-15";
            UserName = "大哥";
            PCCount = "10";
            OnlineCount = "8";
            PCState = "在使用";
        }
    }
}