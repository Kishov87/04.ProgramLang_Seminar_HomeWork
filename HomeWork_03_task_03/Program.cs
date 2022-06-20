// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

using System;
using static System.Console; 

Clear();
Write("Введите число: ");
int N = int.Parse(ReadLine());
int q=1;

while(q<N)
{
    Write($"{Math.Pow(q, 3)}, ");
    q++;
}
Write($"{Math.Pow(q, 3)}");