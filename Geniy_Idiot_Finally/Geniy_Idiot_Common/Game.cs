using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geniy_Idiot_Common
{
    public class Game
    {
        private List<Question> questions;
        private List<UserResult> results;
        private Question currentQuestion;
        private User user;
        private int currentQuestionNumber = 0;

        //Хранит вопросы
        public Game(User user)
        {
            this.user = user;
            questions = QuestionsStorage.GetQuestions();
            Init();
            questions = QuestionsStorage.GetQuestionsFromFile();


            InitUserResults();
            results = UserResult.GetResultsFromFile();
        }

        //Конец игры
        public bool IsEnd()
        {
            return GetQuestionsCount() == 0;
        }

        
        //Если такого файла c результатами не существует,то создаем его 
        private void InitUserResults()
        {
            UserResult.CreateFileResultsIfNotExists();
        }

        //Если такого файла не существует,то создаем и записываем вопросы
        private void Init()
        {

            QuestionsStorage.CreateFileIfNotExists();
        }

        //Счетчик номера вопроса
        public string GetCurrentQuestionNumberInfo()
        {
            currentQuestionNumber++;
            return "Вопрос номер:" + currentQuestionNumber;
        }


        //Выдает рандомый вопрос,а затем удаляет его из списка
        public Question PopRandomQuestion()
        {
            var random = new Random();
            var randomIndexQuestion = random.Next(0, questions.Count);
            currentQuestion = questions[randomIndexQuestion];
            questions.Remove(currentQuestion);
            return currentQuestion;
        }

        //Считает диагноз
        public string CalculateDiagnose()
        {
            var game = new Game(user);
            var questionsCount = game.GetQuestionsCount();
            return Calculate.PrintDiagnos(user, questionsCount);
        }

        //Сравнивает ответы,при совпадении увел-т счетчик прав-х ответов
        public void AcceptAnswers(int userAnswer)
        {
            var rightAnswer = currentQuestion.Answer;
            if (userAnswer == rightAnswer)
            {
                user.AcceptRightAnswers();
            }
        }

        //Выдает кол-во вопросов
        private int GetQuestionsCount()
        {
            return questions.Count;
        }

        //Сохраняет результат    
        public void SaveResult()
        {
            var game = new Game(user);
            var userResult = new UserResult(user.Name, user.CountRightAnswers, game.CalculateDiagnose());
            results.Add(userResult);
            UserResult.SaveResults(results);

        }

        //"Рестарт"

        public void ReStore()
        {
            questions = QuestionsStorage.GetQuestions();
            user.CountRightAnswers = 0;
            currentQuestionNumber = 0;
        }

    }
}
