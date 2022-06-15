//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

using System;
using static System.Console;

Clear();
Write("Введите число: ");
int N = Convert.ToInt32(ReadLine());
int i = 1;

while (i<N-2)
{
    Write($"{i+1}, ");
    i = i + 2;
}
Write($"{i+1}");