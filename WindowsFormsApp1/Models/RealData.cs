using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLensSoftware.Models
{
    public class RealData
    {
        /* 
          "Time Series (Daily)":{
      "2021-11-02":{
         "1. open":"330.3100",
         "2. high":"333.4500",
         "3. low":"330.0000",
         "4. close":"333.1300",
         "5. volume":"25719044"
      },
      "2021-11-01":{
         "1. open":"331.3550",
         "2. high":"331.4900",
         "3. low":"326.3700",
         "4. close":"329.3700",
         "5. volume":"26840400"
      },
      "2021-10-29":{
         "1. open":"324.1300",
         "2. high":"332.0000",
         "3. low":"323.9000",
         "4. close":"331.6200",
         "5. volume":"34765982"
         */
        [JsonProperty("2021-09-20")]
        public DayPerformance DayData { get; set; }


        [JsonProperty("2. ")]
        public string symboldescription { get; set; }

    }
    public class DayPerformance
    {
        public override string ToString()
        {
            return $"Open Price ={OpenPrice} \n Close Price = {ClosePrice} \n Lowest Price = {LowestPrice} \n Highest Price = {HighestPrice} \n Day Volume = {DayVolume} ";
        }
        [JsonProperty("1. open")] 
        public string OpenPrice { get; set; }

        [JsonProperty("4. close")]
        public string ClosePrice { get; set; }

        [JsonProperty("3. low")]
        public string LowestPrice { get; set; }

        [JsonProperty("2. high")]
        public string HighestPrice { get; set; }
        [JsonProperty("5. volume")]
        public string DayVolume { get; set; }
    }
}