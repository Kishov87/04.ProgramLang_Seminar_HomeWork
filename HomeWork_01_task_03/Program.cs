//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

using System;
using static System.Console;

Clear();
Write("Введите число: ");
int number1 = Convert.ToInt32(ReadLine());
int A = 2;
int N = number1%A;

string answer = N == 0 
?"Да. Число кратное - юююхууу!!!"
:$"Нет. Число не кратное - бууу(((";

WriteLine(answer);