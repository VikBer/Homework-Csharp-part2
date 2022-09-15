/*
        9. Задачи девятого (9) семинара:

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

Console.Clear();

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);

void Recursion (int a, int b, int sum)
{
        if (a <= 0 && b > 0) 
                {Console.Write("Введено не натуральное число M");
                return;}
                
        if (b <= 0 && a > 0) 
                {Console.Write("Введено не натуральное число N");
                return;}  
        if (a <= 0 && b <= 0) 
                {Console.Write("Введены не натуральные числа M,N");
                return;}
       
        if (a > 0 && a <= b) 
        {
                sum += a++;
                Recursion(a, b, sum);
        }
        else  Console.Write($"{sum} ");     
     
}
Recursion(m,n, 0);