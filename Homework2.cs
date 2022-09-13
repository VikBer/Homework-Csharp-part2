/*
        8. Задачи восьмого (8) семинара:

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

*/

Console.Clear();

int possibilityOfMultiplying = new Random().Next(1,5); //во избежание нарушения правил размерности умножаемых матриц, создаю подходящий правилам размер
int[,] matrixA = new int [ new Random().Next(1,5), possibilityOfMultiplying];
int[,] matrixB = new int [possibilityOfMultiplying, new Random().Next(1,5)];
int[,] resultMatrix = new int [matrixA.GetLength(0),matrixB.GetLength(1)];

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
Console.WriteLine("\nМатрица А");
FillAndPrintArray(matrixA);
Console.WriteLine("\nМатрица B");
FillAndPrintArray(matrixB);

int[,] MultiplyMatrix (int[,] arrA, int[,] arrB)
{
       int[,] arrResult = resultMatrix;
       for (int i = 0; i < arrA.GetLength(0); i++)
       {
        for (int j = 0; j < arrB.GetLength(1); j++)
        {
                for (int k = 0; k < arrB.GetLength(0); k++)
                {
                        arrResult[i,j] += arrA[i,k] * arrB[k,j];
                }
        }        
       }

       return arrResult;

}
void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }

Console.WriteLine("\nИтоговая матрица");
Print(MultiplyMatrix(matrixA,matrixB));