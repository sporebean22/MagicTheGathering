using System.IO;
using Newtonsoft.Json;

namespace MagicTheGathering.Models.JsonManagement
{
    public class JsonManagement : IJsonManagement
    {
        public void SaveToFile<Type>(Type type, string filename)
        {
            if (!Directory.Exists("Json"))
            { 
                Directory.CreateDirectory("Students");
            }

            var jObject = JsonConvert.SerializeObject(type, Formatting.Indented);

            File.WriteAllText($"Students/{filename}_Data.json", jObject);
        }

        public Type RetrieveJson<Type>(string fileDirectory)
        {
            if (!File.Exists(fileDirectory))
                throw new System.Exception($"No Relevant File Exists in the provided file directory: {fileDirectory}");
            var jsonData = File.ReadAllText(fileDirectory);
            return JsonConvert.DeserializeObject<Type>(jsonData);
        }
    }
}
