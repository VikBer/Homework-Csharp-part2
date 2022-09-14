/*
        9. Задачи девятого (9) семинара:
git checkout Lesson9task64 - Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
                                        в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

Console.Clear();
Console.WriteLine("Введите значение N");
int n = int.Parse(Console.ReadLine()!);

int Recursion (int r)
{
        if (r <= 0) 
                {
                Console.Write("Введено не натуральное число "); 
                return r;
                }
        if (r > 1) 
        {
                Console.Write($"{r}, ");
                return Recursion(r-1);
        }
        return r;
}

Console.WriteLine(Recursion(n));