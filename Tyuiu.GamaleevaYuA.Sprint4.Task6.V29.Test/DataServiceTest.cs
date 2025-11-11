using Tyuiu.GamaleevaYuA.Sprint4.Task6.V29.Lib;
namespace Tyuiu.GamaleevaYuA.Sprint4.Task6.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] array = { "Весна", "Лето", "Осень", "Зима" };
            int wait = 2;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}
