using Tyuiu.MoskalevEA.Sprint5.Task7.V1.Lib;
namespace Tyuiu.MoskalevEA.Sprint5.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string sourcePath = @"C:\DataSprint5\InputDataFileTask7V1.txt";

            string tempDirectory = Path.GetTempPath();
            string tempFileName = Path.GetFileName(sourcePath);
            string tempFilePath = Path.Combine(tempDirectory, tempFileName);

            File.Copy(sourcePath, tempFilePath, true);

            Console.WriteLine($"Файл скопирован в: {tempFilePath}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string result = ds.LoadDataAndSave(tempFilePath);

            string outputPath = Path.Combine(tempDirectory, "OutPutDataFileTask7V1.txt");
            File.WriteAllText(outputPath, result);

            Console.WriteLine($"Результат сохранён в: {outputPath}");
            Console.WriteLine("Содержимое результата:");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}