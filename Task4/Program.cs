/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


Console.WriteLine("Введите размер трехмерного массива X x Y x Z:");

Console.Write("Введите число X: ");
int x = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите число Y: ");
int y = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите число Z: ");
int z = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine();

int[,,] array3D = new int[x, y, z];

if (x * y * z < 91)
{
    CreateArray(array3D);
    PrintArray(array3D);
}
else
{
    Console.WriteLine("Двухзначные числа кончились. Невозможно создать массив, чтобы числа не повторялись");
}



void CreateArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                }
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})      ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
