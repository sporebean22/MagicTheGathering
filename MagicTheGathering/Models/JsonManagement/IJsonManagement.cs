using MTGGame;

namespace MagicTheGathering.Models.JsonManagement
{
    public interface IJsonManagement
    {
        void SaveToFile<Type>(Type type, string filename);

        Type RetrieveJson<Type>(string fileDirectory);
    }
}