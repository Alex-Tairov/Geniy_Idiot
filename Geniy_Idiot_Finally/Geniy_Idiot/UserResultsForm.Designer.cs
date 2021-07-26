namespace Geniy_Idiot
{
    partial class UserResultsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountRightAnswers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userResultsDataGridView
            // 
            this.userResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.CountRightAnswers,
            this.Diagnose});
            this.userResultsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.userResultsDataGridView.Name = "userResultsDataGridView";
            this.userResultsDataGridView.RowHeadersWidth = 51;
            this.userResultsDataGridView.RowTemplate.Height = 24;
            this.userResultsDataGridView.Size = new System.Drawing.Size(909, 586);
            this.userResultsDataGridView.TabIndex = 0;
            this.userResultsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userResultsDataGridView_CellContentClick);
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Имя";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 125;
            // 
            // CountRightAnswers
            // 
            this.CountRightAnswers.HeaderText = "Количество правильных ответов";
            this.CountRightAnswers.MinimumWidth = 6;
            this.CountRightAnswers.Name = "CountRightAnswers";
            this.CountRightAnswers.Width = 125;
            // 
            // Diagnose
            // 
            this.Diagnose.HeaderText = "Диагноз";
            this.Diagnose.MinimumWidth = 6;
            this.Diagnose.Name = "Diagnose";
            this.Diagnose.Width = 125;
            // 
            // UserResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 591);
            this.Controls.Add(this.userResultsDataGridView);
            this.Name = "UserResultsForm";
            this.Text = "UserResultsForm";
            this.Load += new System.EventHandler(this.UserResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userResultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountRightAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnose;
    }
}