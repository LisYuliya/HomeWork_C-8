/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


Console.Write("Введите число строк первой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите число столбцов первой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите число строк второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите число столбцов второй матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine()!);


int[,] firstMatrix = GetArrayRandom(rows1, columns1);
int[,] secondMatrix = GetArrayRandom(rows2, columns2);

Console.WriteLine("Первая матрица:");
PrintArray(firstMatrix);
Console.WriteLine();

Console.WriteLine("Вторая матрица:");
PrintArray(secondMatrix);
Console.WriteLine();

int[,] resultMatrix = new int[rows1, columns2];

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);

if ((columns1 == rows2))
{
    Console.WriteLine("Произведение первой и второй матриц:");
    PrintArray(resultMatrix);
}




void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
    if (columns1 != rows2)
    {
        Console.WriteLine("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }
    else if ((columns1 == rows2))
    {
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < firstMartrix.GetLength(1); k++)
                {
                    sum += firstMartrix[i, k] * secondMartrix[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }
    }
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

