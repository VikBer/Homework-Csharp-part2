/*
        7. Задачи седьмого (7) семинара:
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Clear();

int[,] array = new int[new Random().Next(3,6),new Random().Next(3,6) ];

FillArray(array);
PrintArray(array);
Console.Write($"\n");
ArithmeticMean(0);

void  FillArray (int[,] arr)
{
        for (int i = 0; i < arr.GetLength(0); i++)
       {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                        arr[i,j] = new Random().Next(0, 10);
                }
       }
}

void PrintArray (int[,] arr)
{
        for (int i = 0; i < arr.GetLength(0); i++)
       {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                  Console.Write($"{arr[i,j]} ");
                }
         Console.Write($"\n");
       }
       
}

void ArithmeticMean (double aMe)
{
        Console.Write("Cреднее арифметическое каждого столбца: ");
        for (int i = 0; i < array.GetLength(1); i++)
        {
                aMe = 0;
                for (int j = 0; j < array.GetLength(0); j++)
                        {
                                aMe += array[j,i];
                        }
                aMe = Math.Round(aMe / array.GetLength(0),2);
                Console.Write($"{aMe}; ");
        }
}
