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

int[,] SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int max = arr[i,j];
            int min = arr[i,j];
            if (arr[i,j] > max)
            {
                
            }

        }
        Console.Write("\n");
    }
    return arr;
}
