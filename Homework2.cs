﻿/*
        6. Задачи первого семинара:
git checkout Lesson6task41 - Задача 41: 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

string M = "";

Console.WriteLine("Введите строчку цифр через запятую");
int.TryParse(Console.ReadLine(), out M);