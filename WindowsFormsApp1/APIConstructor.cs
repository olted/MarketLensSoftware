using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MarketLensSoftware
{
    public class APIConstructor
    {
        private string ApiKey = "568W408D0JUPH836";
        public HttpClient APIClient { get; set; }
        public List<string> StoredStocks = new List<string> { };
        public List<string> GetStoredStocks()
        {
            return StoredStocks;
        }
        public void InitializeClient()
        {
            APIClient = new HttpClient();
            APIClient.BaseAddress = new Uri("https://www.alphavantage.co");
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            

            

        } 
        public async Task<string> Execute(string StockName)
        {
            StoredStocks.Add(StockName);
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"query?function=TIME_SERIES_DAILY&symbol={StockName}&apikey={ApiKey}&outputsize=full");
            var result = await APIClient.SendAsync(request);
            var data = await result.Content.ReadAsStringAsync();
            return data;
            

        } 
        
    }
}
