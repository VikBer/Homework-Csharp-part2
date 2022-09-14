/*
        9. Задачи девятого (9) семинара:

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

Console.Clear();

Console.WriteLine("Введите значение N");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение M");
int M = int.Parse(Console.ReadLine()!);

int Recursion (int a, int b)
{
        if (a <= 0 || b <= 0) 
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