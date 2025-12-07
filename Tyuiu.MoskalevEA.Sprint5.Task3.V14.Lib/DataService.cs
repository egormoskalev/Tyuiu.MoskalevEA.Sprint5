using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MoskalevEA.Sprint5.Task3.V14.Lib
{
    public class DataService : ISprint5Task3V14
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            double result;

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                result = Math.Round((4 * Math.Pow(x, 3)) / (Math.Pow(x, 3) - 1), 3);
                writer.Write(result);
            }
            return path;
        }
    }
}
