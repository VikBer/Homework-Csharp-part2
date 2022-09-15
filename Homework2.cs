/*
        9. Задачи девятого (9) семинара:

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/

Console.Clear();

Console.Write("Введите неотрицательное значение m: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите неотрицательное значение N: ");
int n = int.Parse(Console.ReadLine()!);

int RecursionAkkerman (int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return RecursionAkkerman(n - 1, 1);
    else
        return RecursionAkkerman(n - 1, RecursionAkkerman(n, m - 1));
  
     
}

Console.Write($"\n{RecursionAkkerman(m,n)}");