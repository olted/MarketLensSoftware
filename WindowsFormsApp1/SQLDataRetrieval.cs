using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Windows;
using MarketLensSoftware.Models;

namespace MarketLensSoftware
{
    public class SQLDataRetrieval
    { public double GetValueFromAction(string action, OutputPrice outputmodel)
        { //A simple mapping method for object translation
            if (action == "OpenPrice")
            {
                return outputmodel.OpenPrice;
            }
            if (action == "ClosePrice")
            {
                return outputmodel.ClosePrice;
            }
            if (action == "LowPrice")
            {
                return outputmodel.LowPrice;
            }
            if (action == "HighPrice")
            {
                return outputmodel.Highprice;
            }
            if (action == "DailyVolume")
            {
                return outputmodel.DailyVolume;
            }
            else { return 0.00; }
            //returning null is not possible with doubles



        }
        public void UpdateTable(string Symbol, string parsedvalues, DateTime lastupdatedate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionStringHelper.ConnectionStringValue("CSProjDB")))
            //Establishes an SQL connection with the database held within the local connection string
            {
                connection.Query($"INSERT INTO {Symbol} (StockDate, OpenPrice, ClosePrice, LowPrice, HighPrice, DailyVolume) VALUES{parsedvalues} WHERE StockDate > {lastupdatedate};");
            }

        }
        public List<double> GetPrices(string DataRetrievalCategory, string Symbol, string StartDate, string EndDate) 
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionStringHelper.ConnectionStringValue("CSProjDB")))
            //Establishes an SQL connection with the database held within the local connection string
            {
                var priceoutput = connection.Query<OutputPrice>
                    //creates an object variable and assigns it to the value of the SQL Query
                    ($"SELECT {DataRetrievalCategory} from model.dbo.{Symbol} " +
                    //Queries all values from the table containing price information
                    //of the selected company within the field corresponding to the type of price
                    $"WHERE StockDate > '{StartDate}' AND StockDate < '{EndDate}';").ToList();
                    //Within the calendar date limits, and assigns them
          
                var resultvalues = priceoutput.Select
                    (x => GetValueFromAction(DataRetrievalCategory, x)).ToList();
                //Selects all values of priceoutput and arranges
                //them linearly into a single value list
                return resultvalues;



            }

        }
        public void CreateSQLAccount(string username, string password, string email)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionStringHelper.ConnectionStringValue("CSProjDB")))
            //Establishes an SQL connection with the database held within the local connection string
            {
                connection.Query($"INSERT INTO model.dbo.UserAccounts(Username, Password, Email) VALUES('{username}','{password}','{email}');"); 
                //Inserts user information into the UserAccounts table
            }
        }
        public bool AuthenticateSQL(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionStringHelper.ConnectionStringValue("CSProjDB")))
            //Establishes an SQL connection with the database held within the local connection string
            {
                var query = connection.Query($"SELECT * FROM model.dbo.UserAccounts WHERE Username = '{username}' AND Password = '{password}';");
                //Selects every record matching the user input in the system
                if (query.Count() > 0)
                    //If one is found it executes the code below
                {
                    Console.WriteLine($"//SQL Search Query // \n SQL Handler found the following records: {username} {password} \n //SQL Search Query //");
                    //Logs the result to the console for debugging/testing purposes
                    return true;
                    //Returns a positive value to indicate authentication succesful
                }
                else
                //If none is found it executes the code below
                {
                    Console.WriteLine("//SQL Search Query // \n SQL Could not find matching records \n //SQL Search Query//");
                        //Logs the result to the console for debugging/testing purposes
                    return false;
                    //Returns a negative value to indicate authentication unsuccesful
                }


            }
        }

        public bool CheckIfStockLoaded(string Symbol)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionStringHelper.ConnectionStringValue("CSProjDB")))
            {
                var returnresult = connection.ExecuteScalar($"SELECT CASE WHEN OBJECT_ID('dbo.{Symbol}', 'U') IS NOT NULL THEN 1 ELSE 0 END");
                if (returnresult.ToString() == "0")
                {
                    return false;
                }
                if (returnresult.ToString() == "1")
                {
                    return true;
                }
                else
                {
                    throw new Exception("Could not determine whether Symbol is loaded. Contact developper.");
                }
            }
        }
        
        public void ConfigureSQLServer(string Symbol)
            //Method which runs to create a new table to store financial symbol data in
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionStringHelper.ConnectionStringValue("CSProjDB")))
                //Establishes an SQL connection with the database held within the local connection string
            {
                
                connection.Query($"IF OBJECT_ID('model.dbo.{Symbol}') IS NULL" + //Checks that the table doesn't exist already
                    $" BEGIN CREATE TABLE model.dbo.{Symbol} " +                 //If it doesn't, creates one 
                    $"(StockDate datetime, OpenPrice float, ClosePrice float, LowPrice float, HighPrice float, DailyVolume float," +
                                                                                //With these parameters
                    $" CONSTRAINT PK_{Symbol} PRIMARY KEY (StockDate)) END;");  //And with date as a primary key
            }
           
        }

        public string ParseValues(List<KeyValuePair<string, DayPerformance>> dataset)
        {
            List<string> insertstatement = new List<string>();
            
           foreach (var datapoint in dataset)
            { 
                string template = $"('{datapoint.Key}', {datapoint.Value.OpenPrice}, {datapoint.Value.ClosePrice}, {datapoint.Value.LowestPrice}, {datapoint.Value.HighestPrice}, {datapoint.Value.DayVolume})";
                insertstatement.Add(template);
            }
            var finalresult = String.Join("," , insertstatement.ToArray());
            return finalresult;
        }

        public void SQLConfigureInsert(string Symbol, string values)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionStringHelper.ConnectionStringValue("CSProjDB")))
            //Establishes an SQL connection with the database held within the local connection string
            {
                connection.Query($"INSERT INTO {Symbol} (StockDate, OpenPrice, ClosePrice, LowPrice, HighPrice, DailyVolume) VALUES{values};");
                //Inserts parsed values into the SQL Table
            }
        }
        public DateTime GetDateTime()
        {
            var datetime = DateTime.UtcNow;
            return datetime;
        }
        public DateTime GetTodayDate()
        {
            var todaydate = DateTime.Today;
            return todaydate;
        }
    }
}




