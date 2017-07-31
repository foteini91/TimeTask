using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TimeTastService.Models;

namespace TimeTastService.Controllers
{
    public class TimeController : ApiController
    {
        public void Post(int id_u, string s_time)
        {
          // using (TimeDatabase db = new TimeDatabase()) // create an istance of the database
            {
                Time insert = new Time();
                insert.StopT = s_time;
                insert.userID = id_u;
            }
        }
    }
}
