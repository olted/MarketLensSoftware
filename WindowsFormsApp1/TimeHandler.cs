using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarketLensSoftware
{
    class TimeHandler
    {
           public DateTime GetDateTime()
        {
            var daytime = DateTime.UtcNow;
            return daytime;
        }
        public DateTime GetTodayDate()
        {
            var todaydate = DateTime.Today;
            return todaydate;
        }
        
    }
}
