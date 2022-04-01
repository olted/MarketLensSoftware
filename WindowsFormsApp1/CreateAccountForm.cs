using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketLensSoftware
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
            
           
        }

        private void ContinueLabel_Click(object sender, EventArgs e)
        {
            //make it create account here using existing methods
            SQLDataRetrieval createaccount = new SQLDataRetrieval();
            if (PasswordText.Text == ConfirmPasswordText.Text)
            {
                createaccount.CreateSQLAccount(UsernameText.Text, PasswordText.Text, EmailTextBox.Text);
                new LoginForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error");
            }
            

        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {
            Validation validater = new Validation();
            validater.AddToValidationList(new List<TextBox> { UsernameText, PasswordText, ConfirmPasswordText, EmailTextBox });
            validater.EnforceValidation();

        }

        private void ConfirmPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
