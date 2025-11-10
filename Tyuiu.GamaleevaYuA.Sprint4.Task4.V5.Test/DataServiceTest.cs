using Tyuiu.GamaleevaYuA.Sprint4.Task4.V5.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint4.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculation()
        {
            DataService ds = new DataService();
            int[,] matrix = { {6, 3, 6, 6, 7 }, {9, 8, 9, 7, 9 }, {5, 6, 8, 7, 5 }, {8, 5, 6, 5, 3 }, {3, 9, 9, 8, 8 } };
            int wait = 70;
            int res = ds.Calculate(matrix);
            Assert.AreEqual(wait, res);


        }
    }
}
