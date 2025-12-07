using Tyuiu.MoskalevEA.Sprint5.Task0.V5.Lib;

namespace Tyuiu.MoskalevEA.Sprint5.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();

            int x = 3;
            string path = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(path));

            string result = File.ReadAllText(path);


            Assert.AreEqual("-0,223", result);
        }
    }
}
