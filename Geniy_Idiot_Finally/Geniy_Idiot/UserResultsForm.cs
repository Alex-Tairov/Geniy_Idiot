using Geniy_Idiot_Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Geniy_Idiot
{
    public partial class UserResultsForm : Form
    {
        private List<UserResult> userResults;
        public UserResultsForm(List<UserResult> userResults)
        {
            InitializeComponent();
            this.userResults = userResults;
        }

        private void userResultsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UserResultsForm_Load(object sender, EventArgs e)
        {
            var results = UserResult.GetResultsFromFile();
            for (int i = 0; i < userResults.Count; i++)
            {
                var userResult = results[i];
                userResultsDataGridView.Rows.Add(userResult.Name, userResult.CountRightAnswers, userResult.Diagnos);
            }

        }
    }
}
