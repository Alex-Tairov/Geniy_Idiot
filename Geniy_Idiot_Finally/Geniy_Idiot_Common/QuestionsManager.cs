using System;
using System.Collections.Generic;

namespace Geniy_Idiot_Common
{
    //Новый класс(поптытался перенести сюда остальные классы)
    public class QuestionsManager
    {
        
        public QuestionsManager questionsManager;
        public List<Question> questions;
        private int counter = 0;
        private Question currentQuestion;
        private User user;
        //Обновляем список вопросов
        
        public QuestionsManager()
        {
            ReStore();
        }
        
        public void ReStore()
        {
            questions = QuestionsStorage.GetQuestions();
        }

        //Выводит кол-во вопров
        public int GetQuestionsCount()
        {
            return questions.Count;
        }
               
        //Выдает рандомный вопрос
        public Question PopRandomQuestion()
        {
            var random = new Random();
            var randomQuestionIndex = random.Next(0, questions.Count);
            currentQuestion = questions[randomQuestionIndex];
            questions.Remove(currentQuestion);
            return currentQuestion;
        }
       
        //Увеличивает значения счетчика
        public int AddCounter()
        {
            counter++;
            return counter;
           
        }
        //Обнуляет значения счетчика
        public int RebootCounter()
        {
            counter = 0;
            return counter;
            
        }
       
    }
}
