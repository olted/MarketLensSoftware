using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLensSoftware
{
    class Mapping
    {
        public string GetOperation(string OptionName)
        {
            if (OptionName == "Close Prices")
            {
                return "ClosePrice";
            }
            if (OptionName == "Open Prices")
            {
                return "OpenPrice";
            }
            if (OptionName == "Daily Highs")
            {
                return "HighPrice";
            }
            if (OptionName == "Daily Lows")
            {
                return "LowPrice";
            }
            if (OptionName == "Daily Volume")
            {
                return "Volume";
            }

            else
            {
                throw new ArgumentException("Error occurred - Data not found");
            }
        }
    }
}
