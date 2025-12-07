using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MoskalevEA.Sprint5.Task0.V5.Lib
{
    public class DataService : ISprint5Task0V5
    {

        public string SaveToFileTextData(int x)
        {

            double y = Math.Log((x + 1.0) / (x + 2.0));
            y = Math.Round(y, 3);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            File.WriteAllText(path, y.ToString());

            return path;
        }
    }
}
