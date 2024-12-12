using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.BozhukovVP.Sprint6.Task6.V10.Lib
{
    public class DataService : ISprint6Task6V10
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(resStr))
                    {
                        resStr = resStr + " " + line;
                    }
                }
            }
            return resStr;
        }
    }
}
