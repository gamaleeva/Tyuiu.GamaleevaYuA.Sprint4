using Tyuiu.GamaleevaYuA.Sprint4.Task3.V19.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint4.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculation()
        {
            DataService ds = new DataService();
            int[,] array = { {6, 5, 6, 3, 8 }, {9, 4, 4, 3, 4 }, {3, 3, 6, 8, 6 }, {6, 5, 3, 4, 3 }, {9, 3, 5, 3, 7 } };
            int wait = 11;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);

        }
    }
}
