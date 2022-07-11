// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

using System;
using static System.Console;

Clear();

Write("Введите число N = ");
int n = Convert.ToInt32(ReadLine());
Write("Введите число M = ");
int m = Convert.ToInt32(ReadLine());
if (n < 0 && m < 0) 
WriteLine("Введите значения больше 0!");
else
{
int functAkker = Akk(m, n);
Write($"Функция Аккермана = {functAkker} ");

int Akk(int m, int n)
{
  return (m == 0)?n + 1:n == 0?Akk(m - 1, 1):Akk(m - 1, Akk(m, n - 1));
}
}

