using Tyuiu.GamaleevaYuA.Sprint4.Task5.V25.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint4.Task5.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculation()
        {
            DataService ds = new DataService();
            int[,] matrix = { {2, -1, 1 }, {0, 3, -4 }, {1, 2, 3 } };
            int wait = 12;
            int res = ds.Calculate(matrix);
            Assert.AreEqual(wait, res);
        }
    }
}
