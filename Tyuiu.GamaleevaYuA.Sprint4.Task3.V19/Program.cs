using Tyuiu.GamaleevaYuA.Sprint4.Task3.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Гамалеева Ю. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                        *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #19                                                              *");
        Console.WriteLine("* Выполнила: Гамалеева Юлия Андреевна | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов заполненный         *");
        Console.WriteLine("* статическими значениями в диапазоне от 3 до 9 подсчитать количество четных    *");
        Console.WriteLine("* элементов во всём массиве.                                                      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[,] array = { { 6, 5, 6, 3, 8 }, { 9, 4, 4, 3, 4 }, { 3, 3, 6, 8, 6 }, { 6, 5, 3, 4, 3 }, { 9, 3, 5, 3, 7 } };
        int rows = array.GetUpperBound(0) + 1;
        int cols = array.GetUpperBound(1) + 1;
        Console.WriteLine("Массив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{array[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(array);
        Console.WriteLine("Количество чётных элементов массива: " + res);
        Console.ReadKey();
    }
}