using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GamaleevaYuA.Sprint4.Task4.V5.Lib
{
    public class DataService : ISprint4Task4V5
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0;
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.GetUpperBound(1) + 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 == 0) sum += matrix[i, j];
                }
            }
            return sum;
        }
    }
}
