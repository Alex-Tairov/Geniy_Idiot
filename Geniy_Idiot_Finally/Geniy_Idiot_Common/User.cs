using System;


namespace Geniy_Idiot_Common
{
    //Класс для юзера
    public class User
    {
        public string Name;
        public int CountRightAnswers;
        public Diagnos Diagnos;
        
        public User()
        {
            Name = "Unknown";
            CountRightAnswers = 0;

        }
        
        
        public User(string name)
        {
            Name = name;
            CountRightAnswers = 0;
        }
     
        //Считает кол-во правильных ответов
        public void AcceptRightAnswers()
        {
            CountRightAnswers++;
        }

        //Метод валидации данных на продолжение игры
        public string continueGame(string game)
        {
            string res = "";
            while (game != "Yes")
            {
                if (game == "No")
                {
                    res = "No";
                    break;
                }
                else if (game == "Yes")
                {
                    res = "Yes";
                    break;
                }
                else
                {
                    Console.WriteLine("Введите корректно ответ");
                }
                game = Console.ReadLine();
            }
            return res;
        }

        public void SetDiagnose(Diagnos diagnos)
        {
            Diagnos = diagnos;
        }



    }
}

