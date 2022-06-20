// // Задача 19
// // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

using System;
using static System.Console;

Clear();
Write("Введите пятизначое число: ");
int Number = Convert.ToInt32(ReadLine());
int j = 10000;
int NewNumber = 0;
int PreNumber = Number;

if (Number < 10000 || Number > 99999)
{
    WriteLine($"{Number} - не пятизначое число!");
    return;
}
while (PreNumber>0)
{
    NewNumber+=(PreNumber%10)*j;
    PreNumber/=10;
    j/=10;
}
WriteLine(NewNumber==Number ?$"{Number} -> палиндром" :$"{Number} -> не палиндром");