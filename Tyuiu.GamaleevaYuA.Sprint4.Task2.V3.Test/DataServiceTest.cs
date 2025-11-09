using Tyuiu.GamaleevaYuA.Sprint4.Task2.V3.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint4.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int wait = 16;
            int[] array = { 1, 7, 2, 2, 6, 2, 3, 2, 3, 5, 7, 7, 1, 2 };
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
