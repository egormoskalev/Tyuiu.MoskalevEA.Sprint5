using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MoskalevEA.Sprint5.Task5.V16.Lib
{
    public class DataService : ISprint5Task5V16
    {
        public double LoadFromDataFile(string path)
        {
            double m = -100000;
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                string[] lines = line.Split(' ');
                foreach (string data in lines)
                {
                    string temp = data.Replace(".", ",");
                    double num = Math.Round(Convert.ToDouble(temp), 3);
                    if (num > m && num % 10 == 0 && num != 0)
                    {
                        m = num;
                    }
                }
            }
            return m;
        }
    }
}