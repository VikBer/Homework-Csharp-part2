/*
        7. Задачи седьмого (7) семинара:
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/
Console.Clear();

Console.WriteLine("Введите первую координату искомой позиции");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите вторую координату искомой позиции");
int b = int.Parse(Console.ReadLine()!);

int[,] array = new int[new Random().Next(3,6), new Random().Next(3,6)];

void SearchingNumber (int x, int y)
{
        if (x < array.GetLength(0) && y < array.GetLength(1))
                { 
                        Console.Write($"\nЗначение искомого элемента = {array[x,y]} ");
                }
        else { Console.Write("Такого числа нет в массиве");}
}
void  FillArray (int[,] arr)
{
        for (int i = 0; i < arr.GetLength(0); i++)
       {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                        arr[i,j] = new Random().Next(0, 50);
                }
       }
}

void PrintArray (int[,] arr)
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
SearchingNumber(a,b);