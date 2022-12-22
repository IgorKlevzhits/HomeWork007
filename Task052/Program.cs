/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] getArray(int height, int width)
{
    Random rnd = new Random();
    int[,] array = new int[height, width];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 100);
        }
    }
    return array;
}

void showArray(int[,] array)
{
    string show = String.Empty;
    int len = 0;
    if (array.Length > 1)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                show = Convert.ToString(array[i, j]);
                len = show.Length;
                for (int k = 0; k < 4 - len; k++)
                {
                    show = show.Insert(0, " ");
                }
                Console.Write($"|{show}");
            }
            Console.WriteLine("|");
        }
    }
}

void getAverage(int[,] array)
{
    string message = "Среднее арифметическое каждого столбца: ";
    double result = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result += array[j, i];
        }
        result /= array.GetLength(0);
        message += Convert.ToString(Math.Round(result, 1)) + "; ";
        result = 0;
    }
    Console.WriteLine(message);
}

int[,] array = getArray(3, 3);
Console.WriteLine("Дан массив:");
showArray(array);
getAverage(array);