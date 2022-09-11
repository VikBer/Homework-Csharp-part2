/*
        7. Задачи седьмого (7) семинара:
git checkout Lesson7task47 - Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

*/
Console.Clear();

Console.WriteLine("Введите количество строк массива");
int m =  int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива");
int n =  int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение минимального элемента диапазона для создания массива");
int min =  int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение максимального элемента диапазона для создания массива");
int max =  int.Parse(Console.ReadLine()!);

double[,] array = new double[m,n];

void  FillArray (double[,] arr)
{
        for (int i = 0; i < arr.GetLength(0); i++)
       {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                        arr[i,j] = Math.Round( new Random().NextDouble() + new Random().Next(min, max), 2);
                }
       }
}

void PrintArray (double[,] arr)
{
        for (int i = 0; i < arr.GetLength(0); i++)
       {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                  Console.Write($"{array[i,j]} ");
                }
         Console.Write($"\n");
       }
       
}

FillArray(array);
PrintArray(array);