// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

using System;
using static System.Console; 

Clear();

int[] array = GetArrayFromString(ReadLine());
Write($"[{String.Join(", ", array)}] -> {AboveZeroNumbers(array)}");

int[] GetArrayFromString(string arrayStr)
{
    string[] arS=arrayStr.Split(new char[]{' ',',','*'},StringSplitOptions.RemoveEmptyEntries);
    int[] result=new int[arS.Length];
    for(int i=0; i<arS.Length;i++)
    {
        result[i]=int.Parse(arS[i]);
    }
    return result;
}

int AboveZeroNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum+=array[i]<=0?0:1;
    }
    return sum;
}