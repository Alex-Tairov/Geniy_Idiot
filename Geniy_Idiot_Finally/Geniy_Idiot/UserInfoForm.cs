using System;
using System.Windows.Forms;

namespace Geniy_Idiot
{
    public partial class UserInfoForm : Form
    {
        public UserInfoForm()
        {
            InitializeComponent();
            
        }

               

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text.Length == 0)
            {
                
                okButton.Enabled = false;

            }
            else
            {
                
                okButton.Enabled = true;

            }
        
        }
    }
}
