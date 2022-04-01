using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketLensSoftware
{
    class Validation
    {
        List<TextBox> textboxes = new List<TextBox>();
        public void AddToValidationList(List<TextBox> tb)
        {
            textboxes = tb;
        }
        public void EnforceValidation()
        {
            foreach (TextBox textbox in textboxes)
            {
                if (textbox.Name == "UsernameText")
            {
                textbox.MaxLength = getMaxUserLen();
            }
            if (textbox.Name == "PasswordText")
            {
                textbox.MaxLength = GetMaxPassLen();
            }
            if (textbox.Name == "ConfirmPasswordText")
            {
                textbox.MaxLength = GetMaxPassLen();
            }
            if (textbox.Name == "EmailTextBox")
            {
                textbox.MaxLength = GetMaxEmailLen();
            }
            }
        }
        private int getMaxUserLen()
        {
            return 14;
        }
        private int GetMaxPassLen()
        {
            return 16;
        }
        private int GetMaxEmailLen()
        {
            return 22;
        }


    }
}
