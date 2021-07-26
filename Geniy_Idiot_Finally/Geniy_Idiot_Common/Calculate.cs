//Высчитывает диагноз

namespace Geniy_Idiot_Common
{
    public class Calculate
    {
        
        public static string PrintDiagnos(User user, int questionsCount)
        {
            var res = (double)((100 / questionsCount) *user.CountRightAnswers);
            if (res == 0)
            {
                return "Идиот";
            }
            else if (res > 0 && res <= 20)
            {
                return "Кретин";
            }
            else if (res > 20 && res <= 40)
            {
                return "Дурак";
            }
            else if (res > 40 && res <= 60)
            {
                return "Нормальный";
            }
            else if (res > 60 && res <= 80)
            {
                return "Талант";
            }
            else
            {
                return "Гений";
            }
        }

    }
}

