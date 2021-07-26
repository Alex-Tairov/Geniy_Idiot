using Geniy_Idiot_Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Geniy_Idiot
{
    public partial class MainForm : Form
    {
        private User user;
        private Game game;
       
        public MainForm()
        {
            InitializeComponent();
        }

        //Выводим рандомный вопрос
        private void Form1_Load(object sender, EventArgs e)
        {
            var userInfoForm = new UserInfoForm();
            if (userInfoForm.ShowDialog(this) == DialogResult.OK)
            {
                var userName = userInfoForm.UserNameTextBox.Text;//Записываем имя пользователя
                user = new User(userName);
                game = new Game(user);
                game.ReStore();
                PrintNextQuestion();
            }
            else
            {
                Close();
            }
            
            
        }

        //Обрабатываем нажатие на кнопку "Далее"
        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            var len = userAnswerTextBox.Text.Length;
            if (len == 0)
            {
                MessageBox.Show("Вы ничего не ввели");
            }
            else
            {
                var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
                game.AcceptAnswers(userAnswer);
                PrintNextQuestion();
            }
        }

        private void PrintNextQuestion()
        {
            if (game.IsEnd())
            {
                var diagnose = game.CalculateDiagnose();
                MessageBox.Show(game.CalculateDiagnose());
                game.SaveResult();
                nextQuestionButton.Enabled = false;
                return;
                
            }
            var question = game.PopRandomQuestion();
            questionTextLabel.Text = question.Text;
            questionNumberLabel.Text = game.GetCurrentQuestionNumberInfo();
            userAnswerTextBox.Clear();
            userAnswerTextBox.Focus();
        }

        //Защита от дурака
        private void userAnswerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || (e.KeyChar == 8));
            if (e.Handled == true)
            {
                MessageBox.Show("Введите корректно данные");
            }
   
            
        }
      
        //Кнопка "Выход"
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Кнопка "Рестарт"
        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.ReStore();
            PrintNextQuestion();
            
        }
              

        //Выводим результаты
        private void отобразитьПредыдущиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userResultsForm = new UserResultsForm(UserResult.GetResultsFromFile());
            userResultsForm.Show();
        }

        private void questionNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var userInfoForm = new UserInfoForm();
            if (userInfoForm.ShowDialog(this) == DialogResult.OK)
            {
                var userName = userInfoForm.UserNameTextBox.Text;//Записываем имя пользователя
                user = new User(userName);
                game = new Game(user);
                game.ReStore();
                nextQuestionButton.Enabled = true;
                PrintNextQuestion();
            }
            else
            {
                Close();
            }
        }
    }
}
