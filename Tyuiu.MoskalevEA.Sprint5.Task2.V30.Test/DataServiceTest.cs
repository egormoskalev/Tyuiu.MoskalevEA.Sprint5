using Tyuiu.MoskalevEA.Sprint5.Task2.V30.Lib;

namespace Tyuiu.MoskalevEA.Sprint5.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedSaveFile()
        {
            string path = @"C:\C#\Tyuiu.MokslaevEA.Sprint5\Tyuiu.MoskalevEA.Sprint5.Task2.V29\bin\Debug\OutPutFileTask2.csv";
            path = @"C:\Users\Gali8\source\repos\Tyuiu.MoskalevEA.Sprint5\Tyuiu.MoskalevEA.Sprint5.Task2.V30\bin\Debug\OutPutFileTask2.csv";
            string path2 = Directory.GetCurrentDirectory();
            Console.WriteLine(path2);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
