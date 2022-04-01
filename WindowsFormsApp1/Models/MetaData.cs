using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLensSoftware.Models
{
    public class MetaData
    {
        /* 
          "Meta Data":{
         "1. Information":"Daily Prices (open, high, low, close) and Volumes",
         "2. Symbol":"MSFT"
      },
         */
        [JsonProperty("1. Information")]
        public string description { get; set; }

        [JsonProperty("2. Symbol")]
        public string symboldescription { get; set; }
    }
}
