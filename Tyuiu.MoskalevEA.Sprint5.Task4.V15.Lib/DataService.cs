using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MoskalevEA.Sprint5.Task4.V15.Lib
{
    public class DataService : ISprint5Task4V15
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Trim().Replace(".", ",");
            double res = Math.Sin(Convert.ToDouble(strX)) + (Math.Pow(Convert.ToDouble(strX), 2) / 2);
            return Math.Round(res, 3);
        }
    }
}
