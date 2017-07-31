using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeTastService.Models
{
    public class Time
    {
        public int userID { get; set; }
        public string StopT { get; set; }
        public string RestartT { get; set; }
        public string ElapseT { get; set; }
        public string TotalT { get; set; }
       
    }
}