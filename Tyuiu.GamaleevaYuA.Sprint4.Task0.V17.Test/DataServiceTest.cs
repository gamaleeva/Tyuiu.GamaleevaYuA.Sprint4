using Tyuiu.GamaleevaYuA.Sprint4.Task0.V17.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint4.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();
            int wait = 34;
            int[] array = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            int res = ds.GetSumEvenArrEl(array);
            Assert.AreEqual(wait, res);
        }
    }
}
