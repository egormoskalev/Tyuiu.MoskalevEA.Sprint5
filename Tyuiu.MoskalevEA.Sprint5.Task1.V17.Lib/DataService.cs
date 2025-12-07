using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.MoskalevEA.Sprint5.Task1.V17.Lib
{
    public class DataService : ISprint5Task1V17
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double value;


                    if (x + 1 == 0)
                    {
                        value = 0;
                    }
                    else
                    {
                        value = 2*x-4+(2*x-1)/(Math.Sin(x)+1);
                        value = Math.Round(value, 2);
                    }
                    writer.WriteLine(value.ToString());
                }
            }

            return path;
        }
    }
}

