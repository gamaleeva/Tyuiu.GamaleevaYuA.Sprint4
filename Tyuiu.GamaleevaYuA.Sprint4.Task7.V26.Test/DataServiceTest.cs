using Tyuiu.GamaleevaYuA.Sprint4.Task7.V26.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint4.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int rows = 5;
            int cols = 3;
            string str = "351268459614723";
            int wait = 18432;
            int res = ds.Calculate(rows, cols, str);
            Assert.AreEqual(wait, res);

        }
    }
}
