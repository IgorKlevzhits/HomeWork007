/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
int getNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && (result > 0))
        {
            break;
        }
        else
        {
            Console.WriteLine($"Введено неверное число, повторить ввод");
        }
    }
    return result;
}

double[,] getArray(int height, int width)
{
    Random rnd = new Random();
    double[,] array = new double[height, width];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = ((rnd.NextDouble() < 0.5) ? -1 : 1) * rnd.NextDouble() * 100;
        }
    }
    return array;
}

void showArray(double[,] array)
{
    string show = String.Empty;
    int len = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            show = Convert.ToString(Math.Round(array[i, j], 1));
            len = show.Length;
            for (int k = 0; k < 6 - len; k++)
            {
                show = show.Insert(0, " ");
            }
            Console.Write($"|{show}");
        }
        Console.WriteLine("|");
    }
}
int height = getNumber("Введите 1ую размерность массива: ");
int width = getNumber("Введите 2ую размерность массива: ");
double[,] array = getArray(height, width);
Console.WriteLine("Ваш массив:");
showArray(array);