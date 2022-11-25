/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов");
int columns = Convert.ToInt32(Console.ReadLine()!);

int[,] array = GetArrayRandom(rows, columns);

PrintArray(array);

MinSumOfRows(array);
Console.WriteLine();

void MinSumOfRows(int[,] array)
{
    int sum = 0;
    int MinSum = 0;
    int count = 0;
    int countOfRows = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];

        }

        Console.WriteLine($"Сумма в {countOfRows} строке = {sum}");
        if (MinSum == 0 || MinSum > sum)
        {
            MinSum = sum;
            count = countOfRows;
        }
        countOfRows++;
        sum = 0;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {count} строка");
}

int[,] GetArrayRandom(int rows, int columns, int minValue = 0, int maxValue = 10)
{
    int[,] array = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();

    }
}

