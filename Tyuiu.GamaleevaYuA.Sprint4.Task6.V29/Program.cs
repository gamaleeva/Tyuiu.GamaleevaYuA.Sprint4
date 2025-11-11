using Tyuiu.GamaleevaYuA.Sprint4.Task6.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнила: Гамалеева Ю. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Класс Array                                                       *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнила: Гамалеева Юлия Андреевна | ИБКСб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Дан строковый массив данных [\"Весна\", \"Лето\", \"Осень\", \"Зима\"]  *");
        Console.WriteLine("* используя класс Array подсчитайте количество элементов, длина которых   *");
        Console.WriteLine("* больше 4.                                                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string[] array = { "Весна", "Лето", "Осень", "Зима" };
        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(array);
        Console.WriteLine("Количество элементов, длина которых > 4: ");
        Console.WriteLine(res);
        Console.ReadKey();
    }
}