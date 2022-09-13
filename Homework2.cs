/*
        8. Задачи восьмого (8) семинара:

git checkout Lesson8task56 - Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
                                        которая будет находить строку с наименьшей суммой элементов.

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

int[,] arrayA = new int [4, 4];

int[,] FillAndPrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
            Console.Write($"{arr[i,j]} ");
        }
        Console.Write("\n");
    }
    return arr;
}
FillAndPrintArray(arrayA);

int MinimalSummRow(int[,] arr)
{
        int sum = 0;
        int tempSum = 0;
        int count = 1;
        int rowNumber = count;
        
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        tempSum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tempSum += arr[i, j];
            if (i == 0 && j == arr.GetLength(1)-1) {sum = tempSum;}
        }
        if (tempSum < sum) {sum = tempSum; rowNumber = count;}
        count++;
    }
    return rowNumber;
}
Console.Write($"Строка с минимальной суммой элементов под номером {MinimalSummRow(arrayA)}");