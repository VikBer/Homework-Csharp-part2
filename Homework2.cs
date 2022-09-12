/*
git checkout Lesson8task54 - Задача 54: Задайте двумерный массив. 
                                Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

 
*/

int[,] alphaArray = new int[new Random().Next(3, 6), new Random().Next(3, 6)];

int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.Write("\n");
    }
    return arr;
}

FillArray(alphaArray);

Console.Write("\n");

int[,] betaArray = alphaArray;

int[,] SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int count = 0; count < arr.GetLength(1); count++)
        {
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
            {
                int temp = 0;
                if (arr[i, j] < arr[i, j + 1])
                {
                    temp = arr[i, j + 1];
                    arr[i, j + 1] = arr[i, j];
                    arr[i, j] = temp;
                }
            }
        }
    }
    return arr;
}

PrintArray(SortArray(betaArray));

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.Write("\n");
    }
}