using Tyuiu.GamaleevaYuA.Sprint4.Task2.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Гамалеева Ю. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (генератор случайных числел)                   *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнила: Гамалеева Юлия Андреевна | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
        Console.WriteLine("*  случайными значениями в диапазоне от 2 до 7 подсчитать сумму четных    *");
        Console.WriteLine("* элементов массива.                                                      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int len;
        Console.WriteLine("Введите количество элементов массива: ");
        len = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[len];
        Random rnd = new Random();
        for (int i = 0; i < len; i++)
        {
            nums[i] = rnd.Next(2, 7);
        }
        Console.WriteLine();
        Console.WriteLine("Массив: ");
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(nums);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}