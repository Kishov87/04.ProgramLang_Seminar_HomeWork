//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

using System;
using static System.Console;

Clear();
Write("Введите первое число: ");
int number1 = Convert.ToInt32(ReadLine());
Write("Введите второе число: ");
int number2 = Convert.ToInt32(ReadLine());
Write("Введите третье число: ");
int number3 = Convert.ToInt32(ReadLine());
int max = number1;

if (number1>number2) WriteLine($"Max первое число = {number1}");
else
{
    if (number2>number3) WriteLine($"Max второе число = {number2}");
    else WriteLine($"Max третье число = {number3}");
}