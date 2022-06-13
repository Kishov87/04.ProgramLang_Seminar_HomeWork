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

string answer= number1>number2 & number1>number2
?$"{number1}{" > "{number2}{" and "} {number3}}
:number2>number1 & number2>number3
$"{number2}{" > "{number1}{" and "} {number3}}
:number3>number1 & number3>number2
$"{number3}{" > "{number1}{" and "} {number2}};

WriteLine(answer);


//if (number1<number2) WriteLine($"{number2}{" > "}{number1}");
//else WriteLine($"{number1}{" > "}{number2}");