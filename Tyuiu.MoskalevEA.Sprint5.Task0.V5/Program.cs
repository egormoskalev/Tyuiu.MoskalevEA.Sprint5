
using Tyuiu.MoskalevEA.Sprint5.Task0.V5.Lib;

namespace Tyuiu.MoskalevEA.Sprint5.Task0.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int x = 3;
            string path = ds.SaveToFileTextData(x);

            Console.WriteLine($"* При x = {x}                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Результат сохранен в файл: {path}");
            Console.WriteLine("***************************************************************************");

            string result = File.ReadAllText(path);
            Console.WriteLine($"Содержимое файла: {result}");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
