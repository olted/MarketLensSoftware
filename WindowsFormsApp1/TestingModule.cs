using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLensSoftware
{
    class TestingModule
    {
        public async void TestAPIconnection()
        {
            
            APIConstructor apitest = new APIConstructor(); //Loads the API Constructor into the module
            apitest.InitializeClient();
            var APITestResult = await apitest.Execute("MSFT");  //Sends the API endpoint a Query for Microsoft (MSFT)
            if (APITestResult != null)
            {
                Console.WriteLine("// API TESTING MODULE RESULT // \n APITest Succesful \n // API MODULE TESTING RESULT // "); 
                //Checks if the API sends a return. If it does, it prints a success statement to the console.
            }
            else
            {
                Console.WriteLine("// API TESTING MODULE RESULT // \n APITest FAILED \n // API MODULE TESTING RESULT // ");
                //If it doesn't, returns an output declaring a test failure
            }
            
        }
        public void TestSQLConnection()
        {
            SQLDataRetrieval SQLTest = new SQLDataRetrieval();
            var testresult = SQLTest.CheckIfStockLoaded("MSFT");
            //Sends a request to the SQL database to check if Microsoft has been loaded into the tables. By default it should be.
            if (testresult != false)
            {
                Console.WriteLine("// SQL TESTING MODULE RESULT // \n SQLTest Succesful \n // SQL MODULE TESTING RESULT // ");
                //Checks if the SQL Database sends a return. If it does, it prints a success statement to the console.
            }
            else
            {
                Console.WriteLine("// SQL TESTING MODULE RESULT // \n SQLTest FAILED. \n // SQL MODULE TESTING RESULT // ");
                //Checks if the API sends a return. If it doesn't, sends a failure statement to the console.
            }
        }
    }
}
