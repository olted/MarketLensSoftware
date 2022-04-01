using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketLensSoftware
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e) // Runs as soon as the form loads
        {
            Validation loginvalidation = new Validation();
            loginvalidation.AddToValidationList(new List<TextBox> { UsernameText, PasswordText });  
            //Gets the string value from each textbox
            loginvalidation.EnforceValidation();   
            //Validates every string value from the textboxes
            TestingModule TestMod = new TestingModule(); 
            //This component runs the testing module
            TestMod.TestAPIconnection();
            TestMod.TestSQLConnection();
        }

        private void ContinueLabel_Click(object sender, EventArgs e)
        { 
            SQLDataRetrieval authentication = new SQLDataRetrieval();
            
            var authenticationpassed = authentication.AuthenticateSQL(UsernameText.Text, PasswordText.Text);  
            //Sends a request to the SQL server to authenticate the user
            if (authenticationpassed == true)
            {
                Console.WriteLine("// User Authentication // \n Authentication passed \n // User Authentication //");
                //Displays a message to the console showing that authentication passed for testing/debug purposes.
                new MainForm().Show();                   
                //When authentication is succesful, closes this window and opens the main program
                this.Hide();
            }
            else
            {
                Console.WriteLine("// User Authentication // \n Authentication failed \n // User Authentication //");
                //Displays a message to the console showing that authentication failed for testing/debug purposes.
                MessageBox.Show("Error: Username or password incorrect");          
                //When authentication fails, displays an error
            }
            
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            new CreateAccountForm().Show();                     
            //When the user asks to create an account, it closes this form and opens the account creation form
            this.Hide();
            Console.WriteLine("//Create Account Link// \n User sent to create account form succesfully. \n //Create Account Link// ");
            //Displays a message to the console showing the link passed for testing/debug purposes.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
