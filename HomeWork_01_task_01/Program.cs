//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

using System;
using static System.Console;

Clear();
Write("Введите первое число: ");
int number1 = Convert.ToInt32(ReadLine());
Write("Введите второе число: ");
int number2 = Convert.ToInt32(ReadLine());

if(number1==number2) WriteLine($"{number2}{" = "}{number1}");
else 
{
    if(number1<number2) WriteLine($"{number2}{" > "}{number1}");
    else WriteLine($"{number1}{" > "}{number2}");
}