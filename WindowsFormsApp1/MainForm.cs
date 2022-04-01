using LiveCharts;
using LiveCharts.Wpf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketLensSoftware.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Linq;
using System.Globalization;
using System.Collections.ObjectModel;
using WindowsFormsApp1;

namespace MarketLensSoftware
{
    public partial class MainForm : Form
    {

        List<LineSeries> lineseries = new List<LineSeries>();
        List<Statistics> performance = new List<Statistics>();


        public MainForm()
        {
            InitializeComponent();
            cartesianChart1.Series = new SeriesCollection();



        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            //Configure Validation
            



            currenttimer.Start();  
            //Starts ticking the clock
            TimeHandler timing = new TimeHandler();
            var CurrentDay = timing.GetTodayDate().ToString();
            //Uses the Timehandler class to query the current local calendar date

            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            //Creates an X Axis with the properties:
            {
                Title = "Timescale",
                //Label along the X axis
                Separator = new LiveCharts.Wpf.Separator()
                //Distance between lines on the x axis (null therefore automatic)
                {
                    Step = double.NaN,
                    IsEnabled = true
                },

                //Labels along the axis
            }) ;
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            //Creates a Y axis with the properties:
            {
                Title = "Pricescale",
                //Label along the Y axis
                
                Separator = new LiveCharts.Wpf.Separator()
                //Distance between lines on the y axis (null therefore automatic)
                {
                    Step = double.NaN,
                    IsEnabled = true,
                    
                }
            });
               // Labels = new[] { "0" } }) ;
            //Labels along the axis
            DefaultLegend customLegend = new DefaultLegend();
            customLegend.BulletSize = 15;
            customLegend.Orientation = System.Windows.Controls.Orientation.Horizontal;
            //Legend configuration
        }


        private void DDBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IndexSelected = this.DataTypeDropDownBox.SelectedIndex;
            //Holds the index of the currently selected dropdown option
            var data = this.DataTypeDropDownBox.Items[IndexSelected];
            //Holds the value of the currently selected dropdown option

        }

        private void GoButtonClick(object sender, EventArgs e)
        {
            var seriescount = 0;
            seriescount++;
            Mapping newMapping = new Mapping();
            int x = this.DataTypeDropDownBox.SelectedIndex;

            // Declaring variables (Names self-explanatory)
            var financialdatatype = (string)this.DataTypeDropDownBox.Items[x];
            var financialdatasymbol = this.SymbolTextBox.Text;
            var financialdatastartdate = this.StartDateTextBox.Text;
            var financialdataenddate = this.EndDateTextBox.Text;
            var DataOperation = newMapping.GetOperation(financialdatatype);
            // Dataoperation variable held in an object represented by a mapping

            SeriesSelectDropDown.Items.Add($"{financialdatasymbol}" + "Series");


            SQLDataRetrieval SQLSymbolConfig = new SQLDataRetrieval();
            if (SQLSymbolConfig.CheckIfStockLoaded($"{SymbolTextBox.Text}") == false)
            {
                SQLSymbolConfig.ConfigureSQLServer($"{SymbolTextBox.Text}");

                var APIReturn = LoadfromAPI();

                LoadToDatabase(APIReturn);

                DrawCartesian(DataOperation, financialdatasymbol, financialdatastartdate, financialdataenddate);
            }
            else
            {

                DrawCartesian(DataOperation, financialdatasymbol, financialdatastartdate, financialdataenddate);
                DisableDateChange();
            }


        }

        private void DisableDateChange()
        {
            StartDateTextBox.Enabled = false;
            StartDateTextBox.BackColor = System.Drawing.Color.DarkGray;
            EndDateTextBox.Enabled = false;
            EndDateTextBox.BackColor = System.Drawing.Color.DarkGray;


        }


        private void LoadToDatabase(DailyStockData APIReturn)
        {


            if (APIReturn.rates != null && APIReturn.metadata != null)
            {
                var listdata = APIReturn.rates.ToList(); 
                var valuesofapi = APIReturn.rates.Values;
                ////Puts all the returned datapoints and their values in a list
                SQLDataRetrieval insert = new SQLDataRetrieval();
                var numberofbatches = APIReturn.rates.Count / 100;
                //Splits the list into components of 100
                var currentbatch = 1;
                while (currentbatch != numberofbatches)
                {

                    var stilltoprocessdata = listdata.Skip((currentbatch - 1) * 100);
                    var insertvalues = insert.ParseValues(stilltoprocessdata.Take(100).ToList());
                    //creates a very large conjoined string of 100 datavalues
                    insert.SQLConfigureInsert(SymbolTextBox.Text, insertvalues);
                    currentbatch++;
                    //inserts them into an SQL query and loads the next batch
                }
            }
            else
            {
                MessageBox.Show("There was an error finding this stock. Please try to enter a different symbol.");
                //Returns an error if it couldn't find the stock
            }
        }

        private DailyStockData LoadfromAPI()
            //This method retrieves data from the API in a viable format
        {
            try
             //try indicates that if an exception occurs, the program will not crash, but has an out
            {
                APIConstructor AlphaVantageAPI = new APIConstructor();
                Task<string> symboldata = Task.FromResult("");
                //Assigns symboldata to be the result holder for the API call
                Task.Run(() =>  //Runs the API call
                {
                    AlphaVantageAPI.InitializeClient(); //Configures the API
                    symboldata = AlphaVantageAPI.Execute($"{SymbolTextBox.Text}"); //Executes an API call using the user inputted symbol
                }
                ).Wait();
                var jsonreturn = symboldata.Result;  //Stores the json result in an object variable
                var translatedreturn = JsonConvert.DeserializeObject<DailyStockData>(jsonreturn);  //Translates the json format into the object
                return translatedreturn;  //returns the object
            }
            catch
            {
                throw new Exception("Could not connect!"); //If there is a connection failure, displays an error
            }

        }


        public void DrawCartesian
          (string DataOperation, string financialdatasymbol, string financialdatastartdate, string financialdataenddate)
            //Method parameters
        {
            SQLDataRetrieval DisplayedSymbol = new SQLDataRetrieval();
            List<double> PriceOutput = 
                DisplayedSymbol.GetPrices(DataOperation, financialdatasymbol, financialdatastartdate, financialdataenddate);
            //Creates a list of doubles (numbers with decimals) with all the prices received by querying the user input
            ChartValues<double> datavalues = new ChartValues<double>();
            foreach (float StockPrice in PriceOutput)
            {
                datavalues.Add(Math.Round(StockPrice,2));
                
                //Creates a list out of each price received from the SQL Query (rounded to 2 DP)

            }

            var FirstSeries = new LineSeries
            {
                Title = financialdatasymbol,
                Values = datavalues
            };
            //Creates the first line series with the company symbol as a title
            //and the values on the graph as the queried prices

            lineseries.Add(FirstSeries); 
            cartesianChart1.Series.Add(FirstSeries);
            //Adds the series to the chart


            ConfigureLeftDataPanel(datavalues);
            

            

        }

        private void ConfigureLeftDataPanel(ChartValues<double> datavalues)
        {
            TDPBox.Text = ThirtyDayPerf(datavalues);
            SDPBox.Text = SixtyDayPerf(datavalues);
            NDPBox.Text = NinetyDayPerf(datavalues);
            YTDPBox.Text = YearToDatePerf(datavalues);
            performance.Add(new Statistics()
            {
                Performance30 = ThirtyDayPerf(datavalues),
                Performance60 = SixtyDayPerf(datavalues),
                Performance90 = NinetyDayPerf(datavalues),
                Performance360 = YearToDatePerf(datavalues)
            });
            // This will save the performances to an object with the [index] equivalent to the index of the dropdown. Use this!


        }

        private void UpdateButton_click(object sender, EventArgs e)
        { 
            Mapping newMapping = new Mapping();
            int SelectedIndex = this.DataTypeDropDownBox.SelectedIndex;
            //Holds the index of the currently selected dropdown box option

            //Variable declarations by box (Names self-explanatory)
            var financialdatatype = (string)this.DataTypeDropDownBox.Items[SelectedIndex];
            var financialdatasymbol = this.SymbolTextBox.Text;
            var financialdatastartdate = this.StartDateTextBox.Text;
            var financialdataenddate = this.EndDateTextBox.Text;
            var DataOperation = newMapping.GetOperation(financialdatatype);
            // Dataoperation variable held in an object represented by a mapping

            SQLDataRetrieval SQLSymbolConfig = new SQLDataRetrieval();
            SQLSymbolConfig.ConfigureSQLServer($"{SymbolTextBox.Text}");
            var APIReturn = LoadfromAPI();
            LoadToDatabase(APIReturn);
            DrawCartesian(DataOperation, financialdatasymbol, financialdatastartdate, financialdataenddate);


        }

        private void currenttimer_Tick(object sender, EventArgs e)
        {
            TimeHandler timing = new TimeHandler();
            CurrentTimeLabel.Text = timing.GetDateTime().ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SymbolTextBox.Clear();
            DataTypeDropDownBox.Items.Clear();
            StartDateTextBox.Clear();  
            StartDateTextBox.BackColor = System.Drawing.Color.White;
            EndDateTextBox.Clear();
            EndDateTextBox.BackColor = System.Drawing.Color.White;
            cartesianChart1.Series.Clear();
            //Clears all the textboxes, charts and resets colours
        }

        private void SeriesSelectDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
           // var x = 5;
        }
        private string ThirtyDayPerf(ChartValues<double> datavalues)
        {
            if (datavalues.Count > 22) //Checks that there are enough values for the calcualtion to occur
                //22 Market days in a calendar 30 days 
            {
                return Math.Round((datavalues.Last() - datavalues[datavalues.Count - 22]),2).ToString();
                //Takes latest value and compares it to value equivalent market days ago.
            }
            else
            {
                return "N/A"; 
                //Returns N/A if the data range is too small
            }
        }
        private string SixtyDayPerf(ChartValues<double> datavalues)
        {

            if (datavalues.Count > 44)
                //44 Market days in a calendar 60 days
            {
                return Math.Round((datavalues.Last() - datavalues[datavalues.Count - 44]),2).ToString();
                //Takes latest value and compares it to value equivalent market days ago.
            }
            else
            {
                return "N/A";
                //Returns N/A if the data range is too small
            }

        }
        private string NinetyDayPerf(ChartValues<double> datavalues)
        {

            if (datavalues.Count > 66)
                //66 Market days in a calendar 90 days
            {
                return Math.Round((datavalues.Last() - datavalues[datavalues.Count - 66]),2).ToString();
                //Takes latest value and compares it to value equivalent market days ago.
            }
            else
            {
                return "N/A";
                //Returns N/A if the data range is too small
            }
        }
        private string YearToDatePerf(ChartValues<double> datavalues)
        {

            if (datavalues.Count > 262)
                //262 Market days in a calendar year
            {
                return Math.Round((datavalues.Last() - datavalues[datavalues.Count - 262]),2).ToString();
                //Takes latest value and compares it to value equivalent market days ago.
            }
            else
            {
                return "N/A";
                //Returns N/A if the data range is too small
            }
        }

    }
}
