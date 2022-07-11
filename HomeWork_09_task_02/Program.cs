// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

Clear();

Write("Введите число N = ");
int n = Convert.ToInt32(ReadLine());
Write("Введите число M = ");
int m = Convert.ToInt32(ReadLine());
WriteLine(GetNumbers(n, m));

int GetNumbers(int start, int end)
{
   {
    return start<=end?start+GetNumbers(start+1, end):0;
}
}