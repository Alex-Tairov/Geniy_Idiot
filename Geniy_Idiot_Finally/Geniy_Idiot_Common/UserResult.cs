using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


//Содержит информацию,которая хранится в файле
//(Для отображения)
namespace Geniy_Idiot_Common
{
    
    public class UserResult
    {
        private static string userResultsPath = "userResults.json";
        public string Name;
        public int CountRightAnswers;
        public string Diagnos;

        public UserResult( string name, int countRightAnswers, string diagnos)
        {
            this.Name = name;
            this.CountRightAnswers = countRightAnswers;
            this.Diagnos = diagnos;
        }

        public  static void CreateFileResultsIfNotExists()
        {
            
            if (!FileProvider.IsExists(userResultsPath))
            {
                var value = JsonConvert.SerializeObject(new List<UserResult>(), Formatting.Indented);
                FileProvider.Add(userResultsPath, value);
            }
        }

        public static void SaveResults(List<UserResult> results)
        {
            var serializedResults = JsonConvert.SerializeObject(results, Formatting.Indented);
            FileProvider.Set(userResultsPath, serializedResults);

        }

        public static List<UserResult> GetResultsFromFile()
        {
            //Считываем содержимое файла
            var serializedResults = FileProvider.Get(userResultsPath);
            //Диссериализация(возвращает указанный тип данных)
            var results = JsonConvert.DeserializeObject<List<UserResult>>(serializedResults);
            return results;

        }

        

    }
}
