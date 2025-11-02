using Tyuiu.GamaleevaYuA.Sprint4.Task1.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Гамалеева Ю. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнила: Гамалеева Юлия Андреевна | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 7 подсчитать сумму нечетных *");
        Console.WriteLine("* элементов массива.С клавиатуры:1, 7, 2, 2, 6, 2, 3, 2, 3, 5, 7, 7, 1, 2 *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int len;
        Console.WriteLine("Введите количество элементов массива: ");
        len = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[len];
        for (int i = 0; i < len; i++)
        {
            Console.WriteLine("Введите значение " + i + " элемента массива: ");
            nums[i] = Convert.ToInt32(Console.ReadLine());
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