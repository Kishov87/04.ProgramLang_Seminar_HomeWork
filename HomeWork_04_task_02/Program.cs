// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using System;
using static System.Console; 

Clear();
Write("Введите число: ");

WriteLine($"Сумма цифр = {SumNumbers(Convert.ToInt32(ReadLine()))}");

int SumNumbers(int r)
{
    int sum = 0;
    if (r == 0) return 0;
    while (r > 0)
    {
        sum = sum + r%10;
        r /= 10;
    }
    return sum;
}
