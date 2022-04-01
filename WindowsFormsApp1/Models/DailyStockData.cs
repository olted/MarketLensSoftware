using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLensSoftware.Models
{
    public class DailyStockData
    {
        [JsonProperty("Meta Data")]
        public MetaData metadata { get; set; }

        [JsonProperty("Time Series (Daily)")]
       // public RealData realdata { get; set; }
        public Dictionary<string, DayPerformance> rates { get; set; }


    }
}
