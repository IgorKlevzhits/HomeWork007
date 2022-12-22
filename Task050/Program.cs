/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

void getElement(int[,] array, int height, int width)
{
    if ((height < 11) && (width < 11))
    {
        Console.WriteLine($"По адресу: [{height}, {width}] содержится элемент - {array[height - 1, width - 1]}");
    }
    else
    {
        Console.WriteLine($"Элемента с адресом: [{height}, {width}] - не существует");
    }
}

int[,] array = getArray(10, 10);
Console.WriteLine("Дан массив:");
showArray(array);
int height = getNumber("Введите строку массива: ");
int width = getNumber("Введите столбец массива: ");
getElement(array, height, width);
