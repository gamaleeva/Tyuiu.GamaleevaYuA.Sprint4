using Tyuiu.GamaleevaYuA.Sprint4.Task7.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Гамалеева Ю. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнила: Гамалеева Юлия Андреевна | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Дана строка из одноразрядных цифр \"351268459614723\". Преобразовать ее   *");
        Console.WriteLine("* в матрицу 5 на 3 и подсчитать произведение четных чисел.                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int rows = 5;
        int cols = 3;
        int[,] mtrx = new int[rows, cols];
        string str = "351268459614723";
        int index = 0;
        Console.WriteLine("\nМассив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{str[index]} \t");
                index++;
            }
            Console.WriteLine();
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(rows, cols, str);
        Console.WriteLine("Произведение четных элементов = " + res);
        Console.ReadKey();

    }
}