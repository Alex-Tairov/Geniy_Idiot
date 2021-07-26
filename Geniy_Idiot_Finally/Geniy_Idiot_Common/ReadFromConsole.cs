using System;


namespace Geniy_Idiot_Common
{
    public class ReadFromConsole
    {
        //Метод чтения данных с клавиатуры
        public static int GetUserAnswer()
        {
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Введите число");
            }
            return result;

        }
        
     
        
    }

}

