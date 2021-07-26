using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace Geniy_Idiot_Common
{
    //Отвечает за то откуда получать вопросы
    public class QuestionsStorage
    {
        private static string questionsPath = "questions.json";
        //Функция для вопросов
        public static List<Question> GetQuestions()
        {
            var question1 = new Question("Сколько будет два плюс два  умноженное на два?", 6);
            var question2 = new Question("Бревно нужно распилить на 10  частей, сколько надо сделать  распилов?", 9);
            var question3 = new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25);
            var question4 = new Question("Укол делают каждые полчаса,  сколько нужно минут для трех  уколов?", 60);
            var question5 = new Question("Пять свечей горело, две  потухли. Сколько свечей  осталось?", 2);
            var questions = new List<Question> { question1, question2, question3, question4, question5 };
            return questions;

        }
        
        //Считываем список вопросов из файла и дессиреализуем его
        public static List<Question> GetQuestionsFromFile()
        {
            //Считываем содержимое файла
            var serializedQuestions = FileProvider.Get(questionsPath);
            //Диссериализация(возвращает указанный тип данных)
            var questions = JsonConvert.DeserializeObject<List<Question>>(serializedQuestions);
            return questions;
            
        }

        //Серриализуем вопросы
        public static void SaveQuestions(List<Question> questions)
        {
            var serializedQuestions = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.Set(questionsPath, serializedQuestions);

        }

         //Создаем файл,если его нет
        public static void CreateFileIfNotExists()
        {
            if (!FileProvider.IsExists(questionsPath))
            {
                var questions = GetQuestions();
                SaveQuestions(questions);
            }
        }

        
    }
}

