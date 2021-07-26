using System.IO;
using System.Text;

//Сохраняет в файл и выводит на экран результаты игры
namespace Geniy_Idiot_Common
{
    public class FileProvider
    {
       
        //Записывает данные
        public static void Add(string path, string value)
        {
            var writer = new StreamWriter(path, true, Encoding.UTF8);
            writer.WriteLine(value);
            writer.Close();
        }

        //Перезаписывает данные
        public static void Set(string path, string value)
        {
            var writer = new StreamWriter(path, false, Encoding.UTF8);
            writer.WriteLine(value);
            writer.Close();
        }

        public static string Get(string path)
        {
            StreamReader reader = new StreamReader(path);
            {
                string result = reader.ReadToEnd();
                reader.Close();
                return result;
            }
        }

        //Проверяем существует ли такой файл
        public static bool IsExists(string path)
        {
            return File.Exists(path);
        }
    }
}

