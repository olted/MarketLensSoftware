using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLensSoftware
{
    public class OutputPrice
    {
     

        public string StockDate { get; set; }
        public double OpenPrice { get; set; }
        public double ClosePrice { get; set; }
        public double LowPrice { get; set; }
        public double Highprice { get; set; }
        public double DailyVolume { get; set; }



        public string CompleteInfo
        {
/* finish below */
            get { return $"{StockDate} {OpenPrice} {ClosePrice} "; } 
        }

    }
}
